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
    public partial class UcCreateGroup : UserControl
    {
        public UcCreateGroup(string sname, string sid, string sSec, string sSelect)
        {
            InitializeComponent();
            label1.Text = sname;
            label2.Text = sid;
            label3.Text = sSec.ToString();
            label4.Text = sSelect;
        }

        private void UcCreateGroup_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = label1.Text;
            string b = label2.Text;
            string c = label3.Text;
            string d = label4.Text;
            this.Parent.Controls.Remove(this);
            foreach (string[] V in DataClass.CreateGroupTemporary)
            {


                if (V[0] == a && V[1] == b && V[2] == c && V[3] == d)
                {
                    //  DataClass.CreateGroupTemporary.Remove(V);
                }

            }
            var index = DataClass.CreateGroupTemporary.FindIndex(i => i[0] == label1.Text && i[1] == label2.Text && i[2] == label3.Text && i[3] == label4.Text);
            DataClass.CreateGroupTemporary.RemoveAt(index);
        }
    }
}
