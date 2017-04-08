using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class OrderDB
    {

        private DBDataContext db;

        public OrderDB(DBDataContext db)
        {
            this.db = db;
        }


        public void Insert(int id_driver, int id_car, int id_client,
            string point_of_departure, string point_of_arrival, decimal weight,
            decimal width, decimal height, string type_cargo, DateTime reg_date, decimal cost, decimal paid)
        {
            Order order = new Order();
            order.id_driver = id_driver;
            order.id_car = id_car;
            order.id_client = id_client;
            order.point_of_departure = point_of_departure;
            order.point_of_arrival = point_of_arrival;
            order.weight = weight;
            order.width = width;
            order.height = height;
            order.type_cargo = type_cargo;
            order.reg_date = reg_date;
            order.cost = cost;
            order.paid = paid;
            db.Order.InsertOnSubmit(order);
            db.SubmitChanges();
        }

        public void Update(int id_order, int id_driver, int id_car, int id_client,
            string point_of_departure, string point_of_arrival, decimal weight,
            decimal width, decimal height, string type_cargo, DateTime reg_date, decimal cost, decimal paid)
        {
            Order order = db.Order.Where(d => d.id_driver == id_order).FirstOrDefault();

            order.id_driver = id_driver;
            order.id_car = id_car;
            order.id_client = id_client;
            order.point_of_departure = point_of_departure;
            order.point_of_arrival = point_of_arrival;
            order.weight = weight;
            order.width = width;
            order.height = height;
            order.type_cargo = type_cargo;
            order.reg_date = reg_date;
            order.cost = cost;
            order.paid = paid;
            db.SubmitChanges();
        }

        public void Delete(int id_order)
        {
            Order order = db.Order.Where(o => o.id_order == id_order).FirstOrDefault();
            db.Order.DeleteOnSubmit(order);
            db.SubmitChanges();
        }

        public List<Order> Show()
        {
            return db.Order.Where(o => o.id_order >= 0).ToList();
        }

    }
}
