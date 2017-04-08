using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FRedactOrder : Form
    {


        public FRedactOrder()
        {
            InitializeComponent();
        }

        public FRedactOrder(Order order)
        {
            InitializeComponent();
            textBox1.Text = order.id_driver.ToString();
            textBox2.Text = order.id_car.ToString();
            textBox3.Text = order.id_client.ToString();
            textBox4.Text = order.point_of_departure;
            textBox5.Text = order.point_of_arrival;
            textBox6.Text = order.weight.ToString();
            textBox7.Text = order.width.ToString();
            textBox8.Text = order.height.ToString();
            textBox9.Text = order.type_cargo;
            textBox10.Text = order.reg_date.ToString();
            textBox11.Text = order.cost.ToString();
            textBox12.Text = order.paid.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
