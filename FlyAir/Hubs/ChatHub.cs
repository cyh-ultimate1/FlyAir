using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FlyAir.Hubs
{
    [Authorize]
    public class ChatHub : Hub
    {
        private static IDictionary connectedUserIdPair = new Dictionary<string, string>();

        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

        //public async Task SendPrivateMessage2(string user, string message, string toUser)
        //{
        //    var connId = Context.ConnectionId;
        //    var name = Context.UserIdentifier;
        //    await Clients.Users(name, "2").SendAsync("ReceivePrivateMessage2", user, message);
        //}

        public async Task SendPrivateMessage(string connectionId, string message)
        {
            //await Clients.Clients(connectionId).SendAsync("ReceivePrivateMessage", message);
            await Clients.Group(connectionId).SendAsync("ReceivePrivateMessage", message);
        }

        public Task JoinGroup(string group)
        {
            return Groups.AddToGroupAsync(Context.ConnectionId, group);
        }

        public Task SendMessageToGroup(string group, string message, string user)
        {
            return Clients.Group(group).SendAsync("ReceiveGroupMessage", message, user);
        }

        public string GetAllConnectedUsers()
        {
            return JsonConvert.SerializeObject(connectedUserIdPair);
        }

        public override async Task OnConnectedAsync()
        {
            await Clients.All.SendAsync("UserConnected", Context.ConnectionId, Context.User.Identity.Name);
            connectedUserIdPair.Add(Context.ConnectionId, Context.User.Identity.Name);
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception ex)
        {
            await Clients.All.SendAsync("UserDisconnected", Context.ConnectionId);
            connectedUserIdPair.Remove(Context.ConnectionId);
            await base.OnDisconnectedAsync(ex);
        }
    }
}
