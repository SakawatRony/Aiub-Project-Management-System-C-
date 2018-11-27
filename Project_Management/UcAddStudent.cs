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
    public partial class UcAddStudent : UserControl
    {

        public string Name;

        public UcAddStudent(string sname, string sid, string sSec, string sSelect)
        {
            InitializeComponent();
            label1.Text = sname;
            label2.Text = sid;
            label3.Text = sSec.ToString();
            label4.Text = sSelect;
            Name = label1.Text;
            //this.chk.Name = "chk_"+sid;
            // MessageBox.Show(chk.Name.ToString());
        }

        private void UcAddStudent_Load(object sender, EventArgs e)
        {

        }

        public string[] ArrayCreateGroup = new string[4];
        private void chk_CheckedChanged(object sender, EventArgs e)
        {
            if (chk.Checked)
            {
                //  DataClass.CreateGroupAddStudent.Clear();
                string a = label1.Text;
                string b = label2.Text;
                string c = label3.Text;
                string d = label4.Text;


                ArrayCreateGroup[0] = a;
                ArrayCreateGroup[1] = b;
                ArrayCreateGroup[2] = c;
                ArrayCreateGroup[3] = d;
                DataClass.CreateGroupAddStudent.Add(ArrayCreateGroup);
                DataClass.CreateGroupTemporary.Add(ArrayCreateGroup);
            }
            else if (chk.Checked == false)
            {

                string a = label1.Text;
                string b = label2.Text;
                string c = label3.Text;
                string d = label4.Text;
                ArrayCreateGroup[0] = a;
                ArrayCreateGroup[1] = b;
                ArrayCreateGroup[2] = c;
                ArrayCreateGroup[3] = d;
                DataClass.CreateGroupAddStudent.Remove(ArrayCreateGroup);
                DataClass.CreateGroupTemporary.Remove(ArrayCreateGroup);

                //foreach (var aaad in cre)
                //{

                //}

                // var itemToRemove = DataClass.CreateGroupAddStudent.Single(r[] => r[].);
                //resultList.Remove(itemToRemove);

            }
           
        }

    }
}
