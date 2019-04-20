using FlyAir.Data.IRepositories;
using FlyAir.Models;
using FlyAir.Models.BookingModels;
using FlyAir.Models.FlightModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base.Abstracts;
using TableDependency.SqlClient.Base.Delegates;
using TableDependency.SqlClient.Base.Enums;
using TableDependency.SqlClient.Base.EventArgs;

namespace FlyAir.Hubs
{
    public class BookingHub : Hub
    {
        private readonly IConfiguration _config;
        private readonly IBookingRepo _bookingRepo;
        private SqlTableDependency<Booking> _tableDependency;

        private static List<TempFlightGroup> _tempFlightGroups = new List<TempFlightGroup>();
        //private static IDictionary connectedUserIdPair = new Dictionary<string, List<TempFlightGroup>>();
        
        public BookingHub(IConfiguration config, IBookingRepo bookingRepo)
        {
            _config = config;
            _bookingRepo = bookingRepo;
        }

        [HttpGet]
        public async Task<string> GetAllGroups()
        {
            return JsonConvert.SerializeObject(_tempFlightGroups);
            //return  "{\"try\": \"try1\"}";
        }

        public async Task<string> GetCurrConnId()
        {
            return JsonConvert.SerializeObject(Context.ConnectionId);
        }

        public async Task<string> JoinGroup(string groupName, bool isExistingGroup, int originId, int destId)
        {
            if (!isExistingGroup)
            {
                _tempFlightGroups.Add(new TempFlightGroup()
                {
                    locId1 = originId,
                    locId2 = destId,
                    groupNameAKAConnId = groupName
                });
            }
            await Groups.AddToGroupAsync(Context.ConnectionId, groupName);

            //call subscribeBookingAdd from here to pass data from client side
            await _bookingRepo.subscribeBookingAdd(originId, destId, groupName);
            return null;
        }

        public Task SendMessageToGroup(string group, string message)
        {
            return Clients.Group(group).SendAsync("ReceiveGroupMessage", message);
        }


        public override async Task OnConnectedAsync()
        {
            await base.OnConnectedAsync();
        }

        //public override async Task OnDisconnectedAsync(Exception ex)
        //{
        //    await Clients.All.SendAsync("UserDisconnected", Context.ConnectionId);
        //    connectedUserIdPair.Remove(Context.ConnectionId);
        //    await base.OnDisconnectedAsync(ex);
        //}
        
    }

    public class TempFlightGroup
    {
        public int locId1 { get; set; }
        public int locId2 { get; set; }
        public string groupNameAKAConnId { get; set; }
    }
}

//reference
//return await Task.Run(() => JsonConvert.SerializeObject(Context.ConnectionId));

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