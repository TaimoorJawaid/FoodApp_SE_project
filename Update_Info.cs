using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodApp
{
    public partial class Update_Info : Form
    {
        public Update_Info()
        {
            InitializeComponent();
            StreamReader streamReader_email = new StreamReader(Application.StartupPath + "\\EMAIL\\" + "email_id.txt");
            string email = streamReader_email.ReadToEnd();
            streamReader_email.Close();
            text_email.Text = email;
            this.ActiveControl = text_name;
            text_name.Focus();

        }
        string connstr = "Data Source=DESKTOP-KAQS2LI;Initial Catalog=FoodApp;Integrated Security=True";
        

        private void button_updateInfo_Click_1(object sender, EventArgs e)
        {
            try
            {
                string email = text_email.Text;
                string name = text_name.Text;
                string contact = textcontact.Text;
                string address = text_address.Text;

                SqlConnection SqlConnection1 = new SqlConnection(connstr);
                SqlConnection1.Open();

                string query1 = "delete from USER_INFO where Email = '" + email + "' ";
                SqlCommand SqlCommand1 = new SqlCommand();
                SqlCommand1.Connection = SqlConnection1;
                SqlCommand1.CommandText = query1;
                SqlCommand1.ExecuteNonQuery();
                SqlConnection1.Close();

                SqlConnection SqlConnection2 = new SqlConnection(connstr);
                SqlConnection2.Open();

                string query2 = "insert into USER_INFO(Email,Name,Contact_Number,Address)values('" + email + "', '" + name + "', '" + contact + "', '" + address + "')";

                SqlCommand SqlCommand2 = new SqlCommand();
                SqlCommand2.Connection = SqlConnection2;
                SqlCommand2.CommandText = query2;
                int y = SqlCommand2.ExecuteNonQuery();
                SqlConnection2.Close();

                MessageBox.Show("Information has been Updated");

            }
            catch
            {
                MessageBox.Show("Please enter Valid Information");
            }
            
            
            
        }

        private void text_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textcontact.Focus();
            }
        }

        private void textcontact_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_address.Focus();
            }

        }

        private void text_address_KeyDown(object sender, KeyEventArgs e)
        { if (e.KeyCode == Keys.Enter)
            {
                button_updateInfo.PerformClick();
            }
        }
    }
}
