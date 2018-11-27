using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ExcelDataReader;
using System.Xml;
using System.Resources;
using System.Data.OleDb;
using LinqToExcel;
using Remotion.Data.Linq;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing.Text;


namespace Project_Management
{
    public partial class Form1 : Form
    {   
        int num = 0;
        int MenuPanelWidth;
        int ifCourseChoosed = 0;
        bool MenuHidden;
        public string CurrentChoosedSubject;
       

       

        public Form1()
        {
            InitializeComponent();
            MenuPanelWidth = pnl_LeftCatagory.Width;
            MenuHidden = true;
            pnl_LeftCatagory.Hide();
            HideAllPanel();
            pnl_CourseChooser.Show();
            picbox_help_slide.Image =
                Image.FromFile("img/1.jpg");
            
        }

        private void HideAllPanel()
        {
            pnl_CreateGroup.Hide();
            pnl_CreateGroupTop.Hide();
            pnl_ViewAGroup.Hide();
            pnl_EditGroup.Hide();
            pnl_ShowGroups.Hide();
            pnl_ImportSection.Hide();
            pnl_ShowSections.Hide();
            pnl_Viva.Hide();
            pnl_LeftCatagory.Hide();
            pnl_AddStudent.Hide();
            pnl_About.Hide();
            pnl_Help.Hide();
            pnl_AddTopic.Hide();
            pnl_FirstPage.Hide();

        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            if(ifCourseChoosed==1)
            {
            HideAllPanel();
            MenuHidden = true;
            pnl_Help.Show();
            } 
            else
            {
                MessageBox.Show("Please Choose a Course First");
            }
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            if (ifCourseChoosed == 1)
            {
                pnl_LeftCatagory.Show();
                timer_Menu.Start();
            }
            else
            {
                MessageBox.Show("Please Choose a Course First");
            }
        }

