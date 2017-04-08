using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.ComponentModel;
using System;

namespace Model
{
    [Table(Name = "dbo.Client")]
    public partial class Client : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _id_client;

        private string _full_name;

        private string _phone_number;

        private string _company;

        private string _login;

        private string _password;

        private EntitySet<Order> _Order;

        #region Определения метода расширяемости
        partial void OnLoaded();
        partial void OnValidate(ChangeAction action);
        partial void OnCreated();
        partial void Onid_clientChanging(int value);
        partial void Onid_clientChanged();
        partial void Onfull_nameChanging(string value);
        partial void Onfull_nameChanged();
        partial void Onphone_numberChanging(string value);
        partial void Onphone_numberChanged();
        partial void OncompanyChanging(string value);
        partial void OncompanyChanged();
        partial void OnloginChanging(string value);
        partial void OnloginChanged();
        partial void OnpasswordChanging(string value);
        partial void OnpasswordChanged();
        #endregion

        public Client()
        {
            this._Order = new EntitySet<Order>(new Action<Order>(this.attach_Order), new Action<Order>(this.detach_Order));
            OnCreated();
        }

        [Column(Storage = "_id_client", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
        public int id_client
        {
            get
            {
                return this._id_client;
            }
            set
            {
                if ((this._id_client != value))
                {
                    this.Onid_clientChanging(value);
                    this.SendPropertyChanging();
                    this._id_client = value;
                    this.SendPropertyChanged("id_client");
                    this.Onid_clientChanged();
                }
            }
        }

        [Column(Storage = "_full_name", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
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
                    this.Onfull_nameChanging(value);
                    this.SendPropertyChanging();
                    this._full_name = value;
                    this.SendPropertyChanged("full_name");
                    this.Onfull_nameChanged();
                }
            }
        }

        [Column(Storage = "_phone_number", DbType = "VarChar(11) NOT NULL", CanBeNull = false)]
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
                    this.Onphone_numberChanging(value);
                    this.SendPropertyChanging();
                    this._phone_number = value;
                    this.SendPropertyChanged("phone_number");
                    this.Onphone_numberChanged();
                }
            }
        }

        [Column(Storage = "_company", DbType = "VarChar(30)")]
        public string company
        {
            get
            {
                return this._company;
            }
            set
            {
                if ((this._company != value))
                {
                    this.OncompanyChanging(value);
                    this.SendPropertyChanging();
                    this._company = value;
                    this.SendPropertyChanged("company");
                    this.OncompanyChanged();
                }
            }
        }

        [Column(Storage = "_login", DbType = "VarChar(30) NOT NULL", CanBeNull = false)]
        public string login
        {
            get
            {
                return this._login;
            }
            set
            {
                if ((this._login != value))
                {
                    this.OnloginChanging(value);
                    this.SendPropertyChanging();
                    this._login = value;
                    this.SendPropertyChanged("login");
                    this.OnloginChanged();
                }
            }
        }

        [Column(Storage = "_password", DbType = "VarChar(16) NOT NULL", CanBeNull = false)]
        public string password
        {
            get
            {
                return this._password;
            }
            set
            {
                if ((this._password != value))
                {
                    this.OnpasswordChanging(value);
                    this.SendPropertyChanging();
                    this._password = value;
                    this.SendPropertyChanged("password");
                    this.OnpasswordChanged();
                }
            }
        }

        [Association(Name = "Client_Order", Storage = "_Order", ThisKey = "id_client", OtherKey = "id_client")]
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

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void attach_Order(Order entity)
        {
            this.SendPropertyChanging();
            entity.Client = this;
        }

        private void detach_Order(Order entity)
        {
            this.SendPropertyChanging();
            entity.Client = null;
        }

        public override string ToString()
        {
            if (company != null)
            {
                return full_name + " || " + phone_number + " || " + company + " || " + login;
            }
            return full_name + " || " + phone_number + " || " + login;
        }
    }

}
