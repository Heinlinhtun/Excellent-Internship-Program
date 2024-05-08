using MyClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewProject
{
    public partial class UCEmployee : UserControl
    {
        public UCEmployee()
        {
            InitializeComponent();
        }

        private void UCEmployee_Load(object sender, EventArgs e)
        {
            string query = "SELECT id, TeamName FROM TblTeam";
            SQLHelper.ComboFill(query, ComboTeam, "TeamName", "id");
            string query2 = "SELECT id, PosName FROM TblPosition";
            SQLHelper.ComboFill(query2, ComboPosition, "PosName", "id");
        }
    }
}
