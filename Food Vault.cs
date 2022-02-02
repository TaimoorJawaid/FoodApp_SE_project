using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodApp
{
    
    public partial class FirstView : Form
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
        public FirstView()
        {
            InitializeComponent();
            
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 64, 64));

            this.panel1.Controls.Clear();
            MainPanel Info_Move = new MainPanel { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Info_Move.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(Info_Move);
            Info_Move.Show();


            StreamReader streamReader = new StreamReader(Application.StartupPath + "\\EMAIL\\" + "email_id.txt");
            string email = streamReader.ReadToEnd();
            streamReader.Close();

            label_email.Text = email;
            string checkEmail = label_email.Text;
            string connstr = "Data Source=DESKTOP-KAQS2LI;Initial Catalog=FoodApp;Integrated Security=True";

            SqlConnection SqlConnection3 = new SqlConnection(connstr);
            SqlConnection3.Open();
            SqlCommand sqlCommand = new SqlCommand("select * from USER_INFO where Email = '" + checkEmail + "'", SqlConnection3);
            SqlDataReader reader;
            reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                label_name.Text = reader["Name"].ToString();
                label_contactNo.Text = reader["Contact_Number"].ToString();
                text_address.Text = reader["Address"].ToString();
            }
            else
            {
   
            }

            string check_updated = "0";
            StreamWriter streamWriter = new StreamWriter(Application.StartupPath + "\\EMAIL\\" + "cart.txt");
            streamWriter.WriteLine(check_updated);
            streamWriter.Close();





        }
        

        private void button_exit_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter = new StreamWriter(Application.StartupPath + "\\EMAIL\\" + "check.text");
            streamWriter.WriteLine("1");
            streamWriter.Close();
            Application.Exit();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter = new StreamWriter(Application.StartupPath + "\\EMAIL\\" + "check.text");
            streamWriter.WriteLine("1");
            streamWriter.Close();

            MainScreen_Login Form = new MainScreen_Login();
            Form.Show();
            this.Hide();
          
        }

        private void button_updateInfo_Click(object sender, EventArgs e)
        {
            
            this.panel1.Controls.Clear();
            Update_Info Info_Move = new Update_Info { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Info_Move.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(Info_Move);
            Info_Move.Show();
            

            button_viewCart.Text = "RETURN TO RESTURANT";
            string check_updated = "1";
            StreamWriter streamWriter = new StreamWriter(Application.StartupPath + "\\EMAIL\\" + "cart.txt");
            streamWriter.WriteLine(check_updated);
            streamWriter.Close();
        }

        private void button_viewCart_Click(object sender, EventArgs e)
        {
            StreamReader streamReader1 = new StreamReader(Application.StartupPath + "\\EMAIL\\" + "cart.txt");
            string check = streamReader1.ReadToEnd();
            streamReader1.Close();
            int check_cart;
            Int32.TryParse(check, out check_cart);
            if (check_cart ==1)
            {
                this.panel1.Controls.Clear();
                MainPanel Info_Move = new MainPanel { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                Info_Move.FormBorderStyle = FormBorderStyle.None;
                this.panel1.Controls.Add(Info_Move);
                Info_Move.Show();
                button_viewCart.Text = "VIEW YOUR CART";
                string check_updated = "0";
                StreamWriter streamWriter = new StreamWriter(Application.StartupPath + "\\EMAIL\\" + "cart.txt");
                streamWriter.WriteLine(check_updated);
                streamWriter.Close();


                //string checkEmail = label_email.Text;
                //string connstr = "Data Source=DESKTOP-KAQS2LI;Initial Catalog=FoodApp;Integrated Security=True";
                //SqlConnection SqlConnection3 = new SqlConnection(connstr);
                //SqlConnection3.Open();
                //SqlCommand sqlCommand = new SqlCommand("select * from USER_INFO where Email = '" + checkEmail + "'", SqlConnection3);
                //SqlDataReader reader;
                //reader = sqlCommand.ExecuteReader();
                //if (reader.Read())
                //{
                //    label_name.Text = reader["Name"].ToString();
                //    label_contactNo.Text = reader["Contact_Number"].ToString();
                //    text_address.Text = reader["Address"].ToString();
                //}
                //else
                //{
                //
                //}
            }
            if (check_cart==0)
            {
                button_viewCart.Text = "BACK TO RESTURANT";
                this.panel1.Controls.Clear();
                Cart Info_Move = new Cart { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                Info_Move.FormBorderStyle = FormBorderStyle.None;
                this.panel1.Controls.Add(Info_Move);
                Info_Move.Show();
                string check_updated = "1";
                StreamWriter streamWriter = new StreamWriter(Application.StartupPath + "\\EMAIL\\" + "cart.txt");
                streamWriter.WriteLine(check_updated);
                streamWriter.Close();

            }
        }

        
    }
}
