using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management
{
    public partial class UcShowGroups : UserControl
    {
        public UcShowGroups(string grpnum, string grpname, string numofmem, string projtitle)
        {
            InitializeComponent();
            label1.Text = grpnum;
            label2.Text = grpname;
            label3.Text = numofmem.ToString();
            label4.Text = projtitle;

        }

        private void UcShowGroups_Load(object sender, EventArgs e)
        {

        }
    }
}
