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
    public partial class FOrder : Form
    {
        DBDataContext db;

        FRedactOrder f_red;

        int id_order;

        int id_driver;

        int id_car;

        int id_client;

        string point_of_departure;

        string point_of_arrival;

        decimal weight;

        decimal width;

        decimal height;

        string type_cargo;

        DateTime reg_date;

        decimal cost;

        decimal paid;

        public FOrder(DBDataContext db)
        {
            InitializeComponent();
            this.db = db;
            showbd();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                f_red = new FRedactOrder();

                FillFields();

                db.InsertOrder(id_driver, id_car, id_client, point_of_departure,
                    point_of_arrival, weight, width, height, type_cargo, reg_date, cost, paid);

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
                id_order = (listBox1.SelectedItem as Order).id_order;
                db.DeleteOrder(id_order);
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
                Order order = (listBox1.SelectedItem as Order);

                f_red = new FRedactOrder(order);

                FillFields();

                db.UpdateOrder(order.id_order, id_driver, id_car, id_client, point_of_departure,
                    point_of_arrival, weight, width, height, type_cargo, reg_date, cost, paid);

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
                foreach (var v in db.ShowOrder())
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

            id_driver = Convert.ToInt32(f_red.textBox1.Text);

            id_car = Convert.ToInt32(f_red.textBox2.Text);

            id_client = Convert.ToInt32(f_red.textBox3.Text);

            point_of_departure = f_red.textBox4.Text;

            point_of_arrival = f_red.textBox5.Text;

            weight = Convert.ToDecimal(f_red.textBox6.Text);

            width = Convert.ToDecimal(f_red.textBox7.Text);

            height = Convert.ToDecimal(f_red.textBox8.Text);

            type_cargo = f_red.textBox9.Text;

            reg_date = Convert.ToDateTime(f_red.textBox10.Text);

            cost = Convert.ToInt32(f_red.textBox11.Text);

            paid = Convert.ToInt32(f_red.textBox12.Text);
        }
    }

}

