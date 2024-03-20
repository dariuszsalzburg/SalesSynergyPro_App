using System.Windows;

namespace POS_Inventory_System
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();

            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSalesHistory = new System.Windows.Forms.Button();
            this.btnUserAccount = new System.Windows.Forms.Button();
            this.btnStockIn = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnBrand = new System.Windows.Forms.Button();
            this.CenterPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnMin);
            this.panel1.Controls.Add(this.btnMax);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnSalesHistory);
            this.panel1.Controls.Add(this.btnUserAccount);
            this.panel1.Controls.Add(this.btnStockIn);
            this.panel1.Controls.Add(this.btnProducts);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.btnCategory);
            this.panel1.Controls.Add(this.btnBrand);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1069, 35);
            this.panel1.TabIndex = 0;
            this.panel1.UseWaitCursor = true;
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.btnMin.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.Location = new System.Drawing.Point(955, -1);
            this.btnMin.Margin = new System.Windows.Forms.Padding(2);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(35, 28);
            this.btnMin.TabIndex = 18;
            this.btnMin.Text = "_";
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.UseWaitCursor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.btnMax.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.ForeColor = System.Drawing.Color.White;
            this.btnMax.Location = new System.Drawing.Point(995, -2);
            this.btnMax.Margin = new System.Windows.Forms.Padding(2);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(35, 28);
            this.btnMax.TabIndex = 17;
            this.btnMax.Text = "[ ]";
            this.btnMax.UseVisualStyleBackColor = false;
            this.btnMax.UseWaitCursor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1034, -1);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(35, 28);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.UseWaitCursor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(866, -1);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(84, 29);
            this.button9.TabIndex = 9;
            this.button9.Text = "Wyloguj się";
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.UseWaitCursor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(690, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 25);
            this.button1.TabIndex = 12;
            this.button1.Text = "Nazwa";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSalesHistory
            // 
            this.btnSalesHistory.FlatAppearance.BorderSize = 0;
            this.btnSalesHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesHistory.ForeColor = System.Drawing.Color.White;
            this.btnSalesHistory.Location = new System.Drawing.Point(493, 3);
            this.btnSalesHistory.Name = "btnSalesHistory";
            this.btnSalesHistory.Size = new System.Drawing.Size(92, 24);
            this.btnSalesHistory.TabIndex = 11;
            this.btnSalesHistory.Text = "Historia ";
            this.btnSalesHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalesHistory.UseVisualStyleBackColor = true;
            this.btnSalesHistory.UseWaitCursor = true;
            this.btnSalesHistory.Click += new System.EventHandler(this.btnSalesHistory_Click);
            // 
            // btnUserAccount
            // 
            this.btnUserAccount.FlatAppearance.BorderSize = 0;
            this.btnUserAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserAccount.ForeColor = System.Drawing.Color.White;
            this.btnUserAccount.Location = new System.Drawing.Point(591, 3);
            this.btnUserAccount.Name = "btnUserAccount";
            this.btnUserAccount.Size = new System.Drawing.Size(93, 25);
            this.btnUserAccount.TabIndex = 8;
            this.btnUserAccount.Text = "Ustawienia";
            this.btnUserAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUserAccount.UseVisualStyleBackColor = true;
            this.btnUserAccount.UseWaitCursor = true;
            this.btnUserAccount.Click += new System.EventHandler(this.btnUserAccount_Click);
            // 
            // btnStockIn
            // 
            this.btnStockIn.FlatAppearance.BorderSize = 0;
            this.btnStockIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockIn.ForeColor = System.Drawing.Color.White;
            this.btnStockIn.Location = new System.Drawing.Point(3, 3);
            this.btnStockIn.Name = "btnStockIn";
            this.btnStockIn.Size = new System.Drawing.Size(92, 24);
            this.btnStockIn.TabIndex = 10;
            this.btnStockIn.Text = "Magazyn";
            this.btnStockIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnStockIn.UseVisualStyleBackColor = true;
            this.btnStockIn.UseWaitCursor = true;
            this.btnStockIn.Click += new System.EventHandler(this.btnStockIn_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.ForeColor = System.Drawing.Color.White;
            this.btnProducts.Location = new System.Drawing.Point(101, 3);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(92, 25);
            this.btnProducts.TabIndex = 3;
            this.btnProducts.Text = "Produkty";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.UseWaitCursor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(395, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(92, 25);
            this.button6.TabIndex = 6;
            this.button6.Text = "Dokumenty";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.UseWaitCursor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.ForeColor = System.Drawing.Color.White;
            this.btnCategory.Location = new System.Drawing.Point(199, 3);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(92, 25);
            this.btnCategory.TabIndex = 4;
            this.btnCategory.Text = "Kategorie";
            this.btnCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.UseWaitCursor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnBrand
            // 
            this.btnBrand.FlatAppearance.BorderSize = 0;
            this.btnBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrand.ForeColor = System.Drawing.Color.White;
            this.btnBrand.Location = new System.Drawing.Point(297, 3);
            this.btnBrand.Name = "btnBrand";
            this.btnBrand.Size = new System.Drawing.Size(92, 25);
            this.btnBrand.TabIndex = 5;
            this.btnBrand.Text = "Marki";
            this.btnBrand.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBrand.UseVisualStyleBackColor = true;
            this.btnBrand.UseWaitCursor = true;
            this.btnBrand.Click += new System.EventHandler(this.btnBrand_Click);
            // 
            // CenterPanel
            // 
            this.CenterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.CenterPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CenterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterPanel.Location = new System.Drawing.Point(0, 35);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.Size = new System.Drawing.Size(1069, 545);
            this.CenterPanel.TabIndex = 2;
            this.CenterPanel.UseWaitCursor = true;
            this.CenterPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.CenterPanel_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.CenterPanel);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1069, 580);
            this.panel3.TabIndex = 3;
            this.panel3.UseWaitCursor = true;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 580);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.UseWaitCursor = true;
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnBrand;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btnUserAccount;
        private System.Windows.Forms.Button btnStockIn;
        private System.Windows.Forms.Button btnSalesHistory;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Panel CenterPanel;
    }
}

