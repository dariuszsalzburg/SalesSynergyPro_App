using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace POS_Inventory_System
{
    public partial class ProgressBar : Form
    {

  
        public ProgressBar()
        {
            InitializeComponent();
            
            progressBar1.Value = 0;
            
        }

        private void Form_ProgressBar_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 2;
            progressBar1.Text = progressBar1.Value.ToString() + "%";

            if(progressBar1.Value ==100)
            {
                timer1.Enabled = false;

                Security frm = new Security();
                frm.Show();
                this.Hide();
                frm.txtUserName.Focus();
            }
                 
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
