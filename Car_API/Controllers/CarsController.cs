using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Car_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        CarService _carService;
        public CarsController(CarService carService)
        {
            _carService = carService;
        }

        [HttpGet]
        public List<Car> GetAll()
        {
            return _carService.AllCars();
        }

        [HttpPost]
        public ActionResult<Car> AddCar([FromBody]Car car)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var newCar = _carService.AddCar(car.Name, car.Brand, car.Year);
            return newCar;
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var isDeleted = _carService.DeleteCar(id);
            if (!isDeleted)
            {
                return NotFound();
            }
            return NoContent();
        }

        [HttpPut("{id}")]
        public ActionResult<Car> Edit(int id, [FromBody]Car car)
        {
            var carFromDb = _carService.FindCar(id);
            if (carFromDb == null)
            {
                return NotFound();
            }
            _carService.EditCar(car);
            return car;
        }
    }
}
