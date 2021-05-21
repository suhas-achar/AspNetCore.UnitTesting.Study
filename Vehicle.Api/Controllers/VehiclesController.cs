using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicle.Api.Models;

namespace Vehicle.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VehicleModel>>> Get()
        {
            return Ok(await Task.FromResult(new List<VehicleModel>
            {
                new VehicleModel {Id = 1, Make="Tata", Model = "LPT1612", Owner="Ravindra", Year=2009},
                new VehicleModel {Id = 1, Make="Honda", Model = "Unicorn", Owner="Sumit", Year=2016},
                new VehicleModel {Id = 1, Make="Suzuki", Model = "Brezza", Owner="Devesh", Year=2020},
            }));
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<VehicleModel>> Get(int id)
        {
            return Ok(await Task.FromResult(new VehicleModel { Id = 1, Make = "Tata", Model = "LPT1612", Owner = "Ravindra", Year = 2009 }));
        }

        [HttpPost]
        public async Task<IActionResult> Create(VehicleModel model)
        {
            return await Task.FromResult(Ok());
        }

        [HttpPut]
        public async Task<IActionResult> Update(VehicleModel model)
        {
            return await Task.FromResult(Ok());
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            return await Task.FromResult(NoContent());
        }
    }
}
