using System.Collections.Generic;
using System.Threading.Tasks;
using Vehicle.Api.Models;

namespace Vehicle.Api.Services
{
    public class VehicleService : IVehicleService
    {
        public async Task Create(VehicleModel model)
        {
            await Task.CompletedTask;
        }

        public async Task Delete(int id)
        {
            await Task.CompletedTask;
        }

        public async Task<IEnumerable<VehicleModel>> Get()
        {
            return await Task.FromResult(new List<VehicleModel>
            {
                new VehicleModel {Id = 1, Make="Tata", Model = "LPT1612", Owner="Ravindra", Year=2009},
                new VehicleModel {Id = 1, Make="Honda", Model = "Unicorn", Owner="Sumit", Year=2016},
                new VehicleModel {Id = 1, Make="Suzuki", Model = "Brezza", Owner="Devesh", Year=2020},
            });
        }

        public async Task<VehicleModel> Get(int id)
        {
            return await Task.FromResult(new VehicleModel { Id = id, Make = "Tata", Model = "LPT1612", Owner = "Ravindra", Year = 2009 });
        }

        public async Task Update(VehicleModel model)
        {
            await Task.CompletedTask;
        }
    }
}
