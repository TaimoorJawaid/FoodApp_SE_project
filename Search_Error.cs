using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FoodApp
{
    public partial class Search_Error : Form
    {
        public static Search_Error instance;

        public Search_Error()
        {
            InitializeComponent();

        }

       

        private void button_back_Click_1(object sender, EventArgs e)
        {
            this.panel_main.Controls.Clear();
            MainPanel Info_Move = new MainPanel { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Info_Move.FormBorderStyle = FormBorderStyle.None;
            this.panel_main.Controls.Add(Info_Move);
            Info_Move.Show();
        }
    }

    
}
