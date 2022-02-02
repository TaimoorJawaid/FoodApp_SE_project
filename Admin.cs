using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FoodApp
{
    public partial class Admin : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
         (
              int nLeftRect,
              int nTopRect,
              int nRightRect,
              int nBottomRect,
              int nWidthEllipse,
                 int nHeightEllipse);
        public Admin()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 64, 64));
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from STOCKS", connstr);
            DataTable table = new DataTable();
            sqlDataAdapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        string connstr = "Data Source=DESKTOP-KAQS2LI;Initial Catalog=FoodApp;Integrated Security=True";

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            MainScreen_Login Form = new MainScreen_Login();
            Form.Show();
            this.Hide();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        

        private void button_update_Click(object sender, EventArgs e)
        {
            string ID = text_ID.Text;
            string Item = text_Name.Text;
            string Quantity = text_Quantity.Text;

            SqlConnection SqlConnection1 = new SqlConnection(connstr);
            SqlConnection1.Open();

            string query1 = "update STOCKS set Item_ID = '"+ID+"', Item_Name = '" + Item + "',Item_Quantity = ' " + Quantity + "' where Item_ID = '" + ID + "'";

            SqlCommand SqlCommand1 = new SqlCommand();
            SqlCommand1.Connection = SqlConnection1;
            SqlCommand1.CommandText = query1;

            int x = SqlCommand1.ExecuteNonQuery();
            if (x > 0)
            {

                MessageBox.Show("INFORMATION HAS BEEN UPDATED");

                SqlDataAdapter SqlDataAdapter = new SqlDataAdapter("select * from STOCKS", connstr);
                DataTable table = new DataTable();
                SqlDataAdapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            else
            {
                MessageBox.Show("PLEASE ENTER CORRECT INFORMATION");
                return;
            }

            SqlConnection1.Close();
        }
    }
}
