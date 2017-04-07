//using System.Data.Linq;
//using System.Data.Linq.Mapping;

//namespace curs._1
//{

//    [Table(Name = "dbo.Client")]
//    public partial class Client 
//    {
        
//        private int _id_client;

//        private string _full_name;

//        private string _phone_number;

//        private string _company;

//        private EntitySet<Order> _Order;

//        public Client()
//        {
//            this._Order = new EntitySet<Order>();

//        }


//        [Column(Storage = "_id_client", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", 
//            IsPrimaryKey = true, IsDbGenerated = true)]
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
//                    _id_client = value;
//                }
//            }
//        }

//        [Column(Storage = "_full_name", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
//        public string full_name
//        {
//            get
//            {
//                return this._full_name;
//            }
//            set
//            {
//                if ((this._full_name != value))
//                {
//                    _full_name = value;
//                }
//            }
//        }

//        [Column(Storage = "_phone_number", DbType = "VarChar(11) NOT NULL", CanBeNull = false)]
//        public string phone_number
//        {
//            get
//            {
//                return this._phone_number;
//            }
//            set
//            {
//                if ((this._phone_number != value))
//                {
//                    _phone_number = value;
//                }
//            }
//        }

//        [Column(Storage = "_company", DbType = "VarChar(30)", CanBeNull = false)]
//        public string company
//        {
//            get
//            {
//                return this._company;
//            }
//            set
//            {
//                if ((this._company != value))
//                {
//                    _company = value;
//                }
//            }
//        }

//        [Association(Name = "Client_Order", Storage = "_Order", ThisKey = "id_client", OtherKey = "id_client")]
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
//            string strReturn = _full_name + " || " + phone_number + " || ";
//            if (company != null)
//            {
//                strReturn += company + " || ";
//            }
//            return strReturn;
//        }
//    }


//    //[Table(Name = "dbo.Client")]
//    //public partial class Client 
//    //{

//    //    private int _id_client;

//    //    private string _full_name;

//    //    private string _phone_number;

//    //    private string _company;

//    //    private EntitySet<Order> _Order;


//    //    public Client()
//    //    {
//    //        this._Order = new EntitySet<Order>();

//    //    }

//    //    [Column(Storage = "_id_client", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
//    //    public int id_client
//    //    {
//    //        get
//    //        {
//    //            return this._id_client;
//    //        }
//    //        set
//    //        {
//    //            if ((this._id_client != value))
//    //            {
//    //                this._id_client = value;
//    //            }
//    //        }
//    //    }

//    //    [Column(Storage = "_full_name", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
//    //    public string full_name
//    //    {
//    //        get
//    //        {
//    //            return this._full_name;
//    //        }
//    //        set
//    //        {
//    //            if ((this._full_name != value))
//    //            {
//    //                this._full_name = value;
//    //            }
//    //        }
//    //    }

//    //    [Column(Storage = "_phone_number", DbType = "VarChar(11) NOT NULL", CanBeNull = false)]
//    //    public string phone_number
//    //    {
//    //        get
//    //        {
//    //            return this._phone_number;
//    //        }
//    //        set
//    //        {
//    //            if ((this._phone_number != value))
//    //            {
//    //                this._phone_number = value;
//    //            }
//    //        }
//    //    }

//    //    [Column(Storage = "_company", DbType = "VarChar(30)", CanBeNull = true)]
//    //    public string company
//    //    {
//    //        get
//    //        {
//    //            return this._company;
//    //        }
//    //        set
//    //        {
//    //            if ((this._company != value))
//    //            {
//    //                this._company = value;
//    //            }
//    //        }
//    //    }

//    //    [Association(Name = "Client_Order", Storage = "_Order", ThisKey = "id_client", OtherKey = "id_client")]
//    //    public EntitySet<Order> Order
//    //    {
//    //        get
//    //        {
//    //            return this._Order;
//    //        }
//    //        set
//    //        {
//    //            this._Order.Assign(value);
//    //        }
//    //    }

//    //    public override string ToString()
//    //    {
//    //        string strReturn = _full_name + " || " + phone_number + " || ";
//    //        if (company != null)
//    //        {
//    //            strReturn += company + " || ";
//    //        }
//    //        return strReturn;
//    //    }

//    //}
//}
