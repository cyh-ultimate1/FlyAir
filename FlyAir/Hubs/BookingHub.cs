using FlyAir.Data.IRepositories;
using FlyAir.Models;
using FlyAir.Models.BookingModels;
using FlyAir.Models.FlightModels;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base.Enums;
using TableDependency.SqlClient.Base.EventArgs;

namespace FlyAir.Hubs
{
    public class BookingHub : Hub
    {
        private readonly IConfiguration _config;
        private readonly IBookingRepo _bookingRepo;
        private SqlTableDependency<Booking> _tableDependency;

        public BookingHub(IConfiguration config, IBookingRepo bookingRepo)
        {
            _config = config;
            _bookingRepo = bookingRepo;
        }

        //public void subscribeBookingAdd()
        //{
        //    using (SqlConnection connection = new SqlConnection(_config.GetConnectionString(commonName.defaultConn)))
        //    {
        //        try
        //        {
        //            var cs = _config.GetConnectionString(commonName.defaultConn);
        //            _tableDependency = new SqlTableDependency<Booking>(cs, "Bookings", null, null, null, null, DmlTriggerType.Insert);
        //            _tableDependency.OnChanged += Changed;
        //            //_tableDependency.OnError += TableDependency_OnError;
        //            _tableDependency.Start();
        //        }
        //        catch (Exception)
        //        {
        //            throw;
        //        }
        //        finally
        //        {
        //            connection.Close();
        //        }
        //    }
        //}

        //private void Changed(object sender, RecordChangedEventArgs<Booking> e)
        //{
        //    if (e.ChangeType != ChangeType.None)
        //    {
        //        Clients.All.SendAsync("UpdateTable", "Someone just booked.");
        //    }
        //}
    }
}
