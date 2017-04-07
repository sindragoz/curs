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
    public partial class FDriver : Form
    {
        int id_driver;
        //CursDataContext dc;
        //public FDriver(CursDataContext dc)
        //{
        //    InitializeComponent();
        //    this.dc = dc;
        //    showbd();
        //}

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                id_driver = (listBox1.SelectedItem as Driver).id_driver;
                label1.Text = id_driver + " ";
                //dc.DelCar(id_driver);
                showbd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void showbd()
        {
            try
            {
                listBox1.Items.Clear();
                //var drivers = dc.ShowDriver();
                //foreach (var v in drivers)
                //{
                //    listBox1.Items.Add(v);
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
