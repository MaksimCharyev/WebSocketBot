using Telegram.Bot;
using Telegram.Bot.Types;

namespace WebSocketBot.Utils.UpdateHandlers.Commands
{
    public class StartCommand : ICommandExecutable
    {
        public long chatId { get; set; }
        public StartCommand(long id)
        {
            chatId = id;
        }
        private string Text = "Тест!";
        private TelegramBotClient _botClient = BotClient.BotClient.GetInstance();
        public async Task ExecuteCommand(Update update)
        {
            if (update.Message.Chat.Id == chatId)
            {
                await _botClient.SendTextMessageAsync(chatId, Text);
            }

        }
    }
}
