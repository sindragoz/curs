using Model;
using System.Collections.Generic;
using System.Linq;

namespace Controller
{
    public class ClientDB
    {
        private DBDataContext db;
        
        public ClientDB(DBDataContext db)
        {
            this.db = db;
        }
        
        public void Insert(string full_name, string phone_number, string company,
          string login, string password)
        {
            Client client = new Client();
            client.full_name = full_name;
            client.phone_number = phone_number;
            client.company = company;
            client.login = login;
            client.password = password;
            db.Client.InsertOnSubmit(client);
            db.SubmitChanges();
        }


        public void Update(int id_client, string full_name, string phone_number, string company,
           string login, string password)
        {
            Client client = db.Client.Where(c => c.id_client == id_client).FirstOrDefault();
            client.full_name = full_name;
            client.phone_number = phone_number;
            client.company = company;
            client.login = login;
            client.password = password;
            db.SubmitChanges();
        }

        public void Delete(int id_client)
        {
            Client client = db.Client.Where(cl => cl.id_client == id_client).FirstOrDefault();
            db.Client.DeleteOnSubmit(client);
            db.SubmitChanges();
        }


        public List<Client> Show()
        {
            return db.Client.Where(c => c.id_client >= 0).ToList();
        }
    }
}
