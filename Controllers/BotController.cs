using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebSocketBot.DatabaseContext;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot;
using WebSocketBot.BotClient;

namespace WebSocketBot.Controllers
{
    [Route("/")]
    [ApiController]
    public class BotController : ControllerBase
    {
        private readonly ApplicationContext _databaseContext;
        private IWebSocketBot _bot;
        public BotController(ApplicationContext databaseContext, IWebSocketBot bot)
        {
            _bot = bot;
            _databaseContext = databaseContext;
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Update update)
        {
            await _updateHandler.Handle(update);
            return Ok();
        }
    }
}
