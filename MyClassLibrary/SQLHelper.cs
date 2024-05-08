using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data;

namespace MyClassLibrary
{
    public class SQLHelper
    {
        public static SqlConnection con = new SqlConnection(@"Data Source =.; Initial Catalog = EmpDB; Persist Security Info=True;User ID = sa; Password=admin");

        public static void ComboFill(string query, string ComboName, string DisplayColName, string ValueColName)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);
            
        }



    }
}
