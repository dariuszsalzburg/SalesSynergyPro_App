namespace POS_Inventory_System
{
    partial class Void
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVoid = new System.Windows.Forms.Button();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtUserName = new MetroFramework.Controls.MetroTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 35);
            this.panel1.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(327, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(47, 35);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Anulowane zamówienia";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVoid
            // 
            this.btnVoid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.btnVoid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoid.FlatAppearance.BorderSize = 0;
            this.btnVoid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoid.ForeColor = System.Drawing.Color.White;
            this.btnVoid.Image = global::POS_Inventory_System.Properties.Resources._void;
            this.btnVoid.Location = new System.Drawing.Point(291, 230);
            this.btnVoid.Name = "btnVoid";
            this.btnVoid.Size = new System.Drawing.Size(84, 53);
            this.btnVoid.TabIndex = 13;
            this.btnVoid.Text = "Unieważnij";
            this.btnVoid.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVoid.UseVisualStyleBackColor = false;
            this.btnVoid.Click += new System.EventHandler(this.btnVoid_Click);
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
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(184, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.UseVisualStyleBackColor = false;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.DisplayIcon = true;
            this.txtPassword.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtPassword.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Icon = global::POS_Inventory_System.Properties.Resources.key_24;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(81, 165);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PromptText = "Hasło";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(218, 35);
            this.txtPassword.Style = MetroFramework.MetroColorStyle.White;
            this.txtPassword.TabIndex = 15;
            this.txtPassword.UseCustomBackColor = true;
            this.txtPassword.UseCustomForeColor = true;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.UseStyleColors = true;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.WaterMark = "Hasło";
            this.txtPassword.WaterMarkColor = System.Drawing.Color.White;
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.txtUserName.CustomButton.Location = new System.Drawing.Point(184, 1);
            this.txtUserName.CustomButton.Name = "";
            this.txtUserName.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserName.CustomButton.TabIndex = 1;
            this.txtUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUserName.CustomButton.UseSelectable = true;
            this.txtUserName.CustomButton.UseVisualStyleBackColor = false;
            this.txtUserName.CustomButton.Visible = false;
            this.txtUserName.DisplayIcon = true;
            this.txtUserName.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtUserName.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txtUserName.ForeColor = System.Drawing.Color.White;
            this.txtUserName.Icon = global::POS_Inventory_System.Properties.Resources.user_2_24;
            this.txtUserName.Lines = new string[0];
            this.txtUserName.Location = new System.Drawing.Point(81, 92);
            this.txtUserName.MaxLength = 32767;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.PromptText = "Nazwa użytkownika";
            this.txtUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserName.SelectedText = "";
            this.txtUserName.SelectionLength = 0;
            this.txtUserName.SelectionStart = 0;
            this.txtUserName.ShortcutsEnabled = true;
            this.txtUserName.Size = new System.Drawing.Size(218, 35);
            this.txtUserName.Style = MetroFramework.MetroColorStyle.White;
            this.txtUserName.TabIndex = 14;
            this.txtUserName.UseCustomBackColor = true;
            this.txtUserName.UseCustomForeColor = true;
            this.txtUserName.UseSelectable = true;
            this.txtUserName.UseStyleColors = true;
            this.txtUserName.WaterMark = "Nazwa użytkownika";
            this.txtUserName.WaterMarkColor = System.Drawing.Color.White;
            this.txtUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Form_Void
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(374, 287);
            this.ControlBox = false;
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnVoid);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_Void";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnVoid;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroTextBox txtUserName;
    }
}