using Dapper;
using FlyAir.Data.IRepositories;
using FlyAir.Hubs;
using FlyAir.Models;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base.Enums;
using TableDependency.SqlClient.Base.EventArgs;

namespace FlyAir.Data.Repositories
{
    public class dummyRepo : IdummyRepo
    {
        private readonly IConfiguration _config;
        private readonly IdummyRepo _idummyrepo;
        private readonly IHubContext<dummyHub> _hubcontext;
        private SqlTableDependency<dummyModel> _tableDependency;

        public dummyRepo(IConfiguration config, IHubContext<dummyHub> hubcontext)
        {
            _config = config;
            _hubcontext = hubcontext;
        }
        
        private void InitSqlDep()
        {
            SqlDependency.Start(_config.GetConnectionString(commonName.defaultConn));
        }

        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(_config.GetConnectionString(commonName.defaultConn));
            }
        }

        public async Task<IEnumerable<dummyModel>> GetAll()
        {
            using (IDbConnection conn = Connection)
            {
                try
                {
                    string sQuery = "SELECT * FROM dummyTable";
                    conn.Open();
                    var result = await conn.QueryAsync<dummyModel>(sQuery);
                    return result;
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public async Task<IEnumerable<dummyModel>> GetAllSqlDep()
        {
            InitSqlDep();
            using (SqlConnection connection = new SqlConnection(_config.GetConnectionString(commonName.defaultConn)))
            {
                connection.Open();
                using (SqlCommand command =
                    new SqlCommand("SELECT ID, Name FROM [dbo].dummyTable", connection))
                {

                    // Make sure the command object does not already have
                    // a notification object associated with it.
                    command.Notification = null;

                    // Create a dependency and associate it with the SqlCommand.  
                    SqlDependency dependency = new SqlDependency(command);
                    // Maintain the reference in a class member.  

                    // Subscribe to the SqlDependency event.  
                    //dependency.OnChange += new OnChangeEventHandler(dependency_OnChange);
                    dependency.OnChange += dependency_OnChange;


                    if (connection.State == System.Data.ConnectionState.Closed)
                        connection.Open();

                    // Execute the command.  
                    //using (SqlDataReader reader = command.ExecuteReader())
                    //{
                    //    // Process the DataReader.  
                    //}

                    try
                    {

                        var result = await connection.QueryAsync<dummyModel>(command.CommandText);
                        return result;
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }


        }

        public async Task<IEnumerable<dummyModel>> GetSqlTblDep()
        {
            using (SqlConnection connection = new SqlConnection(_config.GetConnectionString(commonName.defaultConn)))
            {
                connection.Open();
                using (SqlCommand command =
                    new SqlCommand("SELECT ID, Name FROM [dbo].dummyTable", connection))
                {
                    try
                    {
                        var cs = _config.GetConnectionString(commonName.defaultConn);
                        _tableDependency = new SqlTableDependency<dummyModel>(cs, "dummyTable", null, null, null, null, DmlTriggerType.All);
                        _tableDependency.OnChanged += Changed;
                        //_tableDependency.OnError += TableDependency_OnError;
                        _tableDependency.Start();
                        var result = await connection.QueryAsync<dummyModel>(command.CommandText);
                        return result;
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        // Handler method  
        private void dependency_OnChange(object sender, SqlNotificationEventArgs e)
        {
            //// Handle the event (for example, invalidate this cache entry).  
            //dummyHub dh = new dummyHub();
            //dh.Show("what", "ok");
        }


        private void Changed(object sender, RecordChangedEventArgs<dummyModel> e)
        {
            if (e.ChangeType != ChangeType.None)
            {
                //using (var dh = new dummyHub(_idummyrepo))
                //{
                //    dh.GetDummyData();
                //}
                //_hubcontext.Clients.All.SendAsync("updateTable", GetSqlTblDep());
                //_hubcontext.Clients.All.SendAsync("UpdateTable", "some thing some thing");
                _hubcontext.Clients.All.SendAsync("UpdateTable", JsonConvert.SerializeObject(GetSqlTblDep().Result));
            }
        }
    }
}
