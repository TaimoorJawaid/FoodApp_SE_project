using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodApp
{
    public partial class Cart : Form
    {
        public static Cart instance1;
        public Label label_DishName1;
        public Label label_Quantity1;
        public Label label_Price1;
        public Label label_DishName2;
        public Label label_Quantity2;
        public Label label_Price2;
        public Label label_DishName3;
        public Label label_Quantity3;
        public Label label_Price3;
        public Label label_DishName4;
        public Label label_Quantity4;
        public Label label_Price4;
        public int quantity;

        public Cart()
        {
            InitializeComponent();
            instance1 = this;
            label_DishName1 = Dish1;
            label_Quantity1 = Quantity1;
            label_Price1 = Price1;
            label_DishName2 = Dish2;
            label_Quantity2 = Quantity2;
            label_Price2 = Price2;
            label_DishName3 = Dish3;
            label_Quantity3 = Quantity3;
            label_Price3 = Price3;
            label_DishName4 = Dish4;
            label_Quantity4 = Quantity4;
            label_Price4 = Price4;

            

            try
            {
                if (Add_Cart.instance1.cart_check == 1)
                {
                    add_dish();
                }
            }
            finally
            {
                
            }
            
            

        }
        string connstr = "Data Source=DESKTOP-KAQS2LI;Initial Catalog=FoodApp;Integrated Security=True";
        private string quantity_str;
        public void add_dish()
        {
            StreamReader streamReader1 = new StreamReader(Application.StartupPath + "\\EMAIL\\" + "check.text");
            string check = streamReader1.ReadToEnd();
            streamReader1.Close();
            int check_upt;
            Int32.TryParse(check, out check_upt);

            if (check_upt==1)
            {

                Dish1.Text = Add_Cart.instance1.label_dish.Text;
                Quantity1.Text = Add_Cart.instance1.label_Quantity.Text;
                int Quantity;
                int final_price;
                Int32.TryParse(Quantity1.Text, out Quantity);
                string Price = Add_Cart.instance1.label_Price.Text;
                Int32.TryParse(Price, out final_price);
                final_price = Quantity * final_price;
                Price1.Text = final_price.ToString();
                Dish1.Show();
                Quantity1.Show();
                Price1.Show();
               
                int check_updated;
                Int32.TryParse(check, out check_updated);
                check_updated += 1;
                StreamWriter streamWriter = new StreamWriter(Application.StartupPath + "\\EMAIL\\" + "check.text");
                streamWriter.WriteLine(check_updated);
                streamWriter.Close();
                StreamWriter streamWriter1= new StreamWriter(Application.StartupPath + "\\EMAIL\\" + "Dish1.txt");
                streamWriter1.WriteLine(Dish1.Text);
                streamWriter1.Close();
                StreamWriter streamWriter2 = new StreamWriter(Application.StartupPath + "\\EMAIL\\" + "Quantity1.txt");
                streamWriter2.WriteLine(Quantity1.Text);
                streamWriter2.Close();
                StreamWriter streamWriter3 = new StreamWriter(Application.StartupPath + "\\EMAIL\\" + "Price1.txt");
                streamWriter3.WriteLine(Price1.Text);
                streamWriter3.Close();
            }
            else if (check_upt==2)
            {
                
                Dish2.Text = Add_Cart.instance1.label_dish.Text;
                Quantity2.Text = Add_Cart.instance1.label_Quantity.Text;
                int Quantity;
                int final_price;
                Int32.TryParse(Quantity2.Text, out Quantity);
                string Price = Add_Cart.instance1.label_Price.Text;
                Int32.TryParse(Price, out final_price);
                final_price = Quantity * final_price;
                Price2.Text = final_price.ToString();
                Dish2.Show();
                Quantity2.Show();
                Price2.Show();
           
                int check_updated;
                Int32.TryParse(check, out check_updated);
                check_updated += 1;
                StreamReader streamReader2 = new StreamReader(Application.StartupPath + "\\EMAIL\\" + "Dish1.txt");
                string dish1 = streamReader2.ReadToEnd();
                streamReader2.Close();
                StreamReader streamReader3 = new StreamReader(Application.StartupPath + "\\EMAIL\\" + "Quantity1.txt");
                string quan1 = streamReader3.ReadToEnd();
                streamReader3.Close();
                StreamReader streamReader4 = new StreamReader(Application.StartupPath + "\\EMAIL\\" + "Price1.txt");
                string price1read= streamReader4.ReadToEnd();
                streamReader4.Close();
                Dish1.Text = dish1;
                Quantity1.Text = quan1;
                Price1.Text = price1read;
                StreamWriter streamWriter = new StreamWriter(Application.StartupPath + "\\EMAIL\\" + "check.text");
                streamWriter.WriteLine(check_updated);
                streamWriter.Close();
                StreamWriter streamWriter1 = new StreamWriter(Application.StartupPath + "\\EMAIL\\" + "Dish2.txt");
                streamWriter1.WriteLine(Dish2.Text);
                streamWriter1.Close();
                StreamWriter streamWriter2 = new StreamWriter(Application.StartupPath + "\\EMAIL\\" + "Quantity2.txt");
                streamWriter2.WriteLine(Quantity2.Text);
                streamWriter2.Close();
                StreamWriter streamWriter3 = new StreamWriter(Application.StartupPath + "\\EMAIL\\" + "Price2.txt");
                streamWriter3.WriteLine(Price2.Text);
                streamWriter3.Close();
            }
            else if (check_upt == 3)
            {
                Dish3.Text = Add_Cart.instance1.label_dish.Text;
                Quantity3.Text = Add_Cart.instance1.label_Quantity.Text;
                int Quantity;
                int final_price;
                Int32.TryParse(Quantity2.Text, out Quantity);
                string Price = Add_Cart.instance1.label_Price.Text;
                Int32.TryParse(Price, out final_price);
                final_price = Quantity * final_price;
                Price3.Text = final_price.ToString();
                Dish3.Show();
                Quantity3.Show();
                Price3.Show();
     
                int check_updated;
                Int32.TryParse(check, out check_updated);
                check_updated += 1;
                StreamWriter streamWriter = new StreamWriter(Application.StartupPath + "\\EMAIL\\" + "check.text");
                streamWriter.WriteLine(check_updated);
                streamWriter.Close();

                StreamReader streamReader2 = new StreamReader(Application.StartupPath + "\\EMAIL\\" + "Dish1.txt");
                string dish1 = streamReader2.ReadToEnd();
                streamReader2.Close();
                StreamReader streamReader3 = new StreamReader(Application.StartupPath + "\\EMAIL\\" + "Quantity1.txt");
                string quan1 = streamReader3.ReadToEnd();
                streamReader3.Close();
                StreamReader streamReader4 = new StreamReader(Application.StartupPath + "\\EMAIL\\" + "Price1.txt");
                string price1read = streamReader4.ReadToEnd();
                streamReader4.Close();
                Dish1.Text = dish1;
                Quantity1.Text = quan1;
                Price1.Text = price1read;

                StreamReader streamReader5 = new StreamReader(Application.StartupPath + "\\EMAIL\\" + "Dish2.txt");
                string dish2 = streamReader5.ReadToEnd();
                streamReader5.Close();
                StreamReader streamReader6 = new StreamReader(Application.StartupPath + "\\EMAIL\\" + "Quantity2.txt");
                string quan2 = streamReader6.ReadToEnd();
                streamReader6.Close();
                StreamReader streamReader7 = new StreamReader(Application.StartupPath + "\\EMAIL\\" + "Price2.txt");
                string price2read = streamReader7.ReadToEnd();
                streamReader7.Close();
                Dish2.Text = dish2;
                Quantity2.Text = quan2;
                Price2.Text = price2read;

                StreamWriter streamWriter1 = new StreamWriter(Application.StartupPath + "\\EMAIL\\" + "Dish3.txt");
                streamWriter1.WriteLine(Dish3.Text);
                streamWriter1.Close();
                StreamWriter streamWriter2 = new StreamWriter(Application.StartupPath + "\\EMAIL\\" + "Quantity3.txt");
                streamWriter2.WriteLine(Quantity3.Text);
                streamWriter2.Close();
                StreamWriter streamWriter3 = new StreamWriter(Application.StartupPath + "\\EMAIL\\" + "Price3.txt");
                streamWriter3.WriteLine(Price3.Text);
                streamWriter3.Close();
            }
            else if (check_upt == 4)
            {
                Dish4.Text = Add_Cart.instance1.label_dish.Text;
                Quantity4.Text = Add_Cart.instance1.label_Quantity.Text;
                int Quantity;
                int final_price;
                Int32.TryParse(Quantity4.Text, out Quantity);
                string Price = Add_Cart.instance1.label_Price.Text;
                Int32.TryParse(Price, out final_price);
                final_price = Quantity * final_price;
                Price4.Text = final_price.ToString();
                Dish4.Show();
                Quantity4.Show();
                Price3.Show();
       
                int check_updated;
                Int32.TryParse(check, out check_updated);
                check_updated += 1;
                StreamWriter streamWriter = new StreamWriter(Application.StartupPath + "\\EMAIL\\" + "check.text");
                streamWriter.WriteLine(check_updated);
                streamWriter.Close();

                StreamReader streamReader2 = new StreamReader(Application.StartupPath + "\\EMAIL\\" + "Dish1.txt");
                string dish1 = streamReader2.ReadToEnd();
                streamReader2.Close();
                StreamReader streamReader3 = new StreamReader(Application.StartupPath + "\\EMAIL\\" + "Quantity1.txt");
                string quan1 = streamReader3.ReadToEnd();
                streamReader3.Close();
                StreamReader streamReader4 = new StreamReader(Application.StartupPath + "\\EMAIL\\" + "Price1.txt");
                string price1read = streamReader4.ReadToEnd();
                streamReader4.Close();
                Dish1.Text = dish1;
                Quantity1.Text = quan1;
                Price1.Text = price1read;

                StreamReader streamReader5 = new StreamReader(Application.StartupPath + "\\EMAIL\\" + "Dish2.txt");
                string dish2 = streamReader5.ReadToEnd();
                streamReader5.Close();
                StreamReader streamReader6 = new StreamReader(Application.StartupPath + "\\EMAIL\\" + "Quantity2.txt");
                string quan2 = streamReader6.ReadToEnd();
                streamReader6.Close();
                StreamReader streamReader7 = new StreamReader(Application.StartupPath + "\\EMAIL\\" + "Price2.txt");
                string price2read = streamReader7.ReadToEnd();
                streamReader7.Close();
                Dish2.Text = dish2;
                Quantity2.Text = quan2;
                Price2.Text = price2read;

                StreamReader streamReader8 = new StreamReader(Application.StartupPath + "\\EMAIL\\" + "Dish3.txt");
                string dish3 = streamReader8.ReadToEnd();
                streamReader8.Close();
                StreamReader streamReader9 = new StreamReader(Application.StartupPath + "\\EMAIL\\" + "Quantity3.txt");
                string quan3 = streamReader9.ReadToEnd();
                streamReader9.Close();
                StreamReader streamReader10 = new StreamReader(Application.StartupPath + "\\EMAIL\\" + "Price3.txt");
                string price3read = streamReader10.ReadToEnd();
                streamReader10.Close();
                Dish3.Text = dish3;
                Quantity3.Text = quan3;
                Price3.Text = price3read;

                StreamWriter streamWriter1 = new StreamWriter(Application.StartupPath + "\\EMAIL\\" + "Dish4.txt");
                streamWriter1.WriteLine(Dish4.Text);
                streamWriter1.Close();
                StreamWriter streamWriter2 = new StreamWriter(Application.StartupPath + "\\EMAIL\\" + "Quantity4.txt");
                streamWriter2.WriteLine(Quantity4.Text);
                streamWriter2.Close();
                StreamWriter streamWriter3 = new StreamWriter(Application.StartupPath + "\\EMAIL\\" + "Price4.txt");
                streamWriter3.WriteLine(Price4.Text);
                streamWriter3.Close();
            }

            int price1;
            int price2;
            int price3;
            int price4;
            Int32.TryParse(Price1.Text, out price1);
            Int32.TryParse(Price2.Text, out price2);
            Int32.TryParse(Price3.Text, out price3);
            Int32.TryParse(Price4.Text, out price4);
            int total = price1 + price2 + price3 + price4;
            total_price.Text = total.ToString();




        }

        private void button_placeorder_Click(object sender, EventArgs e)
        {
            string fromaddress = "annassamad20@gmail.com";
            
            string password = "Dell03121024479";
            StreamReader streamReader_email = new StreamReader(Application.StartupPath + "\\EMAIL\\" + "email_id.txt");
            string email = streamReader_email.ReadToEnd();
            streamReader_email.Close();

            MessageBox.Show("Your Order has been confirmed");
            MailMessage mail = new MailMessage();
            mail.Subject = "Food Vault";
            mail.From = new MailAddress(fromaddress);
            mail.Body = "Your Order has been Placed\n Total bill "+ total_price.Text;
            mail.To.Add(new MailAddress(email));

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            smtp.EnableSsl = true;

            NetworkCredential nec = new NetworkCredential(fromaddress, password);
            smtp.Credentials = nec;
            smtp.Send(mail);

            StreamWriter streamWriter = new StreamWriter(Application.StartupPath + "\\EMAIL\\" + "check.text");
            streamWriter.WriteLine("1");
            streamWriter.Close();

            if (Dish1.Text == "Rumble Burger")
            {
                string d1 = "Beef Patty";
                string d2 = "Burger Bun";
                string d3 = "Mushroom";
                string d4 = "Onion Ring";
                string d5 = "Lettuce";
                string d6 = "Vaults Secret Sauce";
                string d7 = "Cheese Sauce";
                int q1 = quantity_update(d1);
                int q2 = quantity_update(d2);
                int q3 = quantity_update(d3);
                int q4 = quantity_update(d4);
                int q5 = quantity_update(d5);
                int q6 = quantity_update(d6);
                int q7 = quantity_update(d7);

                int q;
               
                Int32.TryParse(Quantity1.Text, out q);
                q1 = q1 - q;
                q2 = q2 - q;
                q3 = q3 - q;
                q4 = q4 - q;
                q5 = q5 - q;
                q6 = q6 - q;
                q7 = q7 - q;

                quantity_final("7", d1, q1.ToString());
                quantity_final("2", d2, q2.ToString());
                quantity_final("3", d3, q3.ToString());
                quantity_final("8", d4, q4.ToString());
                quantity_final("4", d5, q5.ToString());
                quantity_final("9", d6, q6.ToString());
                quantity_final("5", d7, q7.ToString());
            }
        }
        public int quantity_update(string item)
        {
            
            SqlConnection SqlConnection = new SqlConnection(connstr);
            SqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("select * from STOCKS where Item_Name = '" + item + "'", SqlConnection);

            SqlDataReader reader;
            reader = sqlCommand.ExecuteReader();

            if (reader.Read())
            {

                quantity_str = reader["Item_Quantity"].ToString();
                Int32.TryParse(quantity_str, out quantity);
            }
            return quantity;

        }
        public void quantity_final(string ID, string Item, string Quantity)
        {
            SqlConnection SqlConnection1 = new SqlConnection(connstr);
            SqlConnection1.Open();

            string query1 = "update STOCKS set Item_ID = '" + ID + "', Item_Name = '" + Item + "',Item_Quantity = ' " + Quantity + "' where Item_ID = '" + ID + "'";

            SqlCommand SqlCommand1 = new SqlCommand();
            SqlCommand1.Connection = SqlConnection1;
            SqlCommand1.CommandText = query1;

            int x = SqlCommand1.ExecuteNonQuery();
            SqlConnection1.Close();
        }

        private void button_woc1_Click(object sender, EventArgs e)
        {
           
            StreamWriter streamWriter = new StreamWriter(Application.StartupPath + "\\EMAIL\\" + "check.text");
            streamWriter.WriteLine("1");
            streamWriter.Close();

            this.panel1.Controls.Clear();
            Cart Info_Move = new Cart { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Info_Move.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(Info_Move);
            Info_Move.Show();
        }
    }
    
}
