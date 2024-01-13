using Telegram.Bot;
namespace WebSocketBot.BotClient
{
    public class BotClient
    {
        private static Telegram.Bot.TelegramBotClient _instance;
        private BotClient() { }
        public static TelegramBotClient getInstance()
        {
            if( _instance == null)
            {
                _instance = new Telegram.Bot.TelegramBotClient("6599199486:AAFRq4VBAud49lJeTaAcTSMh0Hinz2gBeOU");
            }
            return _instance;
        }
    }
}