        private void timer_Menu_Tick(object sender, EventArgs e)
        {
            
            if (MenuHidden)
            {
                pnl_LeftCatagory.Width = pnl_LeftCatagory.Width + 10;
                if (pnl_LeftCatagory.Width >= MenuPanelWidth)
                {
                    timer_Menu.Stop();
                    MenuHidden = false;
                    this.Refresh();
                }
            }
            else
            {
                pnl_LeftCatagory.Width = pnl_LeftCatagory.Width - 10;
                if (pnl_LeftCatagory.Width <= 0)
                {
                    timer_Menu.Stop();
                    MenuHidden = true;
                    this.Refresh();
                }
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Minus_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized; 
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            HideAllPanel();
            MenuHidden = true;
            pnl_ImportSection.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_CreateGroup_Click(object sender, EventArgs e)
        {

            HideAllPanel();
            MenuHidden = true;
            pnl_CreateGroupTop.Show();


        }

        private void btn_EditGroup_Click(object sender, EventArgs e)
        {
            HideAllPanel();
            MenuHidden = true;
            pnl_EditGroup.Show();
        }

        private void btn_ShowGroups_Click(object sender, EventArgs e)
        {
            HideAllPanel();
            MenuHidden = true;
            pnl_ShowGroups.Show();
        }

        private void btn_ViewAGroup_Click(object sender, EventArgs e)
        {
            HideAllPanel();
            MenuHidden = true;
            pnl_ViewAGroup.Show();

        }

        private void btn_Viva_Click(object sender, EventArgs e)
        {
            HideAllPanel();
            MenuHidden = true;
            pnl_Viva.Show();
        }

        private void btn_ShowSections_Click(object sender, EventArgs e)
        {
            HideAllPanel();
            MenuHidden = true;
            pnl_ShowSections.Show();
        }

        private void btn_SignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form0 f1 = new Form0();
            f1.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HideAllPanel();
            pnl_AddStudent.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            btnCreateManually_Click(sender, e);
        }

        private void btnCreateManually_Click(object sender, EventArgs e)
        {
            HideAllPanel();
            MenuHidden = true;
            pnl_CreateGroupTop.Hide();
            pnl_CreateGroup.Show();

        }

        private void btn_ImportGroup_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            txt_FilePath.Text = openFileDialog1.FileName;
            BindDataCSV(txt_FilePath.Text);
            for (int i = 0; i < dataGridView2.RowCount - 1; i++) // array rows
            {
                string st_name = dataGridView2.Rows[i].Cells[4].Value.ToString();
                string st_id = dataGridView2.Rows[i].Cells[5].Value.ToString();
                string st_section = dataGridView2.Rows[i].Cells[6].Value.ToString();
                string part = " ";
                string grp_name = dataGridView2.Rows[0].Cells[1].Value.ToString();
                string grp_prjT = dataGridView2.Rows[0].Cells[2].Value.ToString();
                string grp_no_mem = dataGridView2.Rows[0].Cells[3].Value.ToString();
                txt_CreateGroup_GroupName.Text = grp_name;
                txt_CreateGroup_ProjectTitle.Text = grp_prjT;
                txt_CreateGroup_NumberOfMember.Text = grp_no_mem;
                //fl_CreateGroup.
                this.fl_CreateGroup.Controls.Add(new UcCreateGroup(st_name,st_id,st_section,part));
            }

        }
        private void BindDataCSV(string filePath)
        {
            DataTable dt = new DataTable();
            string[] lines = System.IO.File.ReadAllLines(filePath);
            if (lines.Length > 0)
            {
                string firstLine = lines[0];
                string[] headerLabels = firstLine.Split(',');
                foreach (string headWord in headerLabels)
                {
                    dt.Columns.Add(new DataColumn(headWord));
                }
                for (int r = 1; r < lines.Length; r++)
                {
                    string[] dataWrods = lines[r].Split(',');
                    DataRow dr = dt.NewRow();
                    int columIndex = 0;
                    foreach (string headWord in headerLabels)
                    {
                      //  DataRow dr = dt.NewRow();
                        dr[headWord] = dataWrods[columIndex++];
                    }
                    dt.Rows.Add(dr);
                }
            }
            if (dt.Rows.Count > 0)
            {
                dataGridView2.DataSource = dt;
            }
        }

        private void txt_ProjectTitle_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_GroupNumber_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_GroupName_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void lbl_ProjectTitle_Click(object sender, EventArgs e)
        {

        }

        private void pnl_CreateGroup_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_NumberOfMember_Click(object sender, EventArgs e)
        {

        }

        private void lbl_GroupNumber_Click(object sender, EventArgs e)
        {

        }

        private void txt_NumberOfMember_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void cmb_SemesterChooser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_StudentName_Click(object sender, EventArgs e)
        {

        }

        private void lbl_StudentId_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Section_Click(object sender, EventArgs e)
        {

        }

        private void lbl_ProjectPart_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btn_SaveGroup_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_About_Click(object sender, EventArgs e)
        {
            if(ifCourseChoosed==1)
            {
            HideAllPanel();
            MenuHidden = true;
            pnl_About.Show();
            }
            else
            {
                MessageBox.Show("Please Choose a Course First");
            }
        }

        DataSet result;
        string text2 = "Sheet1";
        string text1;
        private void btn_ImportSection_ImportSection_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Excel workbook|*.xls";
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                text1 = ofd.FileName;
                System.Data.OleDb.OleDbConnection MyConnection;
                System.Data.DataSet DtSet;
                System.Data.OleDb.OleDbDataAdapter MyCommand;
                MyConnection = new System.Data.OleDb.OleDbConnection(@"provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + text1 + ";Extended Properties=Excel 8.0;");
                MyCommand = new System.Data.OleDb.OleDbDataAdapter("select * from [Sheet1$]", MyConnection);
                MyCommand.TableMappings.Add("Table", "Net-informations.com");
                DtSet = new System.Data.DataSet();
                MyCommand.Fill(DtSet);
                dataGridView1.DataSource = DtSet.Tables[0];
                MyConnection.Close();



           }
        }

