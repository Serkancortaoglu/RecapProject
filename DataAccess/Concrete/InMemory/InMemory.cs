using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemory : IProductDal
    {
        List<Car> _car;
        public InMemory()
        {
            _car = new List<Car>
            {
                new Car
                {
                    ColorId=8,
                    BrandId=77,
                    Id=3,
                    ModelYear=2018,
                    DailyPrice=170,
                    Description="Clear"
                },
                new Car
                {
                    ColorId=88,
                    BrandId=7,
                    Id=37,
                    ModelYear=2020,
                    DailyPrice=200,
                    Description="Good"
                }
            };
        }


        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(p => p.Id == car.Id);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetById(int Id)
        {
            return _car.Where(p => p.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car CarToUpdate = _car.SingleOrDefault(p=>p.ModelYear==car.ModelYear);
        }
    }
}
