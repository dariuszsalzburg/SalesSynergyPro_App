
namespace POS_Inventory_System
{
    partial class ChangePassword
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtConfirmPass = new MetroFramework.Controls.MetroTextBox();
            this.txtNewPass = new MetroFramework.Controls.MetroTextBox();
            this.txtOldPass = new MetroFramework.Controls.MetroTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(800, 35);
            this.panel1.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(750, -1);
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
            this.label2.Size = new System.Drawing.Size(110, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Zmiana hasła";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.txtConfirmPass);
            this.panel2.Controls.Add(this.txtNewPass);
            this.panel2.Controls.Add(this.txtOldPass);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 338);
            this.panel2.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::POS_Inventory_System.Properties.Resources.add;
            this.btnSave.Location = new System.Drawing.Point(522, 231);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 53);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Zapisz";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            // 
            // 
            // 
            this.txtConfirmPass.CustomButton.BackColor = System.Drawing.Color.White;
            this.txtConfirmPass.CustomButton.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPass.CustomButton.Image = null;
            this.txtConfirmPass.CustomButton.Location = new System.Drawing.Point(347, 1);
            this.txtConfirmPass.CustomButton.Name = "";
            this.txtConfirmPass.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtConfirmPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConfirmPass.CustomButton.TabIndex = 1;
            this.txtConfirmPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConfirmPass.CustomButton.UseSelectable = true;
            this.txtConfirmPass.CustomButton.UseVisualStyleBackColor = false;
            this.txtConfirmPass.CustomButton.Visible = false;
            this.txtConfirmPass.DisplayIcon = true;
            this.txtConfirmPass.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtConfirmPass.ForeColor = System.Drawing.Color.White;
            this.txtConfirmPass.Icon = global::POS_Inventory_System.Properties.Resources.key_24;
            this.txtConfirmPass.Lines = new string[0];
            this.txtConfirmPass.Location = new System.Drawing.Point(218, 176);
            this.txtConfirmPass.MaxLength = 32767;
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.PasswordChar = '●';
            this.txtConfirmPass.PromptText = "Powtórz hasło";
            this.txtConfirmPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConfirmPass.SelectedText = "";
            this.txtConfirmPass.SelectionLength = 0;
            this.txtConfirmPass.SelectionStart = 0;
            this.txtConfirmPass.ShortcutsEnabled = true;
            this.txtConfirmPass.Size = new System.Drawing.Size(381, 35);
            this.txtConfirmPass.Style = MetroFramework.MetroColorStyle.White;
            this.txtConfirmPass.TabIndex = 7;
            this.txtConfirmPass.UseCustomBackColor = true;
            this.txtConfirmPass.UseCustomForeColor = true;
            this.txtConfirmPass.UseSelectable = true;
            this.txtConfirmPass.UseStyleColors = true;
            this.txtConfirmPass.UseSystemPasswordChar = true;
            this.txtConfirmPass.WaterMark = "Powtórz hasło";
            this.txtConfirmPass.WaterMarkColor = System.Drawing.Color.White;
            this.txtConfirmPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtNewPass
            // 
            this.txtNewPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            // 
            // 
            // 
            this.txtNewPass.CustomButton.BackColor = System.Drawing.Color.White;
            this.txtNewPass.CustomButton.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass.CustomButton.Image = null;
            this.txtNewPass.CustomButton.Location = new System.Drawing.Point(347, 1);
            this.txtNewPass.CustomButton.Name = "";
            this.txtNewPass.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtNewPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNewPass.CustomButton.TabIndex = 1;
            this.txtNewPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNewPass.CustomButton.UseSelectable = true;
            this.txtNewPass.CustomButton.UseVisualStyleBackColor = false;
            this.txtNewPass.CustomButton.Visible = false;
            this.txtNewPass.DisplayIcon = true;
            this.txtNewPass.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNewPass.ForeColor = System.Drawing.Color.White;
            this.txtNewPass.Icon = global::POS_Inventory_System.Properties.Resources.key_24;
            this.txtNewPass.Lines = new string[0];
            this.txtNewPass.Location = new System.Drawing.Point(218, 117);
            this.txtNewPass.MaxLength = 32767;
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '●';
            this.txtNewPass.PromptText = "Nowe hasło";
            this.txtNewPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNewPass.SelectedText = "";
            this.txtNewPass.SelectionLength = 0;
            this.txtNewPass.SelectionStart = 0;
            this.txtNewPass.ShortcutsEnabled = true;
            this.txtNewPass.Size = new System.Drawing.Size(381, 35);
            this.txtNewPass.Style = MetroFramework.MetroColorStyle.White;
            this.txtNewPass.TabIndex = 6;
            this.txtNewPass.UseCustomBackColor = true;
            this.txtNewPass.UseCustomForeColor = true;
            this.txtNewPass.UseSelectable = true;
            this.txtNewPass.UseStyleColors = true;
            this.txtNewPass.UseSystemPasswordChar = true;
            this.txtNewPass.WaterMark = "Nowe hasło";
            this.txtNewPass.WaterMarkColor = System.Drawing.Color.White;
            this.txtNewPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtOldPass
            // 
            this.txtOldPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            // 
            // 
            // 
            this.txtOldPass.CustomButton.BackColor = System.Drawing.Color.White;
            this.txtOldPass.CustomButton.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldPass.CustomButton.Image = null;
            this.txtOldPass.CustomButton.Location = new System.Drawing.Point(347, 1);
            this.txtOldPass.CustomButton.Name = "";
            this.txtOldPass.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtOldPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOldPass.CustomButton.TabIndex = 1;
            this.txtOldPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOldPass.CustomButton.UseSelectable = true;
            this.txtOldPass.CustomButton.UseVisualStyleBackColor = false;
            this.txtOldPass.CustomButton.Visible = false;
            this.txtOldPass.DisplayIcon = true;
            this.txtOldPass.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtOldPass.ForeColor = System.Drawing.Color.White;
            this.txtOldPass.Icon = global::POS_Inventory_System.Properties.Resources.key_24;
            this.txtOldPass.Lines = new string[0];
            this.txtOldPass.Location = new System.Drawing.Point(218, 58);
            this.txtOldPass.MaxLength = 32767;
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.PasswordChar = '●';
            this.txtOldPass.PromptText = "Dawne hasło";
            this.txtOldPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOldPass.SelectedText = "";
            this.txtOldPass.SelectionLength = 0;
            this.txtOldPass.SelectionStart = 0;
            this.txtOldPass.ShortcutsEnabled = true;
            this.txtOldPass.Size = new System.Drawing.Size(381, 35);
            this.txtOldPass.Style = MetroFramework.MetroColorStyle.White;
            this.txtOldPass.TabIndex = 5;
            this.txtOldPass.UseCustomBackColor = true;
            this.txtOldPass.UseCustomForeColor = true;
            this.txtOldPass.UseSelectable = true;
            this.txtOldPass.UseStyleColors = true;
            this.txtOldPass.UseSystemPasswordChar = true;
            this.txtOldPass.WaterMark = "Dawne hasło";
            this.txtOldPass.WaterMarkColor = System.Drawing.Color.White;
            this.txtOldPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Form_ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(800, 373);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroTextBox txtConfirmPass;
        private MetroFramework.Controls.MetroTextBox txtNewPass;
        private MetroFramework.Controls.MetroTextBox txtOldPass;
        public System.Windows.Forms.Button btnSave;
    }
}