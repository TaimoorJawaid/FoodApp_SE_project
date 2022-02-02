using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FoodApp
{
    public partial class MainScreen_Login : Form
    {
        public int check_login_signup = 0;
        public int allow = 1;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        

        private static extern IntPtr CreateRoundRectRgn
         (
              int nLeftRect,
              int nTopRect,
              int nRightRect,
              int nBottomRect,
              int nWidthEllipse,
                 int nHeightEllipse);
        public MainScreen_Login()
        {
            InitializeComponent();
           
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 64, 64));
            text_confirmpassword.Hide();
            panel_confirmpassword.Hide();
            this.ActiveControl = text_email;
            text_email.Focus();
            
        }

        string connstr = "Data Source=DESKTOP-KAQS2LI;Initial Catalog=FoodApp;Integrated Security=True";

        private void button_signOpt_Click(object sender, EventArgs e)
        {
            check_login_signup = 1;
            button_signOpt.BringToFront();
            panel2.BringToFront();
            panel3.BringToFront();
            button_loginOpt.ButtonColor = Color.FromArgb(252, 252, 252);
            button_loginOpt.TextColor = Color.Black;
            button_loginOpt.OnHoverTextColor = Color.DimGray;
            button_signOpt.ButtonColor = Color.Black;
            button_signOpt.TextColor = Color.FromArgb(252, 252, 252);
            button_signOpt.OnHoverButtonColor = Color.Black;
            button_signOpt.OnHoverTextColor = Color.FromArgb(252, 252, 252);
            button_loginOpt.OnHoverButtonColor = Color.FromArgb(252, 252, 252);
            button_login_signup.Text = "Sign Up";
            text_confirmpassword.Show();
            panel_confirmpassword.Show();
            button_forgetPassword.Hide();
        }

        private void button_loginOpt_Click(object sender, EventArgs e)
        {
            check_login_signup = 0;
            button_loginOpt.BringToFront();
            panel2.BringToFront();
            panel3.BringToFront();
            button_signOpt.ButtonColor = Color.FromArgb(252, 252, 252);
            button_signOpt.TextColor = Color.Black;
            button_signOpt.OnHoverTextColor = Color.DimGray;
            button_loginOpt.ButtonColor = Color.Black;
            button_loginOpt.TextColor = Color.FromArgb(252, 252, 252);
            button_loginOpt.OnHoverButtonColor = Color.Black;
            button_loginOpt.OnHoverTextColor = Color.FromArgb(252, 252, 252);
            button_signOpt.OnHoverButtonColor = Color.FromArgb(252, 252, 252);
            button_login_signup.Text = "Login";
            text_confirmpassword.Hide();
            panel_confirmpassword.Hide();
            button_forgetPassword.Show();
        }


        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_login_signup_Click(object sender, EventArgs e)
        {
            
            allow = 1;
            string fromaddress = "annassamad20@gmail.com";
            string email = text_email.Text;
            string password = "Dell03121024479";

            

            try
            {
                StreamWriter streamWriter_email = new StreamWriter(Application.StartupPath + "\\EMAIL\\" + "email_id.txt");
                streamWriter_email.WriteLine(email);
                streamWriter_email.Close();

                if (check_login_signup == 1)
                {
                    
                    string user_password = text_password.Text;
                    string confirm_password = text_confirmpassword.Text;

                    string query2 = "select * from CREDENTIALS where Email = '" + email + "'";
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query2, connstr);

                    DataTable table = new DataTable();
                    sqlDataAdapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        MessageBox.Show("This email has already been registered");
                        allow = 0;
                    }

                    else if (user_password == confirm_password & allow == 1)
                    {
                        
                        try
                        {
                            MailMessage mail = new MailMessage();
                            mail.Subject = "Food Vault";
                            mail.From = new MailAddress(fromaddress);
                            mail.Body = "Successful Sign Up\nWelcome to the Food Vault App";
                            mail.To.Add(new MailAddress(email));

                            SmtpClient smtp = new SmtpClient();
                            smtp.Host = "smtp.gmail.com";
                            smtp.Port = 587;
                            smtp.UseDefaultCredentials = false;
                            smtp.EnableSsl = true;

                            NetworkCredential nec = new NetworkCredential(fromaddress, password);
                            smtp.Credentials = nec;
                            smtp.Send(mail);
                        }
                        catch
                        {
                            MessageBox.Show("Please enter valid Google account Email Address");
                            allow = 0;
                        }

                        if (allow == 1)
                        {
                            try
                            {
                                SqlConnection SqlConnection1 = new SqlConnection(connstr);
                                SqlConnection1.Open();

                                string query1 = "insert into CREDENTIALS(Email,Password)values('" + email + "','" + user_password + "' )";

                                SqlCommand SqlCommand1 = new SqlCommand();
                                SqlCommand1.Connection = SqlConnection1;
                                SqlCommand1.CommandText = query1;
                                int x = SqlCommand1.ExecuteNonQuery();
                                SqlConnection1.Close();

                                MessageBox.Show("Welcome to THE FOOD VAULT");



                                FirstView Form = new FirstView();
                                Form.Show();
                                this.Hide();
                            }
                            catch
                            {
                                MessageBox.Show("Please enter a valid password");
                            }
                        }
                       

                        
                    }
                    else
                    {
                        MessageBox.Show("Please enter valid password");
                    }
                }
                if (check_login_signup == 0)
                {
                    
                    string user_password = text_password.Text;
                    SqlConnection SqlConnection2 = new SqlConnection(connstr);
                    SqlConnection2.Open();
                    try
                    {
                        string query2 = "select * from CREDENTIALS where Email = '" + email + "' and Password = '" + user_password + "'";
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query2, connstr);

                        DataTable table = new DataTable();
                        sqlDataAdapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            try
                            {
                                if (email == "annassamad20@gmail.com" && user_password == "Admin")
                                {
                                    MailMessage mail1 = new MailMessage();
                                    mail1.Subject = "Food Vault";
                                    mail1.From = new MailAddress(fromaddress);
                                    mail1.Body = "Welcome Admin";
                                    mail1.To.Add(new MailAddress(email));

                                    SmtpClient smtp1 = new SmtpClient();
                                    smtp1.Host = "smtp.gmail.com";
                                    smtp1.Port = 587;
                                    smtp1.UseDefaultCredentials = false;
                                    smtp1.EnableSsl = true;

                                    NetworkCredential nec1 = new NetworkCredential(fromaddress, password);
                                    smtp1.Credentials = nec1;
                                    smtp1.Send(mail1);

                                    MessageBox.Show("Welcome THE FOOD VAULT Admin");

                                    Admin Form1 = new Admin();
                                    Form1.Show();
                                    this.Hide();
                                }
                                else{
                                    MailMessage mail = new MailMessage();
                                    mail.Subject = "Food Vault";
                                    mail.From = new MailAddress(fromaddress);
                                    mail.Body = "Successful Login Up\nWelcome to the Food Vault App";
                                    mail.To.Add(new MailAddress(email));

                                    SmtpClient smtp = new SmtpClient();
                                    smtp.Host = "smtp.gmail.com";
                                    smtp.Port = 587;
                                    smtp.UseDefaultCredentials = false;
                                    smtp.EnableSsl = true;

                                    NetworkCredential nec = new NetworkCredential(fromaddress, password);
                                    smtp.Credentials = nec;
                                    smtp.Send(mail);

                                    MessageBox.Show("Welcome to THE FOOD VAULT");

                                    FirstView Form = new FirstView();
                                    Form.Show();
                                    this.Hide();
                                }
                                
                            }
                            catch
                            {
                                MessageBox.Show("No Internet connection\nTry connecting it later");
                                
                            }

                           

                            
                        }
                        else
                        {
                            MessageBox.Show("Please enter Valid Credentials");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Please enter Valid Credentials");
                    }
                    finally
                    {
                        SqlConnection2.Close();
                    }
                }
            

            }
            catch
            {
                MessageBox.Show("Please enter Valid Credentials");
            }
            

        }

        private void button_forgetPassword_Click(object sender, EventArgs e)
        {
            string fromaddress = "annassamad20@gmail.com";
            string email = text_email.Text;
            string password = "03013357055";
            string user_password;

            try
            {
                SqlConnection SqlConnection3 = new SqlConnection(connstr);
                SqlConnection3.Open();
                SqlCommand sqlCommand = new SqlCommand("select * from CREDENTIALS where Email = '" + email + "'", SqlConnection3);
                SqlDataReader reader;
                reader = sqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    user_password = reader["Password"].ToString();

                    MailMessage mail = new MailMessage();
                    mail.Subject = "Food Vault";
                    mail.From = new MailAddress(fromaddress);
                    mail.Body = "Recovery Email\nYour Password is: " + user_password;
                    mail.To.Add(new MailAddress(email));

                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.UseDefaultCredentials = false;
                    smtp.EnableSsl = true;

                    NetworkCredential nec = new NetworkCredential(fromaddress, password);
                    smtp.Credentials = nec;
                    smtp.Send(mail);
                    MessageBox.Show("Your password has been sent to your email");
                }
                else
                {
                    MessageBox.Show("Please enter correct Email Address");
                }

            }
            catch
            {
                MessageBox.Show("Please enter Valid Credentials");
            }
            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void text_email_KeyDown(object sender, KeyEventArgs e)
        {
            
            
                if (e.KeyCode == Keys.Enter)
                {
                    text_password.Focus();
                }
       
        }

        private void text_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (check_login_signup == 1)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    text_confirmpassword.Focus();
                }

            }
            if (check_login_signup ==0)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    button_login_signup.PerformClick();
                }
            }
        }

        private void text_confirmpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_login_signup.PerformClick();
            }
        }
    }
}
