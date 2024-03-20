namespace POS_Inventory_System
{
    partial class CancelDetails
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
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCancel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVoid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTransno = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cmbAction = new System.Windows.Forms.ComboBox();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCancelQty = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
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
            this.panel1.Size = new System.Drawing.Size(848, 35);
            this.panel1.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(800, 0);
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
            this.label2.Size = new System.Drawing.Size(224, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Anulacja szczegółów zamówienia";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(41, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 31);
            this.label7.TabIndex = 37;
            this.label7.Text = "Numer transakcji";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(461, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 31);
            this.label4.TabIndex = 31;
            this.label4.Text = "Opis";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPCode
            // 
            this.txtPCode.Location = new System.Drawing.Point(589, 89);
            this.txtPCode.Name = "txtPCode";
            this.txtPCode.Size = new System.Drawing.Size(229, 22);
            this.txtPCode.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(461, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 31);
            this.label3.TabIndex = 29;
            this.label3.Text = "Kod produktu";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 31);
            this.label1.TabIndex = 27;
            this.label1.Text = "Identyfikator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(589, 138);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(229, 22);
            this.txtDescription.TabIndex = 39;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(589, 236);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(229, 22);
            this.txtQty.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(461, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 31);
            this.label8.TabIndex = 42;
            this.label8.Text = "Ilość";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(589, 187);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(112, 22);
            this.txtPrice.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(461, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 31);
            this.label9.TabIndex = 40;
            this.label9.Text = "Cena / Zniżka";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(589, 285);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(229, 22);
            this.txtTotal.TabIndex = 45;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(461, 282);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 31);
            this.label11.TabIndex = 44;
            this.label11.Text = "Całość";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(39, 427);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 31);
            this.label5.TabIndex = 50;
            this.label5.Text = "Dodane do archiwum";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCancel
            // 
            this.txtCancel.Enabled = false;
            this.txtCancel.Location = new System.Drawing.Point(182, 381);
            this.txtCancel.Name = "txtCancel";
            this.txtCancel.Size = new System.Drawing.Size(229, 22);
            this.txtCancel.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(39, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 31);
            this.label6.TabIndex = 48;
            this.label6.Text = "Anolowane przez";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtVoid
            // 
            this.txtVoid.Enabled = false;
            this.txtVoid.Location = new System.Drawing.Point(182, 332);
            this.txtVoid.Name = "txtVoid";
            this.txtVoid.Size = new System.Drawing.Size(229, 22);
            this.txtVoid.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(36, 331);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 31);
            this.label10.TabIndex = 46;
            this.label10.Text = "Unieważnione przez";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTransno
            // 
            this.txtTransno.Location = new System.Drawing.Point(182, 138);
            this.txtTransno.Name = "txtTransno";
            this.txtTransno.Size = new System.Drawing.Size(229, 22);
            this.txtTransno.TabIndex = 53;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(182, 89);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(229, 22);
            this.txtID.TabIndex = 52;
            // 
            // cmbAction
            // 
            this.cmbAction.FormattingEnabled = true;
            this.cmbAction.Items.AddRange(new object[] {
            "Tak",
            "Nie"});
            this.cmbAction.Location = new System.Drawing.Point(182, 427);
            this.cmbAction.Name = "cmbAction";
            this.cmbAction.Size = new System.Drawing.Size(229, 24);
            this.cmbAction.TabIndex = 54;
            this.cmbAction.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbAction_KeyPress);
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(589, 385);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(229, 68);
            this.txtReason.TabIndex = 56;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(461, 381);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 31);
            this.label12.TabIndex = 55;
            this.label12.Text = "Przyczyna";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::POS_Inventory_System.Properties.Resources.cancel;
            this.btnSave.Location = new System.Drawing.Point(686, 476);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(132, 61);
            this.btnSave.TabIndex = 57;
            this.btnSave.Text = "Anuluj zamówienie";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCancelQty
            // 
            this.txtCancelQty.Location = new System.Drawing.Point(589, 328);
            this.txtCancelQty.Name = "txtCancelQty";
            this.txtCancelQty.Size = new System.Drawing.Size(229, 22);
            this.txtCancelQty.TabIndex = 59;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(461, 328);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 31);
            this.label13.TabIndex = 58;
            this.label13.Text = "An. ilość";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(706, 186);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(112, 22);
            this.txtDiscount.TabIndex = 60;
            // 
            // Form_CancelDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(848, 549);
            this.ControlBox = false;
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtCancelQty);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbAction);
            this.Controls.Add(this.txtTransno);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCancel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtVoid);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_CancelDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtPCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtDescription;
        public System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtCancel;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtVoid;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtTransno;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.TextBox txtCancelQty;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox txtDiscount;
        public System.Windows.Forms.ComboBox cmbAction;
    }
}