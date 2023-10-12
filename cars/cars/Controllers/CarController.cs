using cars.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;

namespace cars.Controllers
{
    [Route("cars")]
    [ApiController]
    public class CarController : ControllerBase
    {
        [HttpGet("{Id}")]

        public ActionResult Get(Guid id)
        {
            using (var context = new CarContext())
            {
                var result = context.Cars.Where(x => x.Id == id);
                return Ok();
            }

               
        }

        [HttpPut("{id}")]
        public ActionResult Put(Guid id, UpdateCarDto updateCarDto)
        {
            using (var context = new CarContext())
            {
                var existingCar = context.Cars.FirstOrDefault(x => x.Id == id);
                
                existingCar.Name = updateCarDto.Name;
                existingCar.Description = updateCarDto.Description;

                context.Cars.Add(existingCar);
                context.SaveChanges();
                return Ok();
            }
        }
        [HttpPost]
        public ActionResult<CarDto>Post(CreatedCarDto car)
        {
            using (var context = new CarContext())
            {
                var request = new Car
                {
                    Id = Guid.NewGuid(),
                    Name = car.Name,
                    Description = car.Description,
                    CreatedTime = DateTime.Now
                };
                context.Cars.Add(request);
                context.SaveChanges();

                return Ok(request.AsDto());

            }

              
        }
    }
}
