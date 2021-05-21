using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicle.Api.Controllers;
using Vehicle.Api.Models;
using Vehicle.Api.Services;

namespace Vehicle.Api.Tests
{
    //  Developer friendly
    //  live-documentation
    [TestFixture(Description = "VehicleController should ")]
    public class VehiclesControllerShould
    {
        private VehiclesController controller;
        private IVehicleService _service;

        [SetUp]
        public void Setup()
        {
            this._service = Substitute.For<IVehicleService>();
            this.controller = new VehiclesController(_service);
        }

        [Test(Description = "return IEnumerable<VehicleModel> for GET")]
        public async Task GetAll()
        {
            //  invoke the Get on the controller
            ActionResult<IEnumerable<VehicleModel>> response = await controller.Get();

            //  response is not null
            Assert.IsNotNull(response);

            var result = (response.Result as OkObjectResult).Value as IEnumerable<VehicleModel>;

            //  result is of the particular type
            Assert.IsInstanceOf<IEnumerable<VehicleModel>>(result);

            //  length is 3
            Assert.AreEqual(result.Count(), 3);
        }


        [Test(Description = "return VehicleModel for GET with id")]
        public async Task GetById()
        {
            //  invoke the Get on the controller
            ActionResult<VehicleModel> response = await controller.Get(14);

            //  response is not null
            Assert.IsNotNull(response);

            var result = (response.Result as OkObjectResult).Value as VehicleModel;

            //  length is 3
            Assert.IsNotNull(result);
        }

        [Test(Description = "create VehicleModel")]
        public async Task Create()
        {
            //  invoke the Get on the controller
            OkResult response = await controller.Create(new VehicleModel()) as OkResult;

            Assert.AreEqual(200, response.StatusCode);
        }

        [Test(Description = "update VehicleModel")]
        public async Task Update()
        {
            //  invoke the Get on the controller
            OkResult response = await controller.Update(new VehicleModel()) as OkResult;

            Assert.AreEqual(200, response.StatusCode);
        }

        [Test(Description = "delete by id")]
        public async Task Delete()
        {
            //  invoke the Get on the controller
            NoContentResult response = await controller.Delete(101) as NoContentResult;

            Assert.IsNotNull(response);

            //  also possible
            //  In case status code is 200 or 204, ...
            //Assert.IsTrue(response.StatusCode >= 200 && response.StatusCode < 300);
        }
    }
}