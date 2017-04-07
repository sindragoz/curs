﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace curs._1
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="curs")]
	public partial class DBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Определения метода расширяемости
    partial void OnCreated();
    partial void InsertCar(Car instance);
    partial void UpdateCar(Car instance);
    partial void DeleteCar(Car instance);
    partial void InsertClient(Client instance);
    partial void UpdateClient(Client instance);
    partial void DeleteClient(Client instance);
    partial void InsertDriver(Driver instance);
    partial void UpdateDriver(Driver instance);
    partial void DeleteDriver(Driver instance);
    partial void InsertOrder(Order instance);
    partial void UpdateOrder(Order instance);
    partial void DeleteOrder(Order instance);
    partial void InsertProfit_driver(Profit_driver instance);
    partial void UpdateProfit_driver(Profit_driver instance);
    partial void DeleteProfit_driver(Profit_driver instance);
    #endregion
		
		public DBDataContext() : 
				base(global::curs._1.Properties.Settings.Default.cursConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Car> Car
		{
			get
			{
				return this.GetTable<Car>();
			}
		}
		
		public System.Data.Linq.Table<Client> Client
		{
			get
			{
				return this.GetTable<Client>();
			}
		}
		
		public System.Data.Linq.Table<Driver> Driver
		{
			get
			{
				return this.GetTable<Driver>();
			}
		}
		
		public System.Data.Linq.Table<Order> Order
		{
			get
			{
				return this.GetTable<Order>();
			}
		}
		
		public System.Data.Linq.Table<Profit_driver> Profit_driver
		{
			get
			{
				return this.GetTable<Profit_driver>();
			}
		}


        public void AddClient(string full_name, string phone_number, string company)
        {
            Client client = new Client();
            client.full_name = full_name;
            client.phone_number = phone_number;
            client.company = company;
            Client.InsertOnSubmit(client);
            SubmitChanges();
        }

        public void UpdateClient(int id_client, string full_name, string phone_number, string company)
        {
            Client client = Client.Where(c => c.id_client == id_client).FirstOrDefault();
            client.full_name = full_name;
            client.phone_number = phone_number;
            client.company = company;
            SubmitChanges();
        }

        public void DelClient(int id_client)
        {
            Client client = Client.Where(cl => cl.id_client == id_client).FirstOrDefault();
            Client.DeleteOnSubmit(client);
            SubmitChanges();
        }

        public List<Client> ShowClient()
        {
            return Client.Where(c => c.id_client >= 0).ToList();
        }


        public void AddCar(string number, string brand, decimal carrying_capacity,
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

        public void DelCar(int id_car)
        {
            Car car = Car.Where(c => c.id_car == id_car).FirstOrDefault();
            Car.DeleteOnSubmit(car);
            SubmitChanges();
        }
        
        public List<Car> ShowCar()
        {
            return Car.Where(c => c.id_car >= 0).ToList();
        }
    }

    [global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Car")]
	public partial class Car : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_car;
		
		private string _number;
		
		private string _brand;
		
		private decimal _carrying_capacity;
		
		private decimal _width;
		
		private decimal _heigth;
		
		private bool _status;
		
		private EntitySet<Order> _Order;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_carChanging(int value);
    partial void Onid_carChanged();
    partial void OnnumberChanging(string value);
    partial void OnnumberChanged();
    partial void OnbrandChanging(string value);
    partial void OnbrandChanged();
    partial void Oncarrying_capacityChanging(decimal value);
    partial void Oncarrying_capacityChanged();
    partial void OnwidthChanging(decimal value);
    partial void OnwidthChanged();
    partial void OnheigthChanging(decimal value);
    partial void OnheigthChanged();
    partial void OnstatusChanging(bool value);
    partial void OnstatusChanged();
    #endregion
		
		public Car()
		{
			this._Order = new EntitySet<Order>(new Action<Order>(this.attach_Order), new Action<Order>(this.detach_Order));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_car", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_car
		{
			get
			{
				return this._id_car;
			}
			set
			{
				if ((this._id_car != value))
				{
					this.Onid_carChanging(value);
					this.SendPropertyChanging();
					this._id_car = value;
					this.SendPropertyChanged("id_car");
					this.Onid_carChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_number", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string number
		{
			get
			{
				return this._number;
			}
			set
			{
				if ((this._number != value))
				{
					this.OnnumberChanging(value);
					this.SendPropertyChanging();
					this._number = value;
					this.SendPropertyChanged("number");
					this.OnnumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_brand", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string brand
		{
			get
			{
				return this._brand;
			}
			set
			{
				if ((this._brand != value))
				{
					this.OnbrandChanging(value);
					this.SendPropertyChanging();
					this._brand = value;
					this.SendPropertyChanged("brand");
					this.OnbrandChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_carrying_capacity", DbType="Decimal(10,2) NOT NULL")]
		public decimal carrying_capacity
		{
			get
			{
				return this._carrying_capacity;
			}
			set
			{
				if ((this._carrying_capacity != value))
				{
					this.Oncarrying_capacityChanging(value);
					this.SendPropertyChanging();
					this._carrying_capacity = value;
					this.SendPropertyChanged("carrying_capacity");
					this.Oncarrying_capacityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_width", DbType="Decimal(10,2) NOT NULL")]
		public decimal width
		{
			get
			{
				return this._width;
			}
			set
			{
				if ((this._width != value))
				{
					this.OnwidthChanging(value);
					this.SendPropertyChanging();
					this._width = value;
					this.SendPropertyChanged("width");
					this.OnwidthChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_heigth", DbType="Decimal(10,2) NOT NULL")]
		public decimal heigth
		{
			get
			{
				return this._heigth;
			}
			set
			{
				if ((this._heigth != value))
				{
					this.OnheigthChanging(value);
					this.SendPropertyChanging();
					this._heigth = value;
					this.SendPropertyChanged("heigth");
					this.OnheigthChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="Bit NOT NULL")]
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
					this.OnstatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("status");
					this.OnstatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Car_Order", Storage="_Order", ThisKey="id_car", OtherKey="id_car")]
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
			entity.Car = this;
		}
		
		private void detach_Order(Order entity)
		{
			this.SendPropertyChanging();
			entity.Car = null;
		}

        public override string ToString()
        {
            return number + " || " + brand + " || " + carrying_capacity + " || " + width
                + " || " + heigth + " || " + status;
        }
    }
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Client")]
	public partial class Client : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_client;
		
		private string _full_name;
		
		private string _phone_number;
		
		private string _company;
		
		private EntitySet<Order> _Order;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_clientChanging(int value);
    partial void Onid_clientChanged();
    partial void Onfull_nameChanging(string value);
    partial void Onfull_nameChanged();
    partial void Onphone_numberChanging(string value);
    partial void Onphone_numberChanged();
    partial void OncompanyChanging(string value);
    partial void OncompanyChanged();
    #endregion
		
		public Client()
		{
			this._Order = new EntitySet<Order>(new Action<Order>(this.attach_Order), new Action<Order>(this.detach_Order));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_client", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_full_name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phone_number", DbType="VarChar(11) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_company", DbType="VarChar(30)")]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Client_Order", Storage="_Order", ThisKey="id_client", OtherKey="id_client")]
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
                return full_name + " || " + phone_number + " || " + company;
            }
            return full_name + " || " + phone_number;
        }
    }
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Driver")]
	public partial class Driver : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_driver;
		
		private string _full_name;
		
		private string _phone_number;
		
		private System.DateTime _date_of_birth;
		
		private string _passport_number;
		
		private string _adress;
		
		private bool _status;
		
		private EntitySet<Order> _Order;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_driverChanging(int value);
    partial void Onid_driverChanged();
    partial void Onfull_nameChanging(string value);
    partial void Onfull_nameChanged();
    partial void Onphone_numberChanging(string value);
    partial void Onphone_numberChanged();
    partial void Ondate_of_birthChanging(System.DateTime value);
    partial void Ondate_of_birthChanged();
    partial void Onpassport_numberChanging(string value);
    partial void Onpassport_numberChanged();
    partial void OnadressChanging(string value);
    partial void OnadressChanged();
    partial void OnstatusChanging(bool value);
    partial void OnstatusChanged();
    #endregion
		
		public Driver()
		{
			this._Order = new EntitySet<Order>(new Action<Order>(this.attach_Order), new Action<Order>(this.detach_Order));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_driver", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
					this.Onid_driverChanging(value);
					this.SendPropertyChanging();
					this._id_driver = value;
					this.SendPropertyChanged("id_driver");
					this.Onid_driverChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_full_name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phone_number", DbType="VarChar(15) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_date_of_birth", DbType="DateTime NOT NULL")]
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
					this.Ondate_of_birthChanging(value);
					this.SendPropertyChanging();
					this._date_of_birth = value;
					this.SendPropertyChanged("date_of_birth");
					this.Ondate_of_birthChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_passport_number", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
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
					this.Onpassport_numberChanging(value);
					this.SendPropertyChanging();
					this._passport_number = value;
					this.SendPropertyChanged("passport_number");
					this.Onpassport_numberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_adress", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
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
					this.OnadressChanging(value);
					this.SendPropertyChanging();
					this._adress = value;
					this.SendPropertyChanged("adress");
					this.OnadressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="Bit NOT NULL")]
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
					this.OnstatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("status");
					this.OnstatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Driver_Order", Storage="_Order", ThisKey="id_driver", OtherKey="id_driver")]
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
			entity.Driver = this;
		}
		
		private void detach_Order(Order entity)
		{
			this.SendPropertyChanging();
			entity.Driver = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[Order]")]
	public partial class Order : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_order;
		
		private int _id_driver;
		
		private int _id_car;
		
		private int _id_client;
		
		private string _point_of_departure;
		
		private string _point_of_arrival;
		
		private decimal _weight;
		
		private decimal _width;
		
		private decimal _height;
		
		private string _type_cargo;
		
		private System.DateTime _reg_date;
		
		private decimal _cost;
		
		private decimal _paid;
		
		private EntitySet<Profit_driver> _Profit_driver;
		
		private EntityRef<Car> _Car;
		
		private EntityRef<Client> _Client;
		
		private EntityRef<Driver> _Driver;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_orderChanging(int value);
    partial void Onid_orderChanged();
    partial void Onid_driverChanging(int value);
    partial void Onid_driverChanged();
    partial void Onid_carChanging(int value);
    partial void Onid_carChanged();
    partial void Onid_clientChanging(int value);
    partial void Onid_clientChanged();
    partial void Onpoint_of_departureChanging(string value);
    partial void Onpoint_of_departureChanged();
    partial void Onpoint_of_arrivalChanging(string value);
    partial void Onpoint_of_arrivalChanged();
    partial void OnweightChanging(decimal value);
    partial void OnweightChanged();
    partial void OnwidthChanging(decimal value);
    partial void OnwidthChanged();
    partial void OnheightChanging(decimal value);
    partial void OnheightChanged();
    partial void Ontype_cargoChanging(string value);
    partial void Ontype_cargoChanged();
    partial void Onreg_dateChanging(System.DateTime value);
    partial void Onreg_dateChanged();
    partial void OncostChanging(decimal value);
    partial void OncostChanged();
    partial void OnpaidChanging(decimal value);
    partial void OnpaidChanged();
    #endregion
		
		public Order()
		{
			this._Profit_driver = new EntitySet<Profit_driver>(new Action<Profit_driver>(this.attach_Profit_driver), new Action<Profit_driver>(this.detach_Profit_driver));
			this._Car = default(EntityRef<Car>);
			this._Client = default(EntityRef<Client>);
			this._Driver = default(EntityRef<Driver>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_order", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_order
		{
			get
			{
				return this._id_order;
			}
			set
			{
				if ((this._id_order != value))
				{
					this.Onid_orderChanging(value);
					this.SendPropertyChanging();
					this._id_order = value;
					this.SendPropertyChanged("id_order");
					this.Onid_orderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_driver", DbType="Int NOT NULL")]
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
					if (this._Driver.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_driverChanging(value);
					this.SendPropertyChanging();
					this._id_driver = value;
					this.SendPropertyChanged("id_driver");
					this.Onid_driverChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_car", DbType="Int NOT NULL")]
		public int id_car
		{
			get
			{
				return this._id_car;
			}
			set
			{
				if ((this._id_car != value))
				{
					if (this._Car.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_carChanging(value);
					this.SendPropertyChanging();
					this._id_car = value;
					this.SendPropertyChanged("id_car");
					this.Onid_carChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_client", DbType="Int NOT NULL")]
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
					if (this._Client.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_clientChanging(value);
					this.SendPropertyChanging();
					this._id_client = value;
					this.SendPropertyChanged("id_client");
					this.Onid_clientChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_point_of_departure", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string point_of_departure
		{
			get
			{
				return this._point_of_departure;
			}
			set
			{
				if ((this._point_of_departure != value))
				{
					this.Onpoint_of_departureChanging(value);
					this.SendPropertyChanging();
					this._point_of_departure = value;
					this.SendPropertyChanged("point_of_departure");
					this.Onpoint_of_departureChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_point_of_arrival", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string point_of_arrival
		{
			get
			{
				return this._point_of_arrival;
			}
			set
			{
				if ((this._point_of_arrival != value))
				{
					this.Onpoint_of_arrivalChanging(value);
					this.SendPropertyChanging();
					this._point_of_arrival = value;
					this.SendPropertyChanged("point_of_arrival");
					this.Onpoint_of_arrivalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_weight", DbType="Decimal(10,2) NOT NULL")]
		public decimal weight
		{
			get
			{
				return this._weight;
			}
			set
			{
				if ((this._weight != value))
				{
					this.OnweightChanging(value);
					this.SendPropertyChanging();
					this._weight = value;
					this.SendPropertyChanged("weight");
					this.OnweightChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_width", DbType="Decimal(6,2) NOT NULL")]
		public decimal width
		{
			get
			{
				return this._width;
			}
			set
			{
				if ((this._width != value))
				{
					this.OnwidthChanging(value);
					this.SendPropertyChanging();
					this._width = value;
					this.SendPropertyChanged("width");
					this.OnwidthChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_height", DbType="Decimal(6,2) NOT NULL")]
		public decimal height
		{
			get
			{
				return this._height;
			}
			set
			{
				if ((this._height != value))
				{
					this.OnheightChanging(value);
					this.SendPropertyChanging();
					this._height = value;
					this.SendPropertyChanged("height");
					this.OnheightChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_type_cargo", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string type_cargo
		{
			get
			{
				return this._type_cargo;
			}
			set
			{
				if ((this._type_cargo != value))
				{
					this.Ontype_cargoChanging(value);
					this.SendPropertyChanging();
					this._type_cargo = value;
					this.SendPropertyChanged("type_cargo");
					this.Ontype_cargoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_reg_date", DbType="DateTime NOT NULL")]
		public System.DateTime reg_date
		{
			get
			{
				return this._reg_date;
			}
			set
			{
				if ((this._reg_date != value))
				{
					this.Onreg_dateChanging(value);
					this.SendPropertyChanging();
					this._reg_date = value;
					this.SendPropertyChanged("reg_date");
					this.Onreg_dateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cost", DbType="Decimal(10,2) NOT NULL")]
		public decimal cost
		{
			get
			{
				return this._cost;
			}
			set
			{
				if ((this._cost != value))
				{
					this.OncostChanging(value);
					this.SendPropertyChanging();
					this._cost = value;
					this.SendPropertyChanged("cost");
					this.OncostChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_paid", DbType="Decimal(10,2) NOT NULL")]
		public decimal paid
		{
			get
			{
				return this._paid;
			}
			set
			{
				if ((this._paid != value))
				{
					this.OnpaidChanging(value);
					this.SendPropertyChanging();
					this._paid = value;
					this.SendPropertyChanged("paid");
					this.OnpaidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Order_Profit_driver", Storage="_Profit_driver", ThisKey="id_order", OtherKey="id_order")]
		public EntitySet<Profit_driver> Profit_driver
		{
			get
			{
				return this._Profit_driver;
			}
			set
			{
				this._Profit_driver.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Car_Order", Storage="_Car", ThisKey="id_car", OtherKey="id_car", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public Car Car
		{
			get
			{
				return this._Car.Entity;
			}
			set
			{
				Car previousValue = this._Car.Entity;
				if (((previousValue != value) 
							|| (this._Car.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Car.Entity = null;
						previousValue.Order.Remove(this);
					}
					this._Car.Entity = value;
					if ((value != null))
					{
						value.Order.Add(this);
						this._id_car = value.id_car;
					}
					else
					{
						this._id_car = default(int);
					}
					this.SendPropertyChanged("Car");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Client_Order", Storage="_Client", ThisKey="id_client", OtherKey="id_client", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public Client Client
		{
			get
			{
				return this._Client.Entity;
			}
			set
			{
				Client previousValue = this._Client.Entity;
				if (((previousValue != value) 
							|| (this._Client.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Client.Entity = null;
						previousValue.Order.Remove(this);
					}
					this._Client.Entity = value;
					if ((value != null))
					{
						value.Order.Add(this);
						this._id_client = value.id_client;
					}
					else
					{
						this._id_client = default(int);
					}
					this.SendPropertyChanged("Client");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Driver_Order", Storage="_Driver", ThisKey="id_driver", OtherKey="id_driver", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public Driver Driver
		{
			get
			{
				return this._Driver.Entity;
			}
			set
			{
				Driver previousValue = this._Driver.Entity;
				if (((previousValue != value) 
							|| (this._Driver.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Driver.Entity = null;
						previousValue.Order.Remove(this);
					}
					this._Driver.Entity = value;
					if ((value != null))
					{
						value.Order.Add(this);
						this._id_driver = value.id_driver;
					}
					else
					{
						this._id_driver = default(int);
					}
					this.SendPropertyChanged("Driver");
				}
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
		
		private void attach_Profit_driver(Profit_driver entity)
		{
			this.SendPropertyChanging();
			entity.Order = this;
		}
		
		private void detach_Profit_driver(Profit_driver entity)
		{
			this.SendPropertyChanging();
			entity.Order = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Profit_driver")]
	public partial class Profit_driver : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_profit_driver;
		
		private int _id_driver;
		
		private int _id_order;
		
		private System.DateTime _date;
		
		private int _value;
		
		private EntityRef<Order> _Order;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_profit_driverChanging(int value);
    partial void Onid_profit_driverChanged();
    partial void Onid_driverChanging(int value);
    partial void Onid_driverChanged();
    partial void Onid_orderChanging(int value);
    partial void Onid_orderChanged();
    partial void OndateChanging(System.DateTime value);
    partial void OndateChanged();
    partial void OnvalueChanging(int value);
    partial void OnvalueChanged();
    #endregion
		
		public Profit_driver()
		{
			this._Order = default(EntityRef<Order>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_profit_driver", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_profit_driver
		{
			get
			{
				return this._id_profit_driver;
			}
			set
			{
				if ((this._id_profit_driver != value))
				{
					this.Onid_profit_driverChanging(value);
					this.SendPropertyChanging();
					this._id_profit_driver = value;
					this.SendPropertyChanged("id_profit_driver");
					this.Onid_profit_driverChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_driver", DbType="Int NOT NULL")]
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
					this.Onid_driverChanging(value);
					this.SendPropertyChanging();
					this._id_driver = value;
					this.SendPropertyChanged("id_driver");
					this.Onid_driverChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_order", DbType="Int NOT NULL")]
		public int id_order
		{
			get
			{
				return this._id_order;
			}
			set
			{
				if ((this._id_order != value))
				{
					if (this._Order.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_orderChanging(value);
					this.SendPropertyChanging();
					this._id_order = value;
					this.SendPropertyChanged("id_order");
					this.Onid_orderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_date", DbType="DateTime NOT NULL")]
		public System.DateTime date
		{
			get
			{
				return this._date;
			}
			set
			{
				if ((this._date != value))
				{
					this.OndateChanging(value);
					this.SendPropertyChanging();
					this._date = value;
					this.SendPropertyChanged("date");
					this.OndateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_value", DbType="Int NOT NULL")]
		public int value
		{
			get
			{
				return this._value;
			}
			set
			{
				if ((this._value != value))
				{
					this.OnvalueChanging(value);
					this.SendPropertyChanging();
					this._value = value;
					this.SendPropertyChanged("value");
					this.OnvalueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Order_Profit_driver", Storage="_Order", ThisKey="id_order", OtherKey="id_order", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public Order Order
		{
			get
			{
				return this._Order.Entity;
			}
			set
			{
				Order previousValue = this._Order.Entity;
				if (((previousValue != value) 
							|| (this._Order.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Order.Entity = null;
						previousValue.Profit_driver.Remove(this);
					}
					this._Order.Entity = value;
					if ((value != null))
					{
						value.Profit_driver.Add(this);
						this._id_order = value.id_order;
					}
					else
					{
						this._id_order = default(int);
					}
					this.SendPropertyChanged("Order");
				}
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
	}
}
#pragma warning restore 1591
