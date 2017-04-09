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

        Visitor visitordb;
        public FEntry(DBDataContext db)
        {
            InitializeComponent();
            this.db = db;
            visitordb = new Visitor(db);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password  = textBox2.Text;

            visitordb.Log_in(login, password);

            Close();
        }

       
    }
}
