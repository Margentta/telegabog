using bogtelegrama.Models.commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Telegram.Bot;

namespace bogtelegrama.Models
{
    public static class Bot
    {
        private static TelegramBotClient client;
        private static List<Commands> commandsList;
        public static IReadOnlyList<Commands> Comandu { get => commandsList.AsReadOnly(); }
        public static async Task <TelegramBotClient> Get()
        {
          if(client != null)
          {
             return client;
          }
            commandsList = new List<Commands>();
            commandsList.Add(new YoCommand());
            client = new TelegramBotClient(appSettings.Key);
            var hook = string.Format(appSettings.Url, "api/message/update:");
          await client.SetWebhookAsync("");
            return client;
        }

    }
}