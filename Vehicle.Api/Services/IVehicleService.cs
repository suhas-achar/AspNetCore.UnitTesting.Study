using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicle.Api.Models;

namespace Vehicle.Api.Services
{
    public interface IVehicleService
    {
        Task<IEnumerable<VehicleModel>> Get();
        Task<VehicleModel> Get(int id);
        Task Create(VehicleModel model);
        Task Update(VehicleModel model);
        Task Delete(int id);

        Task<int> GetCount();
    }
}
