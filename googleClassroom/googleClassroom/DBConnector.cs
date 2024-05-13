using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace googleClassroom
{
    public class DBConnector
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;

        private string con = "";
        public string MyConnection()
        {
            con = @"Data Source=DESKTOP-FHOMO1J\SQLEXPRESS;Initial Catalog=labproject;Integrated Security=True";
            return con;
        }
    }
}
