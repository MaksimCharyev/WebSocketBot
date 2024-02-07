using Telegram.Bot;
namespace WebSocketBot.BotClient
{
    public class BotClient : IWebSocketBot
    {
        private static Telegram.Bot.TelegramBotClient _instance;
        private delegate Task Handler(object sender, EventArgs args);
        private event Handler? Notify;
        private BotClient() { }
        public static TelegramBotClient GetInstance()
        {
            if( _instance == null)
            {
                _instance = new Telegram.Bot.TelegramBotClient("Secret");
            }
            return _instance;
        }
    }
}
