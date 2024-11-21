using GymAPI.Controllers;
using GymAPI.Entities;
using GymAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace TestProject
{
    public class EventsControllerTest
    {
        private readonly TrainerController _trainerContorller;

        public EventsControllerTest()
        {
            _trainerContorller = new TrainerController(new FakeContext());
        }
        [Fact]
        public void Get_ReturnsOk()
        {
            var id = "1";

            var result= _trainerContorller.Get(id);

            Assert.IsType<OkObjectResult>(result);

        }
        [Fact]
        public void Get_NotFound()
        {
            var id = "-1";

            var result = _trainerContorller.Get(id);

            Assert.IsType<NotFoundObjectResult>(result);

        }
        [Fact]
        public void GetAll_ReturnsOk()
        {
            
            var result = _trainerContorller.Get();

            Assert.IsType<OkObjectResult>(result);

        }
    }
}