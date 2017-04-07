using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curs._1
{
    [Table(Name = "dbo.Driver")]
    public partial class Driver 
    {
        private int _id_driver;

        private string _full_name;

        private string _phone_number;

        private DateTime _date_of_birth;

        private string _passport_number;

        private string _adress;

        private bool _status;

        private EntitySet<Order> _Order;


        public Driver()
        {
            this._Order = new EntitySet<Order>();

        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Id_driver", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
        public int id_driver
        {
            get
            {
                return this._id_driver;
            }
            set
            {
                if ((this._id_driver != value))
                {
                    this._id_driver = value;
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_full_name", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
        public string full_name
        {
            get
            {
                return this._full_name;
            }
            set
            {
                if ((this._full_name != value))
                {
                    this._full_name = value;
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_phone_number", DbType = "VarChar(15) NOT NULL", CanBeNull = false)]
        public string phone_number
        {
            get
            {
                return this._phone_number;
            }
            set
            {
                if ((this._phone_number != value))
                {
                    this._phone_number = value;
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_date_of_birth", DbType = "DateTime NOT NULL")]
        public System.DateTime date_of_birth
        {
            get
            {
                return this._date_of_birth;
            }
            set
            {
                if ((this._date_of_birth != value))
                {
                    this._date_of_birth = value;
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_passport_number", DbType = "VarChar(10) NOT NULL", CanBeNull = false)]
        public string passport_number
        {
            get
            {
                return this._passport_number;
            }
            set
            {
                if ((this._passport_number != value))
                {
                    this._passport_number = value;
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_adress", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
        public string adress
        {
            get
            {
                return this._adress;
            }
            set
            {
                if ((this._adress != value))
                {
                    this._adress = value;
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_status", DbType = "Bit NOT NULL")]
        public bool status
        {
            get
            {
                return this._status;
            }
            set
            {
                if ((this._status != value))
                {
                    this._status = value;
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Driver_Order", Storage = "_Order", ThisKey = "Id_driver", OtherKey = "id_driver")]
        public EntitySet<Order> Order
        {
            get
            {
                return this._Order;
            }
            set
            {
                this._Order.Assign(value);
            }
        }
    }
}
