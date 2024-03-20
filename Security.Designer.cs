namespace POS_Inventory_System
{
    partial class Security
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
        private void InitializeComponent( )
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtUserName = new MetroFramework.Controls.MetroTextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(73, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 435);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Panel logowania";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            // 
            // 
            // 
            this.txtPassword.CustomButton.BackColor = System.Drawing.Color.White;
            this.txtPassword.CustomButton.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(347, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.UseVisualStyleBackColor = false;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.DisplayIcon = true;
            this.txtPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Icon = global::POS_Inventory_System.Properties.Resources.key_24;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(57, 159);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PromptText = "Hasło";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(381, 35);
            this.txtPassword.Style = MetroFramework.MetroColorStyle.White;
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseCustomBackColor = true;
            this.txtPassword.UseCustomForeColor = true;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.UseStyleColors = true;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.WaterMark = "Hasło";
            this.txtPassword.WaterMarkColor = System.Drawing.Color.White;
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            // 
            // 
            // 
            this.txtUserName.CustomButton.BackColor = System.Drawing.Color.White;
            this.txtUserName.CustomButton.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.CustomButton.Image = null;
            this.txtUserName.CustomButton.Location = new System.Drawing.Point(347, 1);
            this.txtUserName.CustomButton.Name = "";
            this.txtUserName.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserName.CustomButton.TabIndex = 1;
            this.txtUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUserName.CustomButton.UseSelectable = true;
            this.txtUserName.CustomButton.UseVisualStyleBackColor = false;
            this.txtUserName.CustomButton.Visible = false;
            this.txtUserName.DisplayIcon = true;
            this.txtUserName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtUserName.ForeColor = System.Drawing.Color.White;
            this.txtUserName.Icon = global::POS_Inventory_System.Properties.Resources.user_2_24;
            this.txtUserName.Lines = new string[0];
            this.txtUserName.Location = new System.Drawing.Point(57, 70);
            this.txtUserName.MaxLength = 32767;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.PromptText = "Nazwa użytkownika";
            this.txtUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserName.SelectedText = "";
            this.txtUserName.SelectionLength = 0;
            this.txtUserName.SelectionStart = 0;
            this.txtUserName.ShortcutsEnabled = true;
            this.txtUserName.Size = new System.Drawing.Size(381, 35);
            this.txtUserName.Style = MetroFramework.MetroColorStyle.White;
            this.txtUserName.TabIndex = 1;
            this.txtUserName.UseCustomBackColor = true;
            this.txtUserName.UseCustomForeColor = true;
            this.txtUserName.UseSelectable = true;
            this.txtUserName.UseStyleColors = true;
            this.txtUserName.WaterMark = "Nazwa użytkownika";
            this.txtUserName.WaterMarkColor = System.Drawing.Color.White;
            this.txtUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatAppearance.BorderSize = 2;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(57, 295);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(381, 66);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Zaloguj";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(124, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 76);
            this.label1.TabIndex = 4;
            this.label1.Text = "POS Management System\r\n by Dariusz Salzburg";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(596, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(47, 35);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form_Security
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(642, 701);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_Security";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLogin;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private System.Windows.Forms.Label label1;
        public MetroFramework.Controls.MetroTextBox txtUserName;
        private System.Windows.Forms.Button btnExit;
    }
}