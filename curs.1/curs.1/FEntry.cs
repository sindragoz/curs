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

namespace View
{
    public partial class FEntry : Form
    {
        public FEntry()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (log_in() != null)
            {
               
                Program.client = log_in();
                MessageBox.Show(Program.client.login);
            }
            Close();
        }

        Client log_in()
        {
            string login = textBox1.Text;
            string pass = textBox2.Text;

            return FMain.db.Client.Where(c => (c.login == login && c.password == pass)).FirstOrDefault();
        }
    }
}
