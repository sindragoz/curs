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
        
        partial void OnCreated();


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

    }

}
