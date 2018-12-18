using System;
using System.Collections.Generic;
using System.Text;
using Telegram.Bot.Types.ReplyMarkups;

namespace RocketNET.Notification.Telegram.Buttons
{
    public class SimpleButtons
    {
        public SimpleButtons()
        {

        }

        //public IEnumerable<KeyboardButton> GetSimpleButtons1()
        //{
        //    return new KeyboardButton[][]
        //    {
        //        new KeyboardButton[]
        //        {
        //            new KeyboardButton("item"),
        //            new KeyboardButton("item")
        //        },
        //        new KeyboardButton[]
        //        {
        //            new KeyboardButton("item")
        //        }
        //    };
        //}

        public ReplyKeyboardMarkup GetKeywordButtons()
        {
            return new ReplyKeyboardMarkup
            {
                Keyboard = new[]
                {
                    new KeyboardButton[]
                    {
                        new KeyboardButton("item"),
                        new KeyboardButton("item")
                    },
                    new KeyboardButton[]
                    {
                        new KeyboardButton("item")
                    }
                }
            };
        }

        public InlineKeyboardMarkup GetRequisitesButtons()
        {
            var keys = new[]
            {
                new InlineKeyboardButton[]
                {
                    new InlineKeyboardButton()
                    {
                        Text = "Таскомбанк",
                        CallbackData = "Tas"
                    },
                    new InlineKeyboardButton()
                    {
                        Text = "Приватбанк",
                        CallbackData = "Privat"
                    }
                },
                new InlineKeyboardButton[]
                {
                    new InlineKeyboardButton()
                    {
                        Text = "ВТБ Банк",
                        CallbackData = "VTB"
                    },
                    new InlineKeyboardButton()
                    {
                        Text = "Альфа банк",
                        CallbackData = "Alpha"
                    }
                },
                new InlineKeyboardButton[]
                {
                    new InlineKeyboardButton()
                    {
                        Text = "🔙 Назад",
                        CallbackData = "Back"
                    },
                }
            };

            return new InlineKeyboardMarkup(keys);
        }

        public InlineKeyboardMarkup GetInlineButtons()
        {
            var keys = new[]
            {
                new InlineKeyboardButton[]
                {
                    new InlineKeyboardButton()
                    {
                        Text = "💰 Реквізити",
                        CallbackData = "Requisites"
                    },
                    new InlineKeyboardButton()
                    {
                        Text = "Second button 🐷",
                        CallbackData = "Test 2"
                    }
                },
                new InlineKeyboardButton[]
                {
                    new InlineKeyboardButton()
                    {
                        Text = "Third button 😅",
                        CallbackData = "Test 3"
                    },
                    new InlineKeyboardButton()
                    {
                        Text = "Test button 👻",
                        CallbackData = "Test 3"
                    }
                }
            };

            return new InlineKeyboardMarkup(keys);
        }
    }
}
