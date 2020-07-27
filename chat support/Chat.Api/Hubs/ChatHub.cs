﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chat.Api.Hubs
{
    [Authorize]
    public class ChatHub : Hub<IChatClient>
    {
        /// <summary>
        /// 重写 连接
        /// </summary>
        /// <returns></returns>
        public override async Task OnConnectedAsync()
        {
            //这里根据获取到的token获取信息 根据指定的数据进行分组 例如租户id
            var groupName = "group_1";
            await Groups.AddToGroupAsync(Context.ConnectionId, groupName);
            await Task.CompletedTask;
        }
    }
}
