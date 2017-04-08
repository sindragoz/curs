using Model;
using Controller;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class FMain : Form
    {
       

        DBDataContext db;
        public FMain()
        {
            ConnectDB conDB = new ConnectDB();
            InitializeComponent();
            db = conDB.DB;


            //@"Data Source=DESKTOP-3U6D185\SQLEXPRESS;Initial Catalog=curs;Integrated Security=True;Pooling=False"
            // string connectionString = @"Data Source=\SQLEXPRESS;Initial Catalog=curs;Integrated Security=True";

            //string connectionString = @"Data Source =.\SQLEXPRESS;" + 
            //    @"AttachDbFilename = |DataDirectory|\curs.mdf; Integrated Security = True";
            //string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=curs;Integrated Security=True;Pooling=False";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FCar fc = new FCar(db);
            fc.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FClient fc = new FClient(db);
            fc.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FDriver fd = new FDriver(db);
            fd.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FOrder fd = new FOrder(db);
            fd.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FEntry fe = new FEntry();
            fe.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FProfit_driver fpd = new FProfit_driver(db);
            fpd.ShowDialog();
        }
    }
}
