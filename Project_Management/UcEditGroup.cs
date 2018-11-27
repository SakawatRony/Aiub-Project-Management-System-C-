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
    public partial class UcEditGroup : UserControl
    {
        public UcEditGroup(string name, string id, string sec, string part)
        {
            InitializeComponent();
            label1.Text = name;
            label2.Text = id;
            label3.Text = sec;
            label4.Text = part;
        }
        public UcEditGroup(string name)
        {
            InitializeComponent();
            label1.Text = name;
            
        }

        private void UcEditGroup_Load(object sender, EventArgs e)
        {

        }

      //  private Form1 f1;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            // string a = this.label1.ToString();
            // DataClass.EditGroupDeleteStudent.Add(a);

            //foreach (Control c in f1.flp_editgroup.Controls)
            //{
            //    if (c.Contains(label1) )
            //    {
            //        if (label1.Text == a)
            //        {
            //            f1.flp_editgroup.Controls.Remove(c);
            //            f1.flp_editgroup.Refresh();

            //        }
            //    }
            //}
            //f1.flp_editgroup.Controls.Remove();
        }
    }
}
