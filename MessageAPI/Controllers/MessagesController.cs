using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.Models;

namespace MessageAPI.Controllers
{
    public class MessagesController : Controller
    {
        private readonly AddMessageService _addMessageService;
        private readonly GetMessagesService _getMessageService;

        public MessagesController(AddMessageService addMessageService, GetMessagesService getMessagesService)
        {
            this._addMessageService = addMessageService;
            this._getMessageService = getMessagesService;
        }
        
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]AddMessageModel model)
        {
            await this._addMessageService.RunAsync(model);
            
            //ToDo more needs doing with error handling
            return Ok();
        }
        
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery]FilterMessagesModel model)
        {
            var result = await this._getMessageService.RunAsync(model);
            
            //ToDo more needs doing with error handling
            return Ok(result);
        }
    }
}