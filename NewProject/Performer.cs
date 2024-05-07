using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject
{
    public class Performer
    {
        public static void ucFill(Panel pnl, UserControl uc)
        {
            pnl.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnl.Controls.Add(uc);
        }
    }
}
