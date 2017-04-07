using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace curs._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //    "Data Source = DESKTOP - 3U6D185\SQLEXPRESS; Initial Catalog = curs0; Integrated Security = True; Pooling = False";
            string connectionString = @"Data Source = .\SQLEXPRESS; Initial Catalog = curs0; Integrated Security = True; Pooling = False";
            DataClasses1DataContext mdb = new DataClasses1DataContext(connectionString);
            var v = mdb.Zapros(0);
            foreach (var vv in v)
            {
                textBox1.Text += vv + "\r\n";
            }
        }
    }
}
