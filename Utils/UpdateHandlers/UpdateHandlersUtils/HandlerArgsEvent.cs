using Telegram.Bot.Types;

namespace WebSocketBot.Utils.UpdateHandlers.UpdateHandlersUtils
{
    public class HandlerArgsEvent : EventArgs
    {
        public Update? Update { get; set; }
        public STATES State { get; set; }
        public HandlerArgsEvent() { }
    }
}
