using Controller;
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

        int? id_driver;

        int? id_car;

        int id_client;

        string point_of_departure;

        string point_of_arrival;

        decimal weight;

        decimal width;

        decimal height;

        string status;

        DateTime reg_date;

        decimal cost;

        decimal paid;

        OrderDB orderdb;

        public bool exit = true;

        public FOrder(DBDataContext db)
        {
            InitializeComponent();
            this.db = db;
            orderdb = new OrderDB(db);
            showbd();
            if (Visitor.user.role != "client")
            {
                button1.Visible = false;
            }else
            {
                btnDelete.Visible = false;
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                f_red = new FRedactOrder();

                FillFields();

                Order order = new Order();

                orderdb.Insert(point_of_departure, point_of_arrival, weight, width, height);

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
                orderdb.Delete(id_order);
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
                
                id_driver = order.id_driver;
                 id_car = order.id_car;
                id_client = order.id_client;
                reg_date = Convert.ToDateTime(f_red.textBox10.Text);
                status = f_red.textBox9.Text;
                cost = Convert.ToDecimal(f_red.textBox11.Text);
                paid = Convert.ToDecimal(f_red.textBox12.Text);


                orderdb.Update(order.id_order, id_driver, id_car, id_client, point_of_departure,
                    point_of_arrival, weight, width, height, status, reg_date, cost, paid);

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
                if (Visitor.user.role == "client")
                {
                    foreach (var v in orderdb.Show(Visitor.client.id_client))
                    {
                        listBox1.Items.Add(v);
                    }
                }
                else
                {
                    foreach (var v in orderdb.Show())
                    {
                        listBox1.Items.Add(v);
                    }
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

            point_of_departure = f_red.textBox4.Text;

            point_of_arrival = f_red.textBox5.Text;

            weight = Convert.ToDecimal(f_red.textBox6.Text);

            width = Convert.ToDecimal(f_red.textBox7.Text);

            height = Convert.ToDecimal(f_red.textBox8.Text);
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            exit = false;
            Close();
        }
        
    }

}

