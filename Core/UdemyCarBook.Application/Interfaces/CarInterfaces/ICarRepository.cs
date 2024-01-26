using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Interfaces.CarInterfaces
{
    public interface ICarRepository
    {

        List<Car>GetCarsListWithBrands();
        List<Car>GetLast5CarsWithBrands(); // son 5 aracı getir şeklinde bunu ekledik Ardından Car repository'e gidip bunu
        //implemente ettik


    }
}
