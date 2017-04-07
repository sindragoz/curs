using System;
using System.Windows.Forms;

namespace curs._1
{
    public partial class FCar : Form
    {
        DB db;

        FRedactCar f_red;

        int id_car;

        string number;

        string brand;

        decimal carrying_capacity;

        decimal width;

        decimal heigth;

        bool status = true;

       

        public FCar(DB db)
        {
            InitializeComponent();
            this.db = db;
            showbd();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try {

                f_red = new FRedactCar();

                Fill();

                db.AddCar(number, brand, carrying_capacity, width, heigth, status);

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

                Fill();

                db.UpdateCar(car.id_car, number, brand, carrying_capacity, width, heigth, status);

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
                var cars = db.ShowCar();
                foreach (var v in cars)
                {
                    listBox1.Items.Add(v);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        void Fill()
        {
            f_red.ShowDialog();

            number = f_red.textBox1.Text;

            brand = f_red.textBox2.Text;

            carrying_capacity = Convert.ToDecimal(f_red.textBox3.Text);

            width = Convert.ToDecimal(f_red.textBox4.Text);

            heigth = Convert.ToDecimal(f_red.textBox5.Text);

            status = f_red.checkBox1.Checked;
            
        }

    }
}
