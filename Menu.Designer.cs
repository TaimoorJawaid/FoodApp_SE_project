
namespace FoodApp
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.label2 = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.button_back = new ePOSOne.btnProduct.Button_WOC();
            this.button_search = new System.Windows.Forms.Button();
            this.text_search = new System.Windows.Forms.TextBox();
            this.label_dish = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.button_add = new ePOSOne.btnProduct.Button_WOC();
            this.text_description = new System.Windows.Forms.TextBox();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(485, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 29);
            this.label2.TabIndex = 47;
            this.label2.Text = "Rs.";
            // 
            // panel_main
            // 
            this.panel_main.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_main.BackgroundImage")));
            this.panel_main.Controls.Add(this.button_back);
            this.panel_main.Controls.Add(this.button_search);
            this.panel_main.Controls.Add(this.text_search);
            this.panel_main.Controls.Add(this.label_dish);
            this.panel_main.Controls.Add(this.label_price);
            this.panel_main.Controls.Add(this.button_add);
            this.panel_main.Controls.Add(this.text_description);
            this.panel_main.Controls.Add(this.label2);
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(684, 374);
            this.panel_main.TabIndex = 46;
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.button_back.BorderColor = System.Drawing.Color.Black;
            this.button_back.ButtonColor = System.Drawing.Color.Black;
            this.button_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_back.FlatAppearance.BorderSize = 0;
            this.button_back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.button_back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_back.Location = new System.Drawing.Point(12, 73);
            this.button_back.Name = "button_back";
            this.button_back.OnHoverBorderColor = System.Drawing.Color.Black;
            this.button_back.OnHoverButtonColor = System.Drawing.Color.White;
            this.button_back.OnHoverTextColor = System.Drawing.Color.Black;
            this.button_back.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button_back.Size = new System.Drawing.Size(149, 30);
            this.button_back.TabIndex = 57;
            this.button_back.Text = "Back to Menu";
            this.button_back.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.button_back.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click_1);
            // 
            // button_search
            // 
            this.button_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_search.BackgroundImage")));
            this.button_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_search.FlatAppearance.BorderSize = 0;
            this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_search.Location = new System.Drawing.Point(607, 33);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(30, 30);
            this.button_search.TabIndex = 56;
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click_1);
            // 
            // text_search
            // 
            this.text_search.BackColor = System.Drawing.Color.White;
            this.text_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_search.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.text_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.text_search.Location = new System.Drawing.Point(30, 33);
            this.text_search.Name = "text_search";
            this.text_search.Size = new System.Drawing.Size(582, 23);
            this.text_search.TabIndex = 51;
            this.text_search.Text = "Search for your favourite food items";
            // 
            // label_dish
            // 
            this.label_dish.AutoSize = true;
            this.label_dish.BackColor = System.Drawing.Color.White;
            this.label_dish.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_dish.Location = new System.Drawing.Point(30, 115);
            this.label_dish.Name = "label_dish";
            this.label_dish.Size = new System.Drawing.Size(124, 34);
            this.label_dish.TabIndex = 55;
            this.label_dish.Text = "Dish Name";
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.BackColor = System.Drawing.Color.White;
            this.label_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_price.ForeColor = System.Drawing.Color.Red;
            this.label_price.Location = new System.Drawing.Point(535, 115);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(69, 29);
            this.label_price.TabIndex = 54;
            this.label_price.Text = "9999";
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.button_add.BorderColor = System.Drawing.Color.Black;
            this.button_add.ButtonColor = System.Drawing.Color.Black;
            this.button_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_add.FlatAppearance.BorderSize = 0;
            this.button_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.button_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_add.Location = new System.Drawing.Point(528, 181);
            this.button_add.Name = "button_add";
            this.button_add.OnHoverBorderColor = System.Drawing.Color.Black;
            this.button_add.OnHoverButtonColor = System.Drawing.Color.White;
            this.button_add.OnHoverTextColor = System.Drawing.Color.Black;
            this.button_add.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button_add.Size = new System.Drawing.Size(106, 30);
            this.button_add.TabIndex = 53;
            this.button_add.Text = "Add";
            this.button_add.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.button_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // text_description
            // 
            this.text_description.BackColor = System.Drawing.Color.White;
            this.text_description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_description.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.text_description.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.text_description.Location = new System.Drawing.Point(30, 153);
            this.text_description.Multiline = true;
            this.text_description.Name = "text_description";
            this.text_description.ReadOnly = true;
            this.text_description.Size = new System.Drawing.Size(492, 58);
            this.text_description.TabIndex = 49;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(684, 373);
            this.Controls.Add(this.panel_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Text = "Menu";
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.TextBox text_description;
        private ePOSOne.btnProduct.Button_WOC button_add;
        private System.Windows.Forms.Label label_dish;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.TextBox text_search;
        private System.Windows.Forms.Button button_search;
        private ePOSOne.btnProduct.Button_WOC button_back;
    }
}