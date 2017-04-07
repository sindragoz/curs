//using System.Data.Linq;
//using System.Data.Linq.Mapping;
//using System.ComponentModel;
//using System;

//namespace curs._1
//{

//    [Table(Name = "dbo.[Order]")]
//    public partial class Order 
//    {
        
//        private int _id_order;

//        private int _id_driver;

//        private int _id_car;

//        private int _id_client;

//        private string _point_of_departure;

//        private string _point_of_arrival;

//        private decimal _weight;

//        private decimal _width;

//        private decimal _height;

//        private string _type_cargo;

//        private DateTime _reg_date;

//        private decimal _cost;

//        private decimal _paid;

//        private EntitySet<Profit_driver> _Profit_driver;

//        private EntityRef<Car> _Car;

//        private EntityRef<Client> _Client;

//        private EntityRef<Driver> _Driver;
        

//        public Order()
//        {
//            this._Profit_driver = new EntitySet<Profit_driver>();
//            this._Car = default(EntityRef<Car>);
//            this._Client = default(EntityRef<Client>);
//            this._Driver = default(EntityRef<Driver>);
//        }

//        [Column(Storage = "_id_order", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
//        public int id_order
//        {
//            get
//            {
//                return this._id_order;
//            }
//            set
//            {
//                if ((this._id_order != value))
//                {
//                    this._id_order = value;
//                }
//            }
//        }

//        [Column(Storage = "_id_driver", DbType = "Int NOT NULL")]
//        public int id_driver
//        {
//            get
//            {
//                return this._id_driver;
//            }
//            set
//            {
//                if ((this._id_driver != value))
//                {
//                    if (this._Driver.HasLoadedOrAssignedValue)
//                    {
//                        throw new ForeignKeyReferenceAlreadyHasValueException();
//                    }
//                    this._id_driver = value;
//                }
//            }
//        }

//        [Column(Storage = "_id_car", DbType = "Int NOT NULL")]
//        public int id_car
//        {
//            get
//            {
//                return this._id_car;
//            }
//            set
//            {
//                if ((this._id_car != value))
//                {
//                    if (this._Car.HasLoadedOrAssignedValue)
//                    {
//                        throw new ForeignKeyReferenceAlreadyHasValueException();
//                    }
//                    this._id_car = value;
//                }
//            }
//        }

//        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_id_client", DbType = "Int NOT NULL")]
//        public int id_client
//        {
//            get
//            {
//                return this._id_client;
//            }
//            set
//            {
//                if ((this._id_client != value))
//                {
//                    if (this._Client.HasLoadedOrAssignedValue)
//                    {
//                        throw new ForeignKeyReferenceAlreadyHasValueException();
//                    }
//                    this._id_client = value;
//                }
//            }
//        }

//        [Column(Storage = "_point_of_departure", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
//        public string point_of_departure
//        {
//            get
//            {
//                return this._point_of_departure;
//            }
//            set
//            {
//                if ((this._point_of_departure != value))
//                {
//                    this._point_of_departure = value;
//                }
//            }
//        }

//        [Column(Storage = "_point_of_arrival", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
//        public string point_of_arrival
//        {
//            get
//            {
//                return this._point_of_arrival;
//            }
//            set
//            {
//                if ((this._point_of_arrival != value))
//                {
//                    this._point_of_arrival = value;
//                }
//            }
//        }

//        [Column(Storage = "_weight", DbType = "Decimal(10,2) NOT NULL")]
//        public decimal weight
//        {
//            get
//            {
//                return this._weight;
//            }
//            set
//            {
//                if ((this._weight != value))
//                {
//                    this._weight = value;
//                }
//            }
//        }

//        [Column(Storage = "_width", DbType = "Decimal(6,2) NOT NULL")]
//        public decimal width
//        {
//            get
//            {
//                return this._width;
//            }
//            set
//            {
//                if ((this._width != value))
//                {
//                    this._width = value;
//                }
//            }
//        }

//        [Column(Storage = "_height", DbType = "Decimal(6,2) NOT NULL")]
//        public decimal height
//        {
//            get
//            {
//                return this._height;
//            }
//            set
//            {
//                if ((this._height != value))
//                {
//                    this._height = value;
//                }
//            }
//        }

