using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ConnectDB
    {
        string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;" +
                     @"AttachDbFilename = |DataDirectory|\curs.mdf;" +
                     @"Integrated Security = True; Connect Timeout = 30";
        public DBDataContext DB { get { return new DBDataContext(connectionString); }  }
        
    }
}
