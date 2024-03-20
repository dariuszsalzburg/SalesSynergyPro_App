using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace POS_Inventory_System
{
    public partial class ChangePassword : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataReader dr;
        POS f;
        public ChangePassword(POS fr)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            f = fr;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string _oldpass = dbcon.GetPassword(f.lblUser.Text);
                if(_oldpass != txtOldPass.Text)
                {
                    MessageBox.Show("Dawne hasło się nie zgadza.");
                }
                else if(txtNewPass.Text != txtConfirmPass.Text)
                {
                    MessageBox.Show("Powtórzone hasło nie zgadza się z nowym hasłem.");
                }
                else
                {
                    if(MessageBox.Show("Zapisać nowe hasło?","", MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
                    {
                        cn.Open();
                        cm = new SqlCommand("update tblUser set password = @password where username = @username", cn);
                        cm.Parameters.AddWithValue("@password", txtNewPass.Text);
                        cm.Parameters.AddWithValue("@username", f.lblUser.Text);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Hasło zostało zmienione pomyślnie");
                        this.Dispose();
                    }
                        
                    
                }
          
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
