using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System;


namespace Model
{
    [Database(Name = "curs")]
    public partial class DBDataContext : DataContext
    {

        private static MappingSource mappingSource = new AttributeMappingSource();

        #region Определения метода расширяемости
        partial void OnCreated();
        #endregion


        public DBDataContext(string connection) :
                base(connection, mappingSource)
        {
            OnCreated();
        }

        public Table<Car> Car
        {
            get
            {
                return this.GetTable<Car>();
            }
        }

        public Table<Client> Client
        {
            get
            {
                return this.GetTable<Client>();
            }
        }

        public Table<Driver> Driver
        {
            get
            {
                return this.GetTable<Driver>();
            }
        }

        public Table<Order> Order
        {
            get
            {
                return this.GetTable<Order>();
            }
        }

        public Table<Profit_driver> Profit_driver
        {
            get
            {
                return this.GetTable<Profit_driver>();
            }
        }

        ////////////////////////////////client
        public void InsertClient(string full_name, string phone_number, string company,
            string login, string password)
        {
            Client client = new Client();
            client.full_name = full_name;
            client.phone_number = phone_number;
            client.company = company;
            client.login = login;
            client.password = password;
            Client.InsertOnSubmit(client);
            SubmitChanges();
        }

        public void UpdateClient(int id_client, string full_name, string phone_number, string company,
            string login, string password)
        {
            Client client = Client.Where(c => c.id_client == id_client).FirstOrDefault();
            client.full_name = full_name;
            client.phone_number = phone_number;
            client.company = company;
            client.login = login;
            client.password = password;
            SubmitChanges();
        }

        public void DeleteClient(int id_client)
        {
            Client client = Client.Where(cl => cl.id_client == id_client).FirstOrDefault();
            Client.DeleteOnSubmit(client);
            SubmitChanges();
        }

        public List<Client> ShowClient()
        {
            return Client.Where(c => c.id_client >= 0).ToList();
        }

        ////////////////////////////////car
        public void InsertCar(string number, string brand, decimal carrying_capacity,
            decimal width, decimal heigth, bool status)
        {
            Car car = new Car();
            car.number = number;
            car.brand = brand;
            car.carrying_capacity = carrying_capacity;
            car.width = width;
            car.heigth = heigth;
            car.status = status;
            Car.InsertOnSubmit(car);
            SubmitChanges();
        }


        public void UpdateCar(int id_car, string number, string brand, decimal carrying_capacity,
           decimal width, decimal heigth, bool status)
        {
            Car car = Car.Where(c => c.id_car == id_car).FirstOrDefault();
            car.number = number;
            car.brand = brand;
            car.carrying_capacity = carrying_capacity;
            car.width = width;
            car.heigth = heigth;
            car.status = status;
            SubmitChanges();
        }

        public void DeleteCar(int id_car)
        {
            Car car = Car.Where(c => c.id_car == id_car).FirstOrDefault();
            Car.DeleteOnSubmit(car);
            SubmitChanges();
        }

        public List<Car> ShowCar()
        {
            return Car.Where(c => c.id_car >= 0).ToList();
        }

        //////////////////////////////driver
        public void InsertDriver(string full_name, string phone_number, DateTime date_of_birth,
            string passport_number, string adress, bool status)
        {
            Driver driver = new Driver();
            driver.full_name = full_name;
            driver.phone_number = phone_number;
            driver.date_of_birth = date_of_birth;
            driver.passport_number = passport_number;
            driver.adress = adress;
            driver.status = status;
            Driver.InsertOnSubmit(driver);
            SubmitChanges();
        }

        public void UpdateDriver(int id_driver, string full_name, string phone_number, DateTime date_of_birth,
            string passport_number, string adress, bool status)
        {
            Driver driver = Driver.Where(d => d.id_driver == id_driver).FirstOrDefault();
            driver.full_name = full_name;
            driver.phone_number = phone_number;
            driver.date_of_birth = date_of_birth;
            driver.passport_number = passport_number;
            driver.adress = adress;
            driver.status = status;
            SubmitChanges();
        }

        public void DeleteDriver(int id_driver)
        {
            Driver driver = Driver.Where(d => d.id_driver == id_driver).FirstOrDefault();
            Driver.DeleteOnSubmit(driver);
            SubmitChanges();
        }

        public List<Driver> ShowDriver()
        {
            return Driver.Where(d => d.id_driver >= 0).ToList();
        }

        ////////////////////////////order
        public void InsertOrder(int id_driver, int id_car, int id_client,
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
            Order.InsertOnSubmit(order);
            SubmitChanges();
        }

        public void UpdateOrder(int id_order, int id_driver, int id_car, int id_client,
            string point_of_departure, string point_of_arrival, decimal weight,
            decimal width, decimal height, string type_cargo, DateTime reg_date, decimal cost, decimal paid)
        {
            Order order = Order.Where(d => d.id_driver == id_order).FirstOrDefault();

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
            SubmitChanges();
        }

        public void DeleteOrder(int id_order)
        {
            Order order = Order.Where(o => o.id_order == id_order).FirstOrDefault();
            Order.DeleteOnSubmit(order);
            SubmitChanges();
        }

        public List<Order> ShowOrder()
        {
            return Order.Where(o => o.id_order >= 0).ToList();
        }


        //////////////////////////profit_driver





    }

}
