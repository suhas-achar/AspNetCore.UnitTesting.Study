using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicle.Api.Models;
using Vehicle.Api.Services;

namespace Vehicle.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private readonly IVehicleService _service;

        public VehiclesController(IVehicleService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<VehicleModel>>> Get()
        {
            return Ok(await _service.Get());
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<VehicleModel>> Get(int id)
        {
            return Ok(await _service.Get(id));
        }

        [HttpPost]
        public async Task<IActionResult> Create(VehicleModel model)
        {
            await _service.Create(model);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(VehicleModel model)
        {
            await _service.Update(model);
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.Delete(id);
            return NoContent();
        }
    }
}
