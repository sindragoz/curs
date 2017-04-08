using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
   public  class Profit_driverDB
    {
        private DBDataContext db;

        public Profit_driverDB(DBDataContext db)
        {
            this.db = db;
        }

        public List<Profit_driver> Show()
        {
            return db.Profit_driver.Where(p => p.id_profit_driver >= 0).ToList();
        }
    }
}
