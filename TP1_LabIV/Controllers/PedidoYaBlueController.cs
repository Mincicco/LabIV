using Microsoft.AspNetCore.Mvc;
using TP1_LabIV.Service;

namespace TP1_LabIV.Controllers
{
    public class PedidoYaBlueController
    {
        [Route("api/[controller]")]
        [ApiController]
        public class PedidosYaBlueController : ControllerBase
        {
            private readonly PedidoYaBlueService _service;

            public PedidosYaBlueController(PedidoYaBlueService service)
            {
                _service = service;
            }

            [HttpPost("CreateOrder")]
            public ActionResult<string> CreateNewOrder(string clientType)
            {
                return Ok(_service.CreateNewOrder(clientType));
            }

            [HttpGet("GetLocation")]
            public ActionResult<string> GetLocation()
            {
                return Ok(_service.GetLocation());
            }

        }
    }

}
