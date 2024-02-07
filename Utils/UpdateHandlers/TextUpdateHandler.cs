using Telegram.Bot.Types;
using WebSocketBot.Utils.UpdateHandlers.Commands;
using WebSocketBot.Utils.UpdateHandlers.UpdateHandlersUtils;

namespace WebSocketBot.Utils.UpdateHandlers
{
    public class TextUpdateHandler : ITelegramUpdateHandler
    {
        public async Task UpdateHandle(HandlerArgsEvent args)
        {
            Update update = args.Update;
            if (update == null) return;
            else if (update.Message == null) return;
            else
            {
                switch (update.Message.Text)
                {
                    case "/start":
                        {
                            var startCommand = new StartCommand(update.Message.Chat.Id);
                            await startCommand.ExecuteCommand(update);
                            break;
                        }
                }
            }
        }
    }
}
