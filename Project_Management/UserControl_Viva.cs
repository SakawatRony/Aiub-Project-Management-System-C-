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
    public partial class UserControl_Viva : UserControl
    {
        public UserControl_Viva(string name, string id)
        {
            InitializeComponent();
            label1.Text = name;
            label2.Text = id;
        }

        private void UserControl_Viva_Load(object sender, EventArgs e)
        {

        }
        public int[] ArrayCreateGroup = new int[5];
        public string[] ArrayCreateGroup2 = new string[5];
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                //string Inheritance = checkBox1.Text;
                int a = 5;
                ArrayCreateGroup[0] = a;
                DataClass.CreateGroupVivaStudent.Add(ArrayCreateGroup);
                DataClass.CreateVivaTemporary.Add(ArrayCreateGroup);
              //  string ad=label1.Text;
              //  ArrayCreateGroup2[0] = ad;

            }
            else if (checkBox1.Checked == false)
            {
                string Inheritance = checkBox1.Text;
                DataClass.CreateGroupVivaStudent.Remove(ArrayCreateGroup);
                DataClass.CreateVivaTemporary.Remove(ArrayCreateGroup);
            }
        }
    }
}
