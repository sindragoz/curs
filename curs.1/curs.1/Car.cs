//using System.Data.Linq;
//using System.Data.Linq.Mapping;

//namespace curs._1
//{
//    [Table(Name = "dbo.Car")]
//    public partial class Car 
//    {
        
//        private int _id_car;

//        private string _number;

//        private string _brand;

//        private double _carrying_capacity;

//        private double _width;

//        private double _heigth;

//        private bool _status;

//        private EntitySet<Order> _Order;

//        public Car()
//        {
//            this._Order = new EntitySet<Order>();
//        }


//        [Column(Storage = "_id_car", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
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
//                    this._id_car = value;
//                }
//            }
//        }

//        [Column(Storage = "_number", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
//        public string number
//        {
//            get
//            {
//                return this._number;
//            }
//            set
//            {
//                if ((this._number != value))
//                {
//                    this._number = value;
//                }
//            }
//        }

//        [Column(Storage = "_brand", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
//        public string brand
//        {
//            get
//            {
//                return this._brand;
//            }
//            set
//            {
//                if ((this._brand != value))
//                {
//                    this._brand = value;
//                }
//            }
//        }

//        [Column(Storage = "_carrying_capacity", DbType = "Decimal(10,2) NOT NULL", CanBeNull = false)]
//        public double carrying_capacity
//        {
//            get
//            {
//                return this._carrying_capacity;
//            }
//            set
//            {
//                if ((this._carrying_capacity != value))
//                {
//                    this._carrying_capacity = value;
//                }
//            }
//        }

//        [Column(Storage = "_width", DbType = "Decimal(10,2) NOT NULL", CanBeNull = false)]
//        public double width
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

//        [Column(Storage = "_heigth", DbType = "Decimal(10,2) NOT NULL", CanBeNull = false)]
//        public double heigth
//        {
//            get
//            {
//                return this._heigth;
//            }
//            set
//            {
//                if ((this._heigth != value))
//                {
//                    this._heigth = value;
//                }
//            }
//        }

//        [Column(Storage = "_status", DbType = "Bit NOT NULL", CanBeNull = false)]
//        public bool status
//        {
//            get
//            {
//                return this._status;
//            }
//            set
//            {
//                if ((this._status != value))
//                {
//                    this._status = value;
//                }
//            }
//        }

//        [Association(Name = "Car_Order", Storage = "_Order", ThisKey = "id_car", OtherKey = "id_car")]
//        public EntitySet<Order> Order
//        {
//            get
//            {
//                return this._Order;
//            }
//            set
//            {
//                this._Order.Assign(value);
//            }
//        }

//        public override string ToString()
//        {
//            return number + "  ||  " + brand + "  ||  " + carrying_capacity + "  ||  " +
//              + width + "  ||  " + heigth + "  ||  " + status;
//        }
//    }
//}
