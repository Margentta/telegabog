﻿using bogtelegrama.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using System.Threading.Tasks;

using Telegram.Bot.Types;

namespace bogtelegrama.Controllers
{
    public class MessageController : ApiController
    {
        [Route(@"api/message/update")]
        public async Task<OkResult> Update([FromBody]Update update )
        {
            var commands = Bot.Comandu;
            var message = update.Message;
            var client =await  Bot.Get();
            foreach(var command in commands)
            {
                if(command.Contains(message.Text))
                {
                    command.Execute(message, client);
                    break;
                }
            }
            return Ok();
        }
    }
}
