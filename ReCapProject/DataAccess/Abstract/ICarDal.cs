using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //Dal - Data Access Layer
    public interface ICarDal
    {
        List<Car> GetAll();

        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);

        List<Car> GetAllByBrand(int brandId);
    }
}
