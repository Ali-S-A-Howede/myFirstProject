using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsayTraining_Application
{
    public partial class MDI_MainForm : Form
    {
       public MDI_MainForm()
        {
            InitializeComponent();
            
        }

        

        private void btnTypes_Click(object sender, EventArgs e)
        {
            frmItem frm = new frmItem();
            clsMain.ShowMeAsChild(this, frm);
        }

        private void btnGroups_Click(object sender, EventArgs e)
        {
            frmGroups R = new frmGroups();
            clsMain.ShowMeAsChild(this, R);
        }
        }
    }

