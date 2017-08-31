using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsayTraining_Application
{
    static class clsMain
    {
        public static void ShowMeAsChild(Form mdi,Form frm)
        {
            // this code to make forms as a child forms to the mdi form
            frm.MdiParent = mdi;
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowInTaskbar = false;
            frm.Show();



        }
    }
}
