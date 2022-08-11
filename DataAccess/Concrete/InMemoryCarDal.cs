using ReCapProject.DataAccess.Abstract;
using ReCapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ReCapProject.DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars= new List<Car>
            {  
                new Car {Id=1, BrandId=3, ColorId=2, ModelYear=2020, DailyPrice=400, Description= "2020 model, siyah renk, Renault Megane"},
                new Car {Id=2, BrandId=1, ColorId=5, ModelYear=2021, DailyPrice=500, Description= "2021 model, kırmızı renk, Ford Focus"},
                new Car {Id=3, BrandId=2, ColorId=4, ModelYear=2019, DailyPrice=450, Description= "2019 model, lacivert renk, Toyota Corolla"},
                new Car {Id=4, BrandId=4, ColorId=1, ModelYear=2015, DailyPrice=250, Description= "2015 model, beyaz renk, Peugeot 308"},
                new Car {Id=5, BrandId=3, ColorId=3, ModelYear=2022, DailyPrice=500, Description= "2022 model, gri renk, Renault Clio"},
                new Car {Id=6, BrandId=5, ColorId=2, ModelYear=2017, DailyPrice=400, Description= "2017 model, siyah renk, Mercedes-Benz E180"},
                new Car {Id=7, BrandId=1, ColorId=1, ModelYear=2016, DailyPrice=300, Description= "2016 model, beyaz renk, Ford Mondeo"},
                new Car {Id=8, BrandId=4, ColorId=3, ModelYear=2018, DailyPrice=450, Description= "2018 model, gri renk, Peugeot 5008"},
                new Car {Id=9, BrandId=6, ColorId=2, ModelYear=2014, DailyPrice=350, Description= "2014 model, siyah renk, Audi A3"},
            };

        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.First(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

       
        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

        public List<Car> GetByBrandId(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public List<Car> GetByColorId(int colorId)
        {
            return _cars.Where(c => c.ColorId == colorId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.First(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        }
    }
}