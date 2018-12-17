using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace bogtelegrama.Models.commands
{
    public class YoCommand : Commands
    {
        public override string Name => "Yo";

        public override async void Execute(Message message, TelegramBotClient client)
        {
            var chatId = message.Chat.Id;
            var messageId = message.MessageId;
            await client.SendTextMessageAsync(0, "", replyToMessageId: 0);
        }
    }
}