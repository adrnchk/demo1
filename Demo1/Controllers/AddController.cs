using Demo1BLL.Models;
using Demo1BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace Demo1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddController : ControllerBase
    {
        private readonly ILogger<AddController> _logger;
        private readonly IAddService _service;

        public AddController(ILogger<AddController> logger, IAddService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpPost("/add")]
        public async Task<IActionResult> Post(AddModel model)
        {
            try
            {
                return Ok(await _service.AddAsync(model.A, model.B));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest(ex.Message);
            }             
        }
    }
}