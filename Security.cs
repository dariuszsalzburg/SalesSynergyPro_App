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
    public partial class Security : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DatabaseConnection dbcon = new DatabaseConnection();
        SqlDataReader dr;
        public Security()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usernamee = "", role = "", name = "";


            try
            {

                bool found = false;
                cn.Open();
                cm = new SqlCommand("select * from tblUser where username = @username and password = @password", cn);
                cm.Parameters.AddWithValue("@username", txtUserName.Text);
                cm.Parameters.AddWithValue("@password", txtPassword.Text);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    found = true;
                    usernamee = dr["username"].ToString();
                    role = dr["role"].ToString();
                    name = dr["name"].ToString();
                }
                else
                {
                    found = false;
                }
                dr.Close();

                cn.Close();

                if (found == true)
                {
                    if (role == "user")
                    {

                        txtPassword.Clear();
                        txtUserName.Clear();
                        this.Hide();
                        POS frm = new POS(this);
                        frm.lblUser.Text = usernamee;
                        frm.lblName.Text = name + " | " + role;


                        frm.ShowDialog();
                    }
                    else
                    {

                        txtPassword.Clear();
                        txtUserName.Clear();
                        this.Hide();
                        Form1 frm = new Form1();
                       
                        frm.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Niepoprawna nazwa użytkownika lub hasło");
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show("Błąd");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    
    
}
