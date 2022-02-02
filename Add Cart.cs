using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FoodApp
{
    public partial class Add_Cart : Form
    {
        public static Add_Cart instance1;
        public int quantity;
        public Label label_dish;
        public Label label_Quantity;
        public Label label_Price;
        public int cart_check = 0;

        
        public Add_Cart()
        {
            InitializeComponent();
            instance1 = this;
            label_dish = label_dish_name;
            label_Price = label_price;
            label_Quantity = label_quantity;
            
            label_dish_name.Text = Menu.instance.label_dishName.Text;
            label_price.Text = Menu.instance.label_dishPrice.Text;
            text_dish_description.Text = Menu.instance.text_dishDescription.Text;
        }
        string connstr = "Data Source=DESKTOP-KAQS2LI;Initial Catalog=FoodApp;Integrated Security=True";
        private string quantity_str;

        private void button1_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            MainPanel Info_Move = new MainPanel { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Info_Move.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(Info_Move);
            Info_Move.Show();
        }

        private int check_stock (string item)
        {
            SqlConnection SqlConnection = new SqlConnection(connstr);
            SqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("select * from STOCKS where Item_Name = '" +item+"'", SqlConnection);

            SqlDataReader reader;
            reader = sqlCommand.ExecuteReader();

            if (reader.Read())
            {
                
                quantity_str = reader["Item_Quantity"].ToString();
                Int32.TryParse(quantity_str, out quantity);
            }
            return quantity;
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            string dish_name = label_dish_name.Text;
            int check_quantity;
            Int32.TryParse(label_quantity.Text, out check_quantity);
            if (dish_name == "Rumble Burger")
            {
                string d1 = "Beef Patty";
                string d2 = "Burger Bun";
                string d3 = "Mushroom";
                string d4 = "Onion Ring";
                string d5 = "Lettuce";
                string d6 = "Vaults Secret Sauce";
                string d7 = "Cheese Sauce";
                int q1 = check_stock(d1);
                int q2 = check_stock(d2);
                int q3 = check_stock(d3);
                int q4 = check_stock(d4);
                int q5 = check_stock(d5);
                int q6 = check_stock(d6);
                int q7 = check_stock(d7);

                int highest = Math.Min(q1, Math.Min(Math.Min(Math.Min(Math.Min(Math.Min(q6, q7),q5),q4),q3),q2));
                //int highest = Math.Min(q1, Math.Min(q2, q3));
                if (check_quantity < highest)
                {
                    check_quantity += 1;
                    label_quantity.Text = check_quantity.ToString();

                    
                }
                else
                {
                    MessageBox.Show("Maximum Quantity that can be orderd: "+ highest);
                }
            }
            else if (dish_name == "Pomodoro Pasta")
            {
                string d1 = "Pasta";
                string d2 = "White Sauce";
                string d3 = "Lettuce";
                
                int q1 = check_stock(d1);
                int q2 = check_stock(d2);
                int q3 = check_stock(d3);
                

                int highest = Math.Min(q1, Math.Min(q3, q2));
                //int highest = Math.Min(q1, Math.Min(q2, q3));
                if (check_quantity < highest)
                {
                    check_quantity += 1;
                    label_quantity.Text = check_quantity.ToString();


                }
                else
                {
                    MessageBox.Show("Maximum Quantity that can be orderd: " + highest);
                }
            }

                

        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            int check_quantity;
            Int32.TryParse(label_quantity.Text, out check_quantity);
            if (check_quantity > 0)
            {
                check_quantity -= 1;
                label_quantity.Text = check_quantity.ToString();
            }
            else
            {
                
            }

        }

        private void button_cart_Click(object sender, EventArgs e)
        {
            if (label_quantity.Text == "0")
            {
                MessageBox.Show("Quantity must be greater then 0");
            }
            else
            {
                cart_check = 1;
                MessageBox.Show("Added to Cart");
            }
            
        }
    }
}
