using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebSocketBot.DatabaseContext;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot;

namespace WebSocketBot.Controllers
{
    [Route("/")]
    [ApiController]
    public class BotController : ControllerBase
    {

        private readonly ApplicationContext _databaseContext;
        private Telegram.Bot.TelegramBotClient _bot = BotClient.BotClient.getInstance();
        public BotController(ApplicationContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Update update)
        {
            if(update != null && update.Message != null && update.Message.Text != null && update.Message.Text == "StartTest")
            {
                InlineKeyboardMarkup keyboard = new(new[]
            {
                new[]
                {
                    InlineKeyboardButton.WithCallbackData("Меню 2","Menu2")
                }
            });
                await _bot.SendTextMessageAsync(update.Message.Chat.Id, "Test", replyMarkup: keyboard);
                return Ok();
            }
            if (update != null && update.CallbackQuery != null && update.CallbackQuery.Data == "Menu2")
            {
                InlineKeyboardMarkup keyboard = new(new[]
            {
                new[]
                {
                    InlineKeyboardButton.WithCallbackData("Меню 1","Menu1")
                }
            });
                await _bot.EditMessageReplyMarkupAsync(update.CallbackQuery.From.Id, update.CallbackQuery.Message.MessageId, keyboard);
                return Ok();
            }
            return Ok();
        }
    }
}
