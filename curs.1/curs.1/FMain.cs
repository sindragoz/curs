using System;
using System.Windows.Forms;

namespace curs._1
{
    public partial class FMain : Form
    {
        //  CursDataContext dc;
        DB d;
        public FMain()
        {
            InitializeComponent();
            //@"Data Source=DESKTOP-3U6D185\SQLEXPRESS;Initial Catalog=curs;Integrated Security=True;Pooling=False"
            // string connectionString = @"Data Source=\SQLEXPRESS;Initial Catalog=curs;Integrated Security=True";
            //string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;" +
            //   @"AttachDbFilename = |DataDirectory|\curs.mdf;" +
            //   @"Integrated Security = True; Connect Timeout = 30";
            //string connectionString = @"Data Source =.\SQLEXPRESS;" + 
            //    @"AttachDbFilename = |DataDirectory|\curs.mdf; Integrated Security = True";
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=curs;Integrated Security=True;Pooling=False";
            //   dc = new CursDataContext(connectionString);
            d = new DB(connectionString);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //FCar fc = new FCar(dc);
            //fc.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FClient fc = new FClient(d);
            fc.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //FDriver fd = new FDriver(dc);
            //fd.ShowDialog();
        }
    }
}
