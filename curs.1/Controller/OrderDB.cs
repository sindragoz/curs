using Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Controller
{
    public class OrderDB
    {

        private DBDataContext db;
        DriverDB driverdb;
        CarDB cardb;
        Profit_driverDB profitdb;
        public OrderDB(DBDataContext db)
        {
            this.db = db;
            driverdb = new DriverDB(db);
            cardb = new CarDB(db);
            profitdb = new Profit_driverDB(db);
        }


        public void Insert(string point_of_departure, string point_of_arrival, decimal weight,
            decimal width, decimal height)
        {
            Order order = new Order();

            
            order.id_driver = driverdb.FindFreeDriver();

            if (Visitor.client!=null)
            {
                order.id_client = Visitor.client.id_client;
            } 

            order.point_of_departure = point_of_departure;
            order.point_of_arrival = point_of_arrival;
            order.weight = weight;
            order.width = width;
            order.height = height;

            order.id_car = cardb.FindFreeCar(order);

            order.reg_date = DateTime.Now;
            order.cost = CountCost(order);
            order.paid = 0;  //(order.cost/10);
            order.status = "заказ обрабатывается";
            db.Order.InsertOnSubmit(order);
            db.SubmitChanges();
        }

        public void Update(int id_order, int? id_driver, int? id_car, int id_client,
            string point_of_departure, string point_of_arrival, decimal weight,
            decimal width, decimal height, string status, DateTime reg_date, decimal cost, decimal paid)
        {
            Order order = db.Order.Where(o => o.id_order == id_order).FirstOrDefault();

            order.id_driver = id_driver;
            order.id_car = id_car;
            order.id_client = id_client;
            order.point_of_departure = point_of_departure;
            order.point_of_arrival = point_of_arrival;
            order.weight = weight;
            order.width = width;
            order.height = height;
            order.status = status;
            order.reg_date = reg_date;
            order.cost = cost;
            order.paid = paid;

            if(order.status == "готово")
            {
                if (order.id_driver != null)
                    driverdb.SetFree(order.id_driver);

                if (order.id_car != null)
                    cardb.SetFree(order.id_car);
            }

            db.SubmitChanges();

            if (order.status == "готово")
            {
                profitdb.Insert((int)order.id_driver, order.id_order);
            }
            SetDriver();
            SetCar();


        }

        public void Delete(int id_order)
        {
            Order order = db.Order.Where(o => o.id_order == id_order).FirstOrDefault();
            if (order.status!= "готово")
            {
                if (order.id_driver != null)
                    driverdb.SetFree(order.id_driver);
                    
                if (order.id_car != null)
                    cardb.SetFree(order.id_car);
            }
            db.Order.DeleteOnSubmit(order);
            db.SubmitChanges();

            SetDriver();
            SetCar();
            
        }

        public List<Order> Show()
        {
            return db.Order.Where(o => o.id_order >= 0).ToList();
        }

        public List<Order> Show(int id_client)
        {
            return db.Order.Where(o => o.id_client == id_client).ToList();
        }

        private decimal CountCost(Order order)
        {
            /*
             * 1км = 23р
             * за вес больше 500кг цена увеличивается на 5% за каждые 50кг
             * постоянным клиентом скидка 10%
             */

            ClientDB clientdb = new ClientDB(db);

            int price_km = 23;
            int good_weight = 500;
            double per_cent = 0.05;
            double discount = 0.1;


            decimal cost;
            double distance = 100;  //order.point_of_departure - order.point_of_arrival;
            cost = (decimal)distance * price_km;
            if(order.weight > good_weight)
            {
                decimal difference = Math.Floor((order.weight - good_weight) / 50);
                cost = cost + cost * (difference * (decimal)per_cent);
            }
            if (clientdb.IsVIPClient(order.id_client))
            {
                cost -= cost*(decimal)discount;
            }

            return cost;
        }

        public void SetDriver()
        {
            Order order = db.Order.Where(o => o.id_driver == null).FirstOrDefault();
            if (order != null)
            {
                order.id_driver = driverdb.FindFreeDriver();
                if (order.id_driver != null)
                {
                    db.SubmitChanges();
                }
            }
            
            
        }

        public void SetCar()
        {
            Order order = db.Order.Where(o => o.id_car == null).FirstOrDefault();
            if (order != null)
            {
                order.id_car = cardb.FindFreeCar(order);
                if (order.id_car != null)
                {
                    db.SubmitChanges();
                }
            }

           
        }

    }
}
