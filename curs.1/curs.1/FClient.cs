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
    
    public partial class FClient : Form
    {
        CursDataContext dc;

        FRedactClient f_red;

         int id_client;

         string full_name;

         string phone_number;

         string company;

        public FClient(CursDataContext dc)
        {
            InitializeComponent();
            this.dc = dc;
            showbd();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                f_red = new FRedactClient();

                f_red.ShowDialog();

                full_name = f_red.textBox1.Text; 

                phone_number = f_red.textBox2.Text; 

                company = f_red.textBox3.Text; 

                dc.AddClient(full_name, phone_number, company);

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
                Client client = (listBox1.SelectedItem as Client);
                //id_client = (listBox1.SelectedItem as Client).id_client;
                dc.DelClient(client.id_client);
                showbd();
                   label1.Text = (listBox1.SelectedItem as Client).ToString();//id_client + " ";
                label1.Text = id_client + " ";
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
                f_red = new FRedactClient();

                Client client = (listBox1.SelectedItem as Client);

                f_red.ShowDialog();

                full_name = f_red.textBox1.Text;

                phone_number = f_red.textBox2.Text;

                company = f_red.textBox3.Text;

                dc.UpdateClient(client.id_client, full_name, phone_number, company);

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
                var clients = dc.ShowClient();
                foreach (var v in clients)
                {
                    listBox1.Items.Add(v);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
