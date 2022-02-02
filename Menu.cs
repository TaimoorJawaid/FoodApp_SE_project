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
    public partial class Menu : Form
    {
        public static Menu instance;
        public Label label_dishName;
        public Label label_dishPrice;
        public TextBox text_dishDescription;
        public Menu()
        {
            InitializeComponent();

            instance = this;
            label_dishName = label_dish;
            label_dishPrice = label_price;
            text_dishDescription = text_description;
            
            if (MainPanel.allow == 0)
            {
                check_menu(MainPanel.instance.Box.Text);
            }
            else
            {
                check_menu(MainPanel.instance.button.Text);
            }
            
            
        }


        private void check_menu(string menu)
        {
            string connstr = "Data Source=DESKTOP-KAQS2LI;Initial Catalog=FoodApp;Integrated Security=True";


            SqlConnection SqlConnection = new SqlConnection(connstr);
            SqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("select * from MENU where Dish = '" + menu + "'", SqlConnection);

            SqlDataReader reader;
            reader = sqlCommand.ExecuteReader();

            if (reader.Read())
            {

                label_dish.Text = reader["Dish"].ToString();
                label_price.Text = reader["Price"].ToString();
                text_description.Text = reader["Description"].ToString();
            }
            else
            {
                this.panel_main.Controls.Clear();
                Search_Error Search_Move = new Search_Error { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                Search_Move.FormBorderStyle = FormBorderStyle.None;
                this.panel_main.Controls.Add(Search_Move);
                Search_Move.Show();
            }
            SqlConnection.Close();
        }

        
        

        private void button_back_Click_1(object sender, EventArgs e)
        {
            this.panel_main.Controls.Clear();
            MainPanel Info_Move = new MainPanel { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Info_Move.FormBorderStyle = FormBorderStyle.None;
            this.panel_main.Controls.Add(Info_Move);
            Info_Move.Show();
            
        }

        private void button_search_Click_1(object sender, EventArgs e)
        {
            check_menu(text_search.Text);
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            this.panel_main.Controls.Clear();
            Add_Cart Info_Move = new Add_Cart { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Info_Move.FormBorderStyle = FormBorderStyle.None;
            this.panel_main.Controls.Add(Info_Move);
            Info_Move.Show();
        }
    }
}