        private void txt_EditGroup_GroupNo_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void lbl_ShowGroups_GroupName_Click(object sender, EventArgs e)
        {

        }

        private void btn_ShowGroups_Go_Click(object sender, EventArgs e)
        {
            string semester = cmb_ShowGroups_SemesterChoose.Text.ToString();
            db_accountDataContext db = new db_accountDataContext();
            var prods = from p in db.tb_groups
                        where p.grp_semester.Contains(semester)
                        select p;

            foreach (var a in prods)
            {
                string grpnum = a.grp_groupNumber;
                string grpname = a.grp_groupName;
                string numOfmem = a.grp_NumberOfMember.ToString();
                string projName = a.grp_projectTitle;

                this.flp_showGroups.Controls.Add(new UcShowGroups(grpnum, grpname, numOfmem, projName));

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_CourseChooser_Go_Click(object sender, EventArgs e)
        {
            if (cmb_CourseChooser_ChooseSubject.Text!="          Course")
            {
            pnl_CourseChooser.Hide();
            HideAllPanel();
            pnl_FirstPage.Show();
            ifCourseChoosed = 1;
            CurrentChoosedSubject = cmb_CourseChooser_ChooseSubject.Text;
            }
            else
            {
                MessageBox.Show("Please Select a Course to continue");
            }
        }

        private void btn_ImportSection_Save_Click(object sender, EventArgs e)
        {
           

            for (int i = 0; i < dataGridView1.RowCount-1; i++)// array rows
            {
                
                db_accountDataContext db = new db_accountDataContext();
                tb_section acc = new tb_section();
                acc.sec_st_name = dataGridView1.Rows[i].Cells[2].Value.ToString();
                acc.sec_st_id = dataGridView1.Rows[i].Cells[1].Value.ToString();
                acc.sec_st_section = dataGridView1.Rows[i].Cells[3].Value.ToString();
                acc.sec_semester = "Fall, 2017-2018";
                acc.sec_inGroup = "YEs";
                acc.sec_subject = "Java";
                acc.sec_username = "aaaa";
                db.tb_sections.InsertOnSubmit(acc);
                db.SubmitChanges();
            }

            MessageBox.Show("Data Saved Successfully");


        }

        private void btn_viva_print_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK) printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           // e.Graphics.DrawString(this.textBox1.Text, this.textBox1.Font, Brushes.Black, 10, 25);
        }

