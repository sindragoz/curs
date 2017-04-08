using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
   public  class Visitor
    {

        private DBDataContext db;

        public Visitor(DBDataContext db)
        {
            this.db = db;
        }

     ///   role

        //public Client User
        //{
        //    get { return user; }
        //}

        //public void log_in(string login, string pass)
        //{
        //    Client client;
        //    client = db.Client.Where(c => (c.login == login && c.password == pass)).FirstOrDefault();
        //    if (client != null)
        //    {
        //        user = client;
        //    }
        //}
    }
}
