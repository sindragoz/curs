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
    public partial class FRedactCar : Form
    {
        public FRedactCar()
        {
            InitializeComponent();
        }

        public FRedactCar(Car car)
        {
            InitializeComponent();
            textBox1.Text = car.number;
            textBox2.Text = car.brand;
            textBox3.Text = car.carrying_capacity.ToString();
            textBox4.Text = car.width.ToString();
            textBox5.Text = car.heigth.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close(); 
        }
    }
}
