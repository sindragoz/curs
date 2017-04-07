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
         DBDataContext db;

        FRedactDriver f_red;

        int id_driver;

        string full_name;

        string phone_number;

        DateTime date_of_birth;

        string passport_number;

        string adress;

        bool status;

       
        public FDriver(DBDataContext db)
        {
            InitializeComponent();
            this.db = db;
            showbd();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                f_red = new FRedactDriver();

                FillFields();

                 db.AddDriver(full_name, phone_number, date_of_birth, passport_number, adress, status);

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
                Driver driver = (listBox1.SelectedItem as Driver);

                f_red = new FRedactDriver(driver);

                FillFields();

                db.UpdateDriver(driver.id_driver, full_name, phone_number,
                    date_of_birth, passport_number, adress, status);

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
                id_driver = (listBox1.SelectedItem as Driver).id_driver;
                db.DelDriver(id_driver);
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
                foreach (var v in db.ShowDriver())
                {
                    listBox1.Items.Add(v);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void FillFields()
        {
            f_red.ShowDialog();

            full_name = f_red.textBox1.Text;

            phone_number = f_red.textBox2.Text;

            date_of_birth = Convert.ToDateTime(f_red.textBox3.Text);

            passport_number = f_red.textBox4.Text;

            adress = f_red.textBox5.Text;

            status = f_red.checkBox1.Checked;
        }

    }
}
