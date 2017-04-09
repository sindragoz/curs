using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class CarDB
    {
        private DBDataContext db;

        public CarDB(DBDataContext db)
        {
            this.db = db;
        }

        public void Insert(string number, string brand, decimal carrying_capacity,
            decimal width, decimal heigth, bool status)
        {
            Car car = new Car();
            car.number = number;
            car.brand = brand;
            car.carrying_capacity = carrying_capacity;
            car.width = width;
            car.heigth = heigth;
            car.status = status;
            db.Car.InsertOnSubmit(car);
            db.SubmitChanges();
        }


        public void Update(int id_car, string number, string brand, decimal carrying_capacity,
           decimal width, decimal heigth, bool status)
        {
            Car car = db.Car.Where(c => c.id_car == id_car).FirstOrDefault();
            car.number = number;
            car.brand = brand;
            car.carrying_capacity = carrying_capacity;
            car.width = width;
            car.heigth = heigth;
            car.status = status;
            db.SubmitChanges();
        }

        public void Delete(int id_car)
        {
            Car car = db.Car.Where(c => c.id_car == id_car).FirstOrDefault();
            db.Car.DeleteOnSubmit(car);
            db.SubmitChanges();
        }

        public List<Car> Show()
        {
            return db.Car.Where(c => c.id_car >= 0).ToList();
        }

        public int? FindFreeCar()
        {
            Car car = db.Car.Where(c => c.status).FirstOrDefault();
            if (car != null)
            {
                car.status = false;
                return car.id_car;
            }
            return null;
           
        }

        public void SetFree(int? id_car)
        {
            Car car = db.Car.Where(c => c.id_car == id_car).FirstOrDefault();
            car.status = true;
        }
    }
}