//        [Column(Storage = "_type_cargo", DbType = "VarChar(30) NOT NULL", CanBeNull = false)]
//        public string type_cargo
//        {
//            get
//            {
//                return this._type_cargo;
//            }
//            set
//            {
//                if ((this._type_cargo != value))
//                {
//                    this._type_cargo = value;
//                }
//            }
//        }

//        [Column(Storage = "_reg_date", DbType = "DateTime NOT NULL")]
//        public System.DateTime reg_date
//        {
//            get
//            {
//                return this._reg_date;
//            }
//            set
//            {
//                if ((this._reg_date != value))
//                {
//                    this._reg_date = value;
//                }
//            }
//        }

//        [Column(Storage = "_cost", DbType = "Decimal(10,2) NOT NULL")]
//        public decimal cost
//        {
//            get
//            {
//                return this._cost;
//            }
//            set
//            {
//                if ((this._cost != value))
//                {
//                    this._cost = value;
//                }
//            }
//        }

//        [Column(Storage = "_paid", DbType = "Decimal(10,2) NOT NULL")]
//        public decimal paid
//        {
//            get
//            {
//                return this._paid;
//            }
//            set
//            {
//                if ((this._paid != value))
//                {
//                    this._paid = value;
//                }
//            }
//        }

//        [Association(Name = "Order_Profit_driver", Storage = "_Profit_driver", ThisKey = "id_order", OtherKey = "id_order")]
//        public EntitySet<Profit_driver> Profit_driver
//        {
//            get
//            {
//                return this._Profit_driver;
//            }
//            set
//            {
//                this._Profit_driver.Assign(value);
//            }
//        }

//        [Association(Name = "Car_Order", Storage = "_Car", ThisKey = "id_car", OtherKey = "id_car", IsForeignKey = true, 
//            DeleteOnNull = true, DeleteRule = "CASCADE")]
//        public Car Car
//        {
//            get
//            {
//                return this._Car.Entity;
//            }
//            set
//            {
//                Car previousValue = this._Car.Entity;
//                if (((previousValue != value)
//                            || (this._Car.HasLoadedOrAssignedValue == false)))
//                {
//                    if ((previousValue != null))
//                    {
//                        this._Car.Entity = null;
//                        previousValue.Order.Remove(this);
//                    }
//                    this._Car.Entity = value;
//                    if ((value != null))
//                    {
//                        value.Order.Add(this);
//                        this._id_car = value.id_car;
//                    }
//                    else
//                    {
//                        this._id_car = default(int);
//                    }
//                }
//            }
//        }

//        [Association(Name = "Client_Order", Storage = "_Client", ThisKey = "id_client", OtherKey = "id_client", IsForeignKey = true,
//            DeleteOnNull = true, DeleteRule = "CASCADE")]
//        public Client Client
//        {
//            get
//            {
//                return this._Client.Entity;
//            }
//            set
//            {
//                Client previousValue = this._Client.Entity;
//                if (((previousValue != value)
//                            || (this._Client.HasLoadedOrAssignedValue == false)))
//                {
//                    if ((previousValue != null))
//                    {
//                        this._Client.Entity = null;
//                        previousValue.Order.Remove(this);
//                    }
//                    this._Client.Entity = value;
//                    if ((value != null))
//                    {
//                        value.Order.Add(this);
//                        this._id_client = value.id_client;
//                    }
//                    else
//                    {
//                        this._id_client = default(int);
//                    }
//                }
//            }
//        }

//        [Association(Name = "Driver_Order", Storage = "_Driver", ThisKey = "id_driver", OtherKey = "Id_driver", IsForeignKey = true, DeleteOnNull = true, DeleteRule = "CASCADE")]
//        public Driver Driver
//        {
//            get
//            {
//                return this._Driver.Entity;
//            }
//            set
//            {
//                Driver previousValue = this._Driver.Entity;
//                if (((previousValue != value)
//                            || (this._Driver.HasLoadedOrAssignedValue == false)))
//                {
//                    if ((previousValue != null))
//                    {
//                        this._Driver.Entity = null;
//                        previousValue.Order.Remove(this);
//                    }
//                    this._Driver.Entity = value;
//                    if ((value != null))
//                    {
//                        value.Order.Add(this);
//                        this._id_driver = value.id_driver;
//                    }
//                    else
//                    {
//                        this._id_driver = default(int);
//                    }
//                }
//            }
//        }
//    }
//}
