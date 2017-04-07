using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace curs._1
{
    public partial class FMain : Form
    {
        CursDataContext dc;
        public FMain()
        {
            InitializeComponent();
            string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;" +
               @"AttachDbFilename = C:\Users\Admin\Documents\Visual Studio 2015\Projects\cursovaia\name\curs.1\curs.1\curs.mdf;" + 
               @"Integrated Security = True; Connect Timeout = 30";
            dc= new CursDataContext(connectionString);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FCar fc = new FCar(dc);
            fc.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FClient fc = new FClient(dc);
            fc.ShowDialog();
        }
    }
}
