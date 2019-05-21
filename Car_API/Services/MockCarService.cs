using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_API.Controllers
{
    public class MockCarService : CarService
    {
        private List<Car> cars = new List<Car>();

        private int idCount = 1;

        public MockCarService()
        {
            AddCar(name: "BMW", brand: " X5", year: "2015");
            AddCar(name: " VOLVO ", brand: " V70", year: "2017");
            AddCar(name: " Honda", brand: "CHR ", year: "2011");
        }

        public Car AddCar(string name, string brand, string year)
        {

            Car car = new Car() { Id = idCount, Name = name, Brand = brand, Year = year };
            idCount++;
            cars.Add(car);
            return car;
        }

        public bool DeleteCar(int id)
        {
            bool WasRemoved = false;

            foreach (Car item in cars)

            {
                if (item.Id == id)
                {
                    cars.Remove(item);
                    WasRemoved = true;
                    break;
                }
            }

            return WasRemoved;
        }

        public Car FindCar(int id)
        {
            foreach (Car item in cars)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }

        public List<Car> AllCars()
        {
            return cars;
        }

        public bool EditCar(Car car)
        {


            foreach (Car orginal in cars)

            {
                if (orginal.Id == car.Id)
                {
                    orginal.Name = car.Name;
                    orginal.Brand = car.Brand;
                    orginal.Year = car.Year;

                    return true;
                }
            }

            return false;
        }
    }
}
