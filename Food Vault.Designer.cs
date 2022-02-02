
namespace FoodApp
{
    partial class FirstView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstView));
            this.panel_personalInfo = new System.Windows.Forms.Panel();
            this.text_address = new System.Windows.Forms.TextBox();
            this.button_logout = new ePOSOne.btnProduct.Button_WOC();
            this.label_contactNo = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.button_updateInfo = new System.Windows.Forms.Button();
            this.label_name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_banner = new System.Windows.Forms.Panel();
            this.button_exit = new ePOSOne.btnProduct.Button_WOC();
            this.button_viewCart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_personalInfo.SuspendLayout();
            this.panel_banner.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_personalInfo
            // 
            this.panel_personalInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_personalInfo.BackgroundImage")));
            this.panel_personalInfo.Controls.Add(this.text_address);
            this.panel_personalInfo.Controls.Add(this.button_logout);
            this.panel_personalInfo.Controls.Add(this.label_contactNo);
            this.panel_personalInfo.Controls.Add(this.label_email);
            this.panel_personalInfo.Controls.Add(this.button_updateInfo);
            this.panel_personalInfo.Controls.Add(this.label_name);
            this.panel_personalInfo.Controls.Add(this.label3);
            this.panel_personalInfo.Controls.Add(this.label2);
            this.panel_personalInfo.Location = new System.Drawing.Point(0, 0);
            this.panel_personalInfo.Name = "panel_personalInfo";
            this.panel_personalInfo.Size = new System.Drawing.Size(267, 575);
            this.panel_personalInfo.TabIndex = 0;
            // 
            // text_address
            // 
            this.text_address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.text_address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_address.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.text_address.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.text_address.ForeColor = System.Drawing.Color.White;
            this.text_address.Location = new System.Drawing.Point(2, 273);
            this.text_address.Multiline = true;
            this.text_address.Name = "text_address";
            this.text_address.ReadOnly = true;
            this.text_address.Size = new System.Drawing.Size(258, 65);
            this.text_address.TabIndex = 28;
            this.text_address.Text = "Address";
            // 
            // button_logout
            // 
            this.button_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.button_logout.BorderColor = System.Drawing.Color.White;
            this.button_logout.ButtonColor = System.Drawing.Color.White;
            this.button_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_logout.FlatAppearance.BorderSize = 0;
            this.button_logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.button_logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.button_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_logout.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_logout.Location = new System.Drawing.Point(41, 428);
            this.button_logout.Name = "button_logout";
            this.button_logout.OnHoverBorderColor = System.Drawing.Color.Black;
            this.button_logout.OnHoverButtonColor = System.Drawing.Color.White;
            this.button_logout.OnHoverTextColor = System.Drawing.Color.Black;
            this.button_logout.Size = new System.Drawing.Size(172, 51);
            this.button_logout.TabIndex = 27;
            this.button_logout.Text = "Logout";
            this.button_logout.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.button_logout.UseVisualStyleBackColor = false;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // label_contactNo
            // 
            this.label_contactNo.AutoSize = true;
            this.label_contactNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.label_contactNo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_contactNo.ForeColor = System.Drawing.Color.White;
            this.label_contactNo.Location = new System.Drawing.Point(2, 236);
            this.label_contactNo.Name = "label_contactNo";
            this.label_contactNo.Size = new System.Drawing.Size(155, 25);
            this.label_contactNo.TabIndex = 22;
            this.label_contactNo.Text = "Contact Number";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.label_email.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_email.ForeColor = System.Drawing.Color.White;
            this.label_email.Location = new System.Drawing.Point(2, 199);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(129, 25);
            this.label_email.TabIndex = 21;
            this.label_email.Text = "Email address";
            // 
            // button_updateInfo
            // 
            this.button_updateInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.button_updateInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_updateInfo.BackgroundImage")));
            this.button_updateInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_updateInfo.FlatAppearance.BorderSize = 0;
            this.button_updateInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_updateInfo.Location = new System.Drawing.Point(155, 156);
            this.button_updateInfo.Name = "button_updateInfo";
            this.button_updateInfo.Size = new System.Drawing.Size(30, 27);
            this.button_updateInfo.TabIndex = 1;
            this.button_updateInfo.UseVisualStyleBackColor = false;
            this.button_updateInfo.Click += new System.EventHandler(this.button_updateInfo_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.label_name.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_name.ForeColor = System.Drawing.Color.White;
            this.label_name.Location = new System.Drawing.Point(84, 157);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(64, 25);
            this.label_name.TabIndex = 20;
            this.label_name.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.label3.Font = new System.Drawing.Font("Doppio One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(70, 530);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "instagram.com/foodvault";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.label2.Font = new System.Drawing.Font("Doppio One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(70, 493);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "facebook.com/foodvault";
            // 
            // panel_banner
            // 
            this.panel_banner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_banner.BackgroundImage")));
            this.panel_banner.Controls.Add(this.button_exit);
            this.panel_banner.Location = new System.Drawing.Point(267, 0);
            this.panel_banner.Name = "panel_banner";
            this.panel_banner.Size = new System.Drawing.Size(684, 161);
            this.panel_banner.TabIndex = 1;
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.Black;
            this.button_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_exit.BackgroundImage")));
            this.button_exit.BorderColor = System.Drawing.Color.Black;
            this.button_exit.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.button_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_exit.FlatAppearance.BorderSize = 0;
            this.button_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_exit.Location = new System.Drawing.Point(631, 6);
            this.button_exit.Name = "button_exit";
            this.button_exit.OnHoverBorderColor = System.Drawing.Color.Red;
            this.button_exit.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.button_exit.OnHoverTextColor = System.Drawing.Color.Red;
            this.button_exit.Size = new System.Drawing.Size(38, 33);
            this.button_exit.TabIndex = 28;
            this.button_exit.Text = "X";
            this.button_exit.TextColor = System.Drawing.Color.Black;
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_viewCart
            // 
            this.button_viewCart.BackColor = System.Drawing.Color.Black;
            this.button_viewCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_viewCart.FlatAppearance.BorderSize = 0;
            this.button_viewCart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button_viewCart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button_viewCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_viewCart.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_viewCart.ForeColor = System.Drawing.Color.White;
            this.button_viewCart.Location = new System.Drawing.Point(267, 534);
            this.button_viewCart.Name = "button_viewCart";
            this.button_viewCart.Size = new System.Drawing.Size(684, 41);
            this.button_viewCart.TabIndex = 2;
            this.button_viewCart.Text = "VIEW YOUR CART";
            this.button_viewCart.UseVisualStyleBackColor = false;
            this.button_viewCart.Click += new System.EventHandler(this.button_viewCart_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(267, 161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 374);
            this.panel1.TabIndex = 3;
            // 
            // FirstView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(950, 575);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_viewCart);
            this.Controls.Add(this.panel_banner);
            this.Controls.Add(this.panel_personalInfo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FirstView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FirstView";
            this.panel_personalInfo.ResumeLayout(false);
            this.panel_personalInfo.PerformLayout();
            this.panel_banner.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_personalInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_contactNo;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Button button_updateInfo;
        private System.Windows.Forms.Label label_name;
        private ePOSOne.btnProduct.Button_WOC button_logout;
        private System.Windows.Forms.Panel panel_banner;
        private ePOSOne.btnProduct.Button_WOC button_exit;
        private System.Windows.Forms.Button button_viewCart;
        private System.Windows.Forms.TextBox text_address;
        private System.Windows.Forms.Panel panel1;
    }
}