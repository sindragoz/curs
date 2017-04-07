using System;
using System.Windows.Forms;

namespace curs._1
{
    public partial class FCar : Form
    {

        DBDataContext db;

        int id_car;

        string number;

        string brand;

        double carrying_capacity;

        double width;

        double heigth;

        bool status = true;

        FRedactCar f_red;

        public FCar(DBDataContext db)
        {
            InitializeComponent();
            this.db = db;
            showbd();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try {

                f_red = new FRedactCar();

                f_red.ShowDialog();

                 number = f_red.textBox1.Text;

                 brand = f_red.textBox2.Text;

                 carrying_capacity = Convert.ToInt32(f_red.textBox3.Text);

                 width = Convert.ToInt32(f_red.textBox4.Text);

                 heigth = Convert.ToInt32(f_red.textBox5.Text);

                //db.AddCar(number, brand, carrying_capacity, width, heigth, status);

                showbd();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                Car car = (listBox1.SelectedItem as Car);

                f_red = new FRedactCar(car);

                f_red.ShowDialog();
                //

                number = f_red.textBox1.Text;

                brand = f_red.textBox2.Text;

                carrying_capacity = Convert.ToInt32(f_red.textBox3.Text);

                width = Convert.ToInt32(f_red.textBox4.Text);

                heigth = Convert.ToInt32(f_red.textBox5.Text);

                //dc.UpdateCar(car.id_car, number, brand, carrying_capacity, width, heigth, status);

                showbd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                 id_car = (listBox1.SelectedItem as Car).id_car;
                //dc.DelCar(4);
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
                //var cars = dc.ShowCar();
                //foreach(var v in cars)
                //{
                //    listBox1.Items.Add(v);
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
