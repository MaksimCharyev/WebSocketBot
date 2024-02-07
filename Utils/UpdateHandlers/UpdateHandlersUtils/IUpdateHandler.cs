using Telegram.Bot.Types;

namespace WebSocketBot.UpdateHandlers
{
    public interface ITelegramUpdateHandler
    {
        public Task UpdateHandle(HandlerArgsEvent args);
    }
}
