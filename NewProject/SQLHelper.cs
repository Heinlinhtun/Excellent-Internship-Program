using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
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

        public static void ComboFill(string query, ComboBox CBox, string DisplayColName, string ValueColName)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);
            CBox.DataSource = dt;
            CBox.DisplayMember = DisplayColName;
            CBox.ValueMember = ValueColName;

        }



    }
}
