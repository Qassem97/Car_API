using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Car_API.Controllers
{
    public interface CarService
    {
        Car AddCar(string name, string brand, string year);
        //R 
        Car FindCar(int id);
        List<Car> AllCars();
        //U
        bool EditCar(Car car);
        //D
        bool DeleteCar(int id);
    }
}
