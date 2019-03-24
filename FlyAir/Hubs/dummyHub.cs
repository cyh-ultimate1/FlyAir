using FlyAir.Data.IRepositories;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlyAir.Hubs
{
    public class dummyHub : Hub
    {
        private readonly IdummyRepo _dummyRepo;

        public dummyHub(IdummyRepo dummyRepo)
        {
            _dummyRepo = dummyRepo;
        }

        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

        //public async Task GetDummyData()
        //{
        //    //Clients.All.SendAsync("ReceiveMessage", user, message);
        //    //var dummy = await _dummyRepo.GetSqlTblDep();
        //    await Clients.All.SendAsync("UpdateTable", "objobj");
        //}
    }
}