        private void btn_showgroup_print_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK) printDocument1.Print();
        }

        private void cmb_CourseChooser_ChooseSubject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pnl_CourseChooser_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_ShowGroups_Paint(object sender, PaintEventArgs e)
        {

        }

        private void previousImage(object sender, EventArgs e)
        {
            num--;
            if (num < 1)
            {
                num = 1;
            }
            picbox_help_slide.Image =
                Image.FromFile("img/" + num + ".jpg");
        }

        private void nextImage(object sender, EventArgs e)
        {
            num++;
            if (num == 6)
            {
                num = 1;
            }
            picbox_help_slide.Image =
                Image.FromFile("img/" + num + ".jpg");
        }

        private void btn_Facebook_Tonmoy_Click(object sender, EventArgs e)
        {
            Process myProcess = new Process();

            try
            {
                // true is the default, but it is important not to set it to false
                myProcess.StartInfo.UseShellExecute = true;
                myProcess.StartInfo.FileName = "https://www.facebook.com/tonmoy.asif";
                myProcess.Start();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }

        private void btn_Facebook_Rony_Click(object sender, EventArgs e)
        {
            {
                Process myProcess = new Process();

                try
                {
                    // true is the default, but it is important not to set it to false
                    myProcess.StartInfo.UseShellExecute = true;
                    myProcess.StartInfo.FileName = "https://www.facebook.com/sakawathossain.rony";
                    myProcess.Start();
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            }
        }

        private void btn_Facebook_Karno_Click(object sender, EventArgs e)
        {
            {
                Process myProcess = new Process();

                try
                {
                    // true is the default, but it is important not to set it to false
                    myProcess.StartInfo.UseShellExecute = true;
                    myProcess.StartInfo.FileName = "https://www.facebook.com/karno.sarker";
                    myProcess.Start();
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            }
        }

        private void btn_Facebook_Kanon_Click(object sender, EventArgs e)
        {
            {
                Process myProcess = new Process();

                try
                {
                    // true is the default, but it is important not to set it to false
                    myProcess.StartInfo.UseShellExecute = true;
                    myProcess.StartInfo.FileName = "https://www.facebook.com/rafique.kanon";
                    myProcess.Start();
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            }
        }

        private void btn_AddStudent_Back_Click(object sender, EventArgs e)
        {
            HideAllPanel();
            pnl_CreateGroup.Show();
        }

        private void btn_AddStudent_Go_Click(object sender, EventArgs e)
        {
            string semester = cmb_AddStudent_SemesterChooser.Text.ToString();
            string section = cmb_AddStudent_SectionChooser.Text.ToString();

            db_accountDataContext db = new db_accountDataContext();
            var prods = from p in db.tb_sections
                where p.sec_semester.Contains(semester)
                where p.sec_st_section.Contains(section)
                select p;

            foreach (var a in prods)
            {
                string sname = a.sec_st_name;
                string sid = a.sec_st_id;
                string sSec = a.sec_st_section;
                string sSelect = a.sec_inGroup;

                 this.flp_addStudent.Controls.Add(new UcAddStudent(sname, sid, sSec, sSelect));

            }


        }

        private void btn_ViewGroup_Go_Click(object sender, EventArgs e)
        {
            string semester = cmb_ViewGroup_Semester.Text.ToString();
            string grpnum = txt_ViewGroup_GroupNumber.Text.ToString();
            tb_group tbg = new tb_group();
            db_accountDataContext db = new db_accountDataContext();
            var prods = from p in db.tb_groups
                where p.grp_semester.Contains(semester)
                where p.grp_groupNumber.Contains(grpnum)
                select p;
            foreach (var a in prods)
            {
                
                txt_ViewGroup_GroupName.Text = a.grp_groupName;
                txt_ViewGroup_ProjectTitle.Text = a.grp_projectTitle;
                txt_ViewGroup_NumberOfMember.Text = a.grp_NumberOfMember.ToString();
              

            }
          
            db_accountDataContext db1 = new db_accountDataContext();
            var prods1 = from p in db1.tb_groupMembers
                where p.grpm_semester.Contains(semester)
                where p.grpm_groupNumber.Contains(grpnum)
                select p;
            foreach (var a in prods1)
            {
                string name = a.grpm_stdName;
                string id = a.grpm_stdId;
               
                string section = a.grpm_section;
                string part = a.grpm_stdPart;
                string mark = a.grpm_stdMark.ToString();
              

                this.flw_ViewGroup.Controls.Add(new UserControl_ViewGroup(name, id, section, part, mark));

            }
        }

        private void btn_Viva_Go_Click(object sender, EventArgs e)
        {
            string semester = cmb_Viva_Semester.Text.ToString();
            string grpNumber = txt_Viva_GroupNumber.Text.ToString();
            // MessageBox.Show(semester);
            db_accountDataContext db = new db_accountDataContext();
            var prods = from p in db.tb_groups

                where p.grp_semester.Contains(semester)
                where p.grp_groupNumber.Contains(grpNumber)
                select p;



            var pord = from q in db.tb_groupMembers

                where q.grpm_semester.Contains(semester)
                where q.grpm_groupNumber.Contains(grpNumber)
                select q;


            foreach (var a in prods)
            {
                string groupname = a.grp_groupName;
                string projecttitle = a.grp_projectTitle;


                // this.flp_show_sec.Controls.Add(new Uc_ShowSection(secstudentnum, secstudentid, secstudentsec, secingroup));
                txt_Viva_GroupName.Text = groupname;
                txt_Viva_ProjectTitle.Text = projecttitle;
            }

            foreach (var b in pord)
            {
                string stuname = b.grpm_stdName;
                string stuid = b.grpm_stdId;


                this.flw_Viva.Controls.Add(new UserControl_Viva(stuname, stuid));
                // txt_viva_name1.Text = stuname;
                // txt_viva_id1.Text = stuid;
            }
        }

        private void btn_ShowSections_Go_Click(object sender, EventArgs e)
        {
            flp_show_sec.AutoScroll = true;
            string semester = cmb_ShowSections_SemesterChooser.Text.ToString();
            string section = cmb_ShowSections_SectionChooser.Text.ToString();
            // MessageBox.Show(semester);
            db_accountDataContext db = new db_accountDataContext();
            var prods = from p in db.tb_sections
                where p.sec_semester.Contains(semester)
                where p.sec_st_section.Contains(section)
                select p;


            foreach (var a in prods)
            {
                string secstudentnum = a.sec_st_name;
                string secstudentid = a.sec_st_id;
                string secstudentsec = a.sec_st_section;
                string secingroup = a.sec_inGroup;

                this.flp_show_sec.Controls.Add(new Uc_ShowSection(secstudentnum, secstudentid, secstudentsec, secingroup));
                //txt_Viva_GroupName.Text = secstudentnum;
            }
        }

        private void btn_EditGroup_AddMember_Click(object sender, EventArgs e)
        {
            HideAllPanel();
            pnl_AddStudent.Show();
        }

        private void btn_EditGroup_Go_Click(object sender, EventArgs e)
        {
            string semester = cmb_EditGroup_SemesterChooser.Text.ToString();
            string grpno = txt_EditGroup_GroupNo.Text.ToString();

            db_accountDataContext db = new db_accountDataContext();
            var prods = from p in db.tb_groups
                where p.grp_semester.Contains(semester)
                where p.grp_groupNumber.Contains(grpno)
                select p;

            var prod = from q in db.tb_groupMembers
                where q.grpm_semester.Contains(semester)
                where q.grpm_groupNumber.Contains(grpno)
                select q;




            foreach (var a in prods)
            {
                string grpname = a.grp_groupName;
                string projecttitle = a.grp_projectTitle;
                string noofmem = a.grp_NumberOfMember.ToString();


                //this.flp_addStudent.Controls.Add(new UcAddStudent(sname, sid, sSec, sSelect));
                txt_EditGroup_GroupName.Text = grpname;
                txt_EditGroup_ProjectTitle.Text = projecttitle;
                txt_EditGroup_NumberOfMember.Text = noofmem;
            }

            foreach (var b in prod)
            {
                string stuname = b.grpm_stdName;
                string stuid = b.grpm_stdId;
                string stusec = b.grpm_section;
                string stupart = b.grpm_stdPart;

                this.flp_editgroup.Controls.Add(new UcEditGroup(stuname, stuid, stusec, stupart));

            }

        }


        //private UcAddStudent s1;

        public void btn_AddStudent_Save_Click(object sender, EventArgs e)
        {
            //foreach (Control s in flp_addStudent.Controls)
            //{

            //    //if (s.Name=="")
            //  //  {
            //        MessageBox.Show(s.Name);
            //  //  }
            //    // if()
            //    //if(s)
            //    //if (s.Contains())
            //    // {
            //    //     MessageBox.Show(label1.Text.ToString());
            //    // }
            //    // else
            //    //  MessageBox.Show("what");
            //}



            foreach (string[] c in DataClass.CreateGroupAddStudent)
            {
                fl_CreateGroup.Controls.Add(new UcCreateGroup(c[0], c[1], c[2], c[3]));
            }

            HideAllPanel();
            pnl_CreateGroup.Show();

        }

        int move;
        int movex;
        int movey;

        private void pnl_Top_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            movex = e.X;
            movey = e.Y;
        }

        private void pnl_Top_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movex, MousePosition.Y - movey);
            }
        }

        private void pnl_Top_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void cmb_ImportSection_SemesterChooser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_ImportSection_Section.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_ImportSection_Section_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_ImportSection_ImportSection.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_CreateGroup_GroupNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_CreateGroup_SemesterChooser.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void cmb_CreateGroup_SemesterChooser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_CreateGroup_GroupName.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_CreateGroup_GroupName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_CreateGroup_ProjectTitle.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_CreateGroup_ProjectTitle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_CreateGroup_NumberOfMember.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_CreateGroup_NumberOfMember_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_CreateGroup_AddMember.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void cmb_CourseChooser_ChooseSubject_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_CourseChooser_Go.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void cmb_ShowSections_SemesterChooser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_ShowSections_SectionChooser.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void cmb_ShowSections_SectionChooser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_ShowSections_Go.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void cmb_ShowGroups_SemesterChoose_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_ShowGroups_Go.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_ViewGroup_GroupNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_ViewGroup_Semester.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void cmb_ViewGroup_Semester_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_ViewGroup_Go.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_EditGroup_GroupNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_EditGroup_SemesterChooser.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void cmb_EditGroup_SemesterChooser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_EditGroup_Go.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_Viva_GroupNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_Viva_Semester.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void cmb_Viva_Semester_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Viva_Go.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void cmb_AddStudent_SemesterChooser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_AddStudent_SectionChooser.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void cmb_AddStudent_SectionChooser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_AddStudent_Go.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_AddTopic_topic_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_AddTopic_Ok.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void btn_Editroup_Save_Click(object sender, EventArgs e)
        {
            foreach (string[] V1 in DataClass.CreateGroupTemporary)
            {
                string ax = V1[0];
                string bx = V1[1];
                string cx = V1[2];
                string dx = V1[3];
                // MessageBox.Show(V1[1]);
                string GroupName = txt_CreateGroup_GroupName.Text.ToString();
                string GroupNumber = txt_CreateGroup_GroupNumber.Text.ToString();
                int NoOfMember = int.Parse(txt_CreateGroup_NumberOfMember.Text);
                string ProjectTitle = txt_CreateGroup_ProjectTitle.Text.ToString();
                string semester = cmb_CreateGroup_SemesterChooser.Text.ToString();
                string subject = "java";
                string username = "aaaa";

                db_accountDataContext db = new db_accountDataContext();
                tb_groupMember acc = new tb_groupMember();
                acc.grpm_stdName = ax;
                acc.grpm_stdId = bx;
                acc.grpm_section = cx;
                acc.grpm_stdPart = dx;
                acc.grpm_stdMark = 0;
                acc.grpm_groupNumber = GroupNumber;
                acc.grpm_subject = subject;
                acc.grpm_semester = semester;
                acc.grpm_username = username;
                db.tb_groupMembers.InsertOnSubmit(acc);
                db.SubmitChanges();


                db_accountDataContext db1 = new db_accountDataContext();
                tb_group acc1 = new tb_group();
                acc1.grp_groupNumber = GroupNumber;
                acc1.grp_groupName = GroupName;
                acc1.grp_projectTitle = ProjectTitle;
                acc1.grp_NumberOfMember = NoOfMember;
                acc1.grp_semester = semester;
                acc1.grp_subject = subject;
                acc1.grp_userName = username;
                db1.tb_groups.InsertOnSubmit(acc1);
                db1.SubmitChanges();


            }
        }

        private void pnl_Top_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_viva_save_Click(object sender, EventArgs e)
        {
            foreach (int[] V1 in DataClass.CreateVivaTemporary)
            {
                int a = V1[0];
                int ax = a;
                db_accountDataContext db = new db_accountDataContext();
                tb_groupMember acc = new tb_groupMember();
                acc.grpm_stdMark = ax;
                //MessageBox.Show(ax.ToString());
               // db.tb_groupMembers.InsertOnSubmit(acc);
               // db.SubmitChanges();
                MessageBox.Show("Inserted");
            }
        }

        }
    }

