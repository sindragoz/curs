using System;
using System.Data.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Controller;

namespace View
{
    public partial class FEntry : Form
    {
        private DBDataContext db;

        Visitor userdb;
        public FEntry(DBDataContext db)
        {
            InitializeComponent();
            this.db = db;
            userdb = new Visitor(db);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password  = textBox2.Text;
            //userdb.log_in(login, password);
            //if (userdb.User!=null)
            //{
            //    MessageBox.Show(userdb.User.login);
            //    Close();
            //}else
            //    MessageBox.Show("nope");
            
            
            
        }

       
    }
}
