using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RocketNET.Notification.Telegram.Buttons;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace RocketNET.Notification.Telegram.WebApi.Controllers
{
    /// <summary>
    /// Strat server - ngrok http 54146 -host-header="localhost:54146"
    /// </summary>
    [Produces("application/json")]
    [Route("bot")]
    public class BotController : Controller
    {
        private string _about = "Даний бот створений для оповіщення користувачів про стан системи та отримання інформації";
        private string _help = "Для отримання підтримки та додаткову інформацію про бота - зверніться до розробників";
        private string _status = "Статус системи: \nСервіс сповіщення: ✅\nСервіс аналізу: ✅\nСервіс навчання: ✅\nСервіс розподілення: ✅\nСервіс інтеграції: ✅";
        private string _information = "";

        private readonly TelegramBotClient _client =
            new TelegramBotClient("");

        [HttpGet]
        public IActionResult Get()
        {
            string text1 = "⚠️ Сервіс аналізу видав попередження при оброці системи";
            string text2 = "❌ Сервіс навчання видав помилку при оброці задачі Id - " + Guid.NewGuid();
            string text3 = "✅ Сервіс сповіщення працює у штатному режимі";

            //_client.SendTextMessageAsync(288101360, text3);
            return Ok("Test");
        }

        [HttpPost]
        public async void Post([FromBody]Update update)
        {
            SimpleButtons buttons = new SimpleButtons();

            var message = update.Message;
            if (message?.Type == MessageType.Text)
            {
                switch (message.Text)
                {
                    case "/start":
                        await _client.SendTextMessageAsync(message.Chat.Id, _about, replyMarkup: buttons.GetInlineButtons());
                        break;
                    case "/about":
                        await _client.SendTextMessageAsync(message.Chat.Id, _about);
                        break;
                    case "/version":
                        await _client.SendTextMessageAsync(message.Chat.Id, "Версія системи: 1.0.0.0");
                        break;
                    case "/help":
                        await _client.SendTextMessageAsync(message.Chat.Id, _help);
                        break;
                    case "/status":
                        await _client.SendTextMessageAsync(message.Chat.Id, _status);
                        break;
                    case "/information":
                        await _client.SendTextMessageAsync(message.Chat.Id, _information);
                        break;

                    default:
                        if (!String.IsNullOrEmpty(message.Chat.Username))
                            await _client.SendTextMessageAsync(message.Chat.Id,
                                $"Hi, {message.Chat.Username}, " + message.Text); // , replyMarkup: buttons.GetInlineButtons()
                        else
                            await _client.SendTextMessageAsync(message.Chat.Id, message.Text,
                                replyMarkup: buttons.GetInlineButtons());
                        break;
                }
            }

            if (update.Type == UpdateType.CallbackQuery)
            {
                switch (update.CallbackQuery.Data)
                {
                    case "Requisites":
                        //await _client.SendChatActionAsync(update.CallbackQuery.Message.Chat.Id, ChatAction.Typing);

                        await _client.AnswerCallbackQueryAsync(
                            update.CallbackQuery.Id,
                            "🐖");

                        await _client.SendTextMessageAsync(update.CallbackQuery.Message.Chat.Id, _about,
                            replyMarkup: buttons.GetRequisitesButtons());
                        break;
                    case "Back":
                        //await _client.SendChatActionAsync(update.CallbackQuery.Message.Chat.Id, ChatAction.Typing);

                        await _client.AnswerCallbackQueryAsync(
                            update.CallbackQuery.Id,
                            "🐖");

                        await _client.SendTextMessageAsync(update.CallbackQuery.Message.Chat.Id, _about,
                            replyMarkup: buttons.GetInlineButtons());
                        break;
                    default:
                        break;
                }
            }
        }
    }
}