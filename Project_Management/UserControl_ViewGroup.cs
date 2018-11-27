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
    public partial class UserControl_ViewGroup : UserControl
    {
        public UserControl_ViewGroup(string name, string id, string section, string part, string mark)
        {
            InitializeComponent();
            label1.Text = name;
            label2.Text = id;
            label3.Text = section;
            label4.Text = part;
            label5.Text = mark;
           // MessageBox.Show(name);
        }

        private void UserControl_ViewGroup_Load(object sender, EventArgs e)
        {

        }
    }
}
