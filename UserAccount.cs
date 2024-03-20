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
    public partial class UserAccount : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataReader dr;
        public UserAccount()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }
        private void Clear()
        {
            txtName.Clear();
            txtPass.Clear();
            txtRetypePass.Clear();
            cmbRole.Text = "";
            txtUser.Clear();
            txtUser.Focus();

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {


                if (txtPass.Text != txtRetypePass.Text)
                {
                    MessageBox.Show("Hasła się nie zgadzają. Proszę spróbować ponownie.");
                    return;
                }
                cn.Open();
                cm = new SqlCommand("insert into tblUser (username,password,role,name) values(@username,@password,@role,@name)", cn);
                cm.Parameters.AddWithValue("@username", txtUser.Text);
                cm.Parameters.AddWithValue("@password", txtPass.Text);
                cm.Parameters.AddWithValue("@role", cmbRole.Text);
                cm.Parameters.AddWithValue("@name", txtName.Text);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Dodano uśytkownika pomyślnie.");
                Clear();




            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);

            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }
    }
}
