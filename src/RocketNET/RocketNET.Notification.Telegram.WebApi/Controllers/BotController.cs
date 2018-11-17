using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace RocketNET.Notification.Telegram.WebApi.Controllers
{
    /// <summary>
    /// Strat server - ngrok http 54146 -host-header="localhost:54146"
    /// </summary>
    [Produces("application/json")]
    [Route("bot")]
    public class BotController : Controller
    {
        private readonly TelegramBotClient _client =
            new TelegramBotClient("");

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Test");
        }

        [HttpPost]
        public async void Post([FromBody]Update update)
        {
            if (update == null)
                return;

            var message = update.Message;
            if (message?.Type == MessageType.Text)
            {

                if(!String.IsNullOrEmpty(message.Chat.Username))
                    await _client.SendTextMessageAsync(message.Chat.Id,
                        $"Hi, {message.Chat.Username}, " + message.Text);
                else
                    await _client.SendTextMessageAsync(message.Chat.Id, message.Text);
            }
        }
    }
}