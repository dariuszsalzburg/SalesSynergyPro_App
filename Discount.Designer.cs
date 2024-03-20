namespace POS_Inventory_System
{
    partial class Discount
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPricee = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPercent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(817, 35);
            this.panel1.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(773, 0);
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
            this.label2.Size = new System.Drawing.Size(98, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dodaj zniżkę";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPricee
            // 
            this.txtPricee.Enabled = false;
            this.txtPricee.Location = new System.Drawing.Point(195, 68);
            this.txtPricee.Name = "txtPricee";
            this.txtPricee.Size = new System.Drawing.Size(522, 22);
            this.txtPricee.TabIndex = 6;
            this.txtPricee.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(87, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cena:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPercent
            // 
            this.txtPercent.Location = new System.Drawing.Point(195, 115);
            this.txtPercent.Name = "txtPercent";
            this.txtPercent.Size = new System.Drawing.Size(522, 22);
            this.txtPercent.TabIndex = 8;
            this.txtPercent.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(87, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Zniżka (%)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAmount
            // 
            this.txtAmount.Enabled = false;
            this.txtAmount.Location = new System.Drawing.Point(195, 162);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(522, 22);
            this.txtAmount.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(75, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kwota rabatu:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(640, 209);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 35);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblID
            // 
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.Black;
            this.lblID.Location = new System.Drawing.Point(78, 209);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(98, 35);
            this.lblID.TabIndex = 12;
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblID.Visible = false;
            // 
            // Form_Discount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(817, 285);
            this.ControlBox = false;
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPercent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPricee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_Discount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form_Discount_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtPricee;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtPercent;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Label lblID;
    }
}