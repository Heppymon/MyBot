﻿using MyBotCore.Shared.Interfaces;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace MyBotCore.Services
{
    public class MainScenario : IScenario
    {
        private readonly IKeyboardService keyboardService;
        private readonly ITelegramBotClient botClient;

        public MainScenario(IKeyboardService keyboardService, ITelegramBotClient botClient)
        {
            this.keyboardService = keyboardService;
            this.botClient = botClient;
        }

        public async Task OnCallbackQuery(CallbackQuery query)
        {
            throw new NotImplementedException();
        }

        public Task OnChannelPost(Message message)
        {
            throw new NotImplementedException();
        }

        public Task OnChosenInlineResult(ChosenInlineResult inlineResult)
        {
            throw new NotImplementedException();
        }

        public Task OnEditedChannelPost(Message message)
        {
            throw new NotImplementedException();
        }

        public Task OnEditedMessageReceived(Message message)
        {
            throw new NotImplementedException();
        }

        public Task OnInlineQuery(InlineQuery query)
        {
            throw new NotImplementedException();
        }

        public Task OnMessageReceived(Message message)
        {
            throw new NotImplementedException();
        }

        public Task OnUnknown(Update update)
        {
            throw new NotImplementedException();
        }
    }
}
