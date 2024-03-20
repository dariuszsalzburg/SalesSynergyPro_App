using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Inventory_System
{
    public partial class CancelDetails : Form
    {
        SoldItem f;
        public CancelDetails( SoldItem frm)
        {
            InitializeComponent();
            f = frm;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void RefreshList()
        {
            f.LoadRecords();
        }


        private void cmbAction_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if ((cmbAction.Text != String.Empty && (txtQty.Text != String.Empty) && (txtReason.Text != String.Empty)))
                {
                    if(int.Parse(txtQty.Text) > int.Parse(txtCancelQty.Text))
                    {
                        Void f = new Void(this);
                        f.ShowDialog();
                    }
             
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
