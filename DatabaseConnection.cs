using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace POS_Inventory_System
{
     public class DatabaseConnection
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        /// <summary>
        /// Czy używać lokalnej bazy danych
        /// </summary>
        private bool localConnection = false;
        public string MyConnection()
        {
            string cn = "Data Source=DESKTOP-F4HE8K3;Initial Catalog=SaleManagementSystem;Integrated Security=True";
            return cn;
        }

        public double GetVal()
        {
            double vat = 0;
            cn.ConnectionString = MyConnection();
            cn.Open();
            cm = new SqlCommand("select * from tblVat", cn);
            dr = cm.ExecuteReader();
            while(dr.Read())
            {
                vat = Double.Parse(dr["vat"].ToString());
            }
            dr.Close();
            cn.Close();
            return vat;
        }

        public string GetPassword(string user)
        {
            string password = "";
       


            cn.ConnectionString = MyConnection();
            cn.Open();
            cm = new SqlCommand("select * from tblUser where username = @username", cn);
            cm.Parameters.AddWithValue("@username", user);
            dr = cm.ExecuteReader();
            dr.Read();
            if(dr.HasRows)
            {
                password = dr["password"].ToString();
            }
     
            dr.Close();
            cn.Close();
            return password;
        }
    }
}
