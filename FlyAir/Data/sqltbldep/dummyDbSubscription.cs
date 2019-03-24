using FlyAir.Data.IRepositories;
using FlyAir.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base.Enums;
using TableDependency.SqlClient.Base.EventArgs;

namespace FlyAir.Data.sqltbldep
{
    public interface IDatabaseSubscription
    {
        void Configure(string connectionString);
    }

    public class dummyDbSubscription : IDatabaseSubscription
    {
        private bool disposedValue = false;
        private readonly IdummyRepo _repository;
        private SqlTableDependency<dummyModel> _tableDependency;

        public dummyDbSubscription(IdummyRepo repository)
        {
            _repository = repository;
        }

        public void Configure(string connectionString)
        {
            _tableDependency = new SqlTableDependency<dummyModel>(connectionString, null, null, null, null, null, DmlTriggerType.All);
            _tableDependency.OnChanged += Changed;
            //_tableDependency.OnError += TableDependency_OnError;
            _tableDependency.Start();

            //Console.WriteLine("Waiting for receiving notifications...");
        }

        private void Changed(object sender, RecordChangedEventArgs<dummyModel> e)
        {
            if (e.ChangeType != ChangeType.None)
            {

            }
        }
    }
}
