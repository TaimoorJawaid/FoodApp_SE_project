using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodApp
{
    public partial class MainPanel : Form
    {
        public static MainPanel instance;
        public TextBox Box;
        public Button button;
        public static int allow;
        
        public MainPanel()
        {
            InitializeComponent();
            instance = this;
            Box = textBox_search;
        }
        private void move_to_menu()
        {
            this.panel_main.Controls.Clear();
            Menu Menu_Move = new Menu { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Menu_Move.FormBorderStyle = FormBorderStyle.None;
            this.panel_main.Controls.Add(Menu_Move);
            Menu_Move.Show();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            allow = 0;
            move_to_menu();
        }

        private void button_rumbleburger_Click(object sender, EventArgs e)
        {
            allow = 1;
            button = button_rumbleburger;
            move_to_menu();
        }

        private void button_koreanfriedchicken_Click(object sender, EventArgs e)
        {
            allow = 1;
            button = button_koreanfriedchicken;
            move_to_menu();
        }

        private void button_pomodoropasta_Click(object sender, EventArgs e)
        {
            allow = 1;
            button = button_pomodoropasta;
            move_to_menu();
        }

        private void button_sicilianpizza_Click(object sender, EventArgs e)
        {
            allow = 1;
            button = button_sicilianpizza;
            move_to_menu();
        }

        private void button_chickenlasagna_Click(object sender, EventArgs e)
        {
            allow = 1;
            button = button_chickenlasagna;
            move_to_menu();
        }

        private void button_chickentandoori_Click(object sender, EventArgs e)
        {
            allow = 1;
            button = button_chickentandoori;
            move_to_menu();
        }

        private void button_margheritapizza_Click(object sender, EventArgs e)
        {
            allow = 1;
            button = button_margheritapizza;
            move_to_menu();
        }

        private void button_thaifish_Click(object sender, EventArgs e)
        {
            allow = 1;
            button = button_thaifish;
            move_to_menu();
        }

        private void button_chickenreshmikebab_Click(object sender, EventArgs e)
        {
            allow = 1;
            button = button_chickenreshmikebab;
            move_to_menu();
        }

        private void textBox_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_search.PerformClick();
            }
        }
    }
}
