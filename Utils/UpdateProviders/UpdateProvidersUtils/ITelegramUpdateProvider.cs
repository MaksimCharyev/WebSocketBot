using Telegram.Bot.Types;

namespace WebSocketBot.Utils.UpdateProviders.UpdateProvidersUtils
{
    public interface ITelegramUpdateProvider
    {
        public Task SetUpdate(Update update);
    }
}
