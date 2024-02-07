using Telegram.Bot.Types;

namespace WebSocketBot.Utils.UpdateHandlers.Commands
{
    public interface ICommandExecutable
    {
        public long chatId { get; set; }
        public Task ExecuteCommand(Update update);
    }
}
