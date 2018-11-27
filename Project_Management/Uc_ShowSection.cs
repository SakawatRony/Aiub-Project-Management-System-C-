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
    public partial class Uc_ShowSection : UserControl
    {
        public Uc_ShowSection(string stu_name, string stu_id, string stu_sec, string stu_ingroup)
        {
            InitializeComponent();
            label1.Text = stu_name;
            label2.Text = stu_id;
            label3.Text = stu_sec;
            label4.Text = stu_ingroup;
        }

        private void Uc_ShowSection_Load(object sender, EventArgs e)
        {

        }
    }
}
