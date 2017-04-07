//using System.Collections.Generic;
//using System.Data.Linq;
//using System.Data.Linq.Mapping;
//using System.Linq;

//namespace curs._1
//{
//    [Database(Name = "curs")]
//    public partial class CursDataContext : DataContext
//    {
       
//        static DataContext dc;

//        public CursDataContext(string connection) :
//                base(connection)
//        {
//            dc = new DataContext(connection);
//        }
        
        
//        public Table<Car> Car
//        {
//            get
//            {
//                return dc.GetTable<Car>();
//            }
//        }
        
//        public Table<Client> Client
//        {
//            get
//            {
//                return GetTable<Client>();
//            }
//        }

//        public Table<Driver> Driver
//        {
//            get
//            {
//                return GetTable<Driver>();
//            }
//        }

//        public Table<Order> Order
//        {
//            get
//            {
//                return GetTable<Order>();
//            }
//        }

//        public Table<Profit_driver> Profit_driver
//        {
//            get
//            {
//                return GetTable<Profit_driver>();
//            }
//        }


//        public void AddCar(string number, string brand, double carrying_capacity,
//            double width, double heigth, bool status)
//        {
//            Car car = new Car();
//            car.number = number;
//            car.brand = brand;
//            car.carrying_capacity = carrying_capacity;
//            car.width = width;
//            car.heigth = heigth;
//            car.status = status;
//            Car.InsertOnSubmit(car);
//            dc.SubmitChanges();
//        }


//        public void UpdateCar(int id_car, string number, string brand, double carrying_capacity,
//           double width, double heigth, bool status)
//        {
//            Car car = Car.Where(c => c.id_car == id_car).FirstOrDefault();
//            car.number = number;
//            car.brand = brand;
//            car.carrying_capacity = carrying_capacity;
//            car.width = width;
//            car.heigth = heigth;
//            car.status = status;
//            dc.SubmitChanges();
//        }

//        public void DelCar(int id_car)
//        {
//            Car car = Car.Where(c => c.id_car == id_car).FirstOrDefault();
            
//            Car.DeleteOnSubmit(car);
//            dc.SubmitChanges();
//        }

//        public List<Car> ShowCar()
//        {
//            return Car.Where(c => c.id_car >= 0).ToList();
//        }


//        public void AddClient(string full_name, string phone_number, string company)
//        {
//            Client client = new Client();
//            client.full_name = full_name;
//            client.phone_number = phone_number;
//            client.company = company;
//            Client.InsertOnSubmit(client);
//            dc.SubmitChanges();
//        }

//        public void UpdateClient(int id_client, string full_name, string phone_number, string company)
//        {
//            Client client = Client.Where(c => c.id_client == id_client).FirstOrDefault();
//            client.full_name = full_name;
//            client.phone_number = phone_number;
//            client.company = company;
//            dc.SubmitChanges();
//        }

//        public void DelClient(int id_client)
//        {
//            Client client = Client.Where(cl => cl.id_client == id_client).FirstOrDefault();
//            Client.DeleteOnSubmit(client);
//            dc.SubmitChanges();
//        }

//        public List<Client> ShowClient()
//        {
//            return Client.Where (c => c.id_client >= 0).ToList();
//        }

//        public void DelClientt(int id_client)
//        {
//            // Car car = Car.Where(c => c.id_car == id_car).FirstOrDefault();
//            Client client = Client.Where(c => c.id_client == id_client).FirstOrDefault();
//            Client.DeleteOnSubmit(client);
//          //  Car.DeleteOnSubmit(car);
//            dc.SubmitChanges();
//        }


//        public void DelDriver(int id_driver)
//        {

//            Driver driver = Driver.Where(d => d.id_driver == id_driver).FirstOrDefault();
//            Driver.DeleteOnSubmit(driver);
//            dc.SubmitChanges();
//        }

//        public List<Driver> ShowDriver()
//        {
//            return Driver.Where(c => c.id_driver >= 0).ToList();
//        }

//    }
//}
