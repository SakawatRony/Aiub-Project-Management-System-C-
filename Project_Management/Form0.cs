using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;

namespace Project_Management
{
    public partial class Form0 : Form
    {
        private string temporaryPassword;

        void HideAllPanel2()
        {
            pnl_Signup.Hide();
            pnl_ForgotPass.Hide();
            pnl_Login.Hide();
        }
        
        
        public Form0()
        {
            InitializeComponent();
            HideAllPanel2();
            pnl_Login.Show();
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

        private void btn_Login_CreateAccount_Click(object sender, EventArgs e)
        {
            //HideAllPanel2();
            pnl_Login.Hide();
            pnl_Signup.Show();
        }

        private void btn_createAccount_cancel_Click(object sender, EventArgs e)
        {
            pnl_Signup.Hide();
            pnl_Login.Show();
            
        }

        private void btn_forgetPass_back_Click(object sender, EventArgs e)
        {
            pnl_ForgotPass.Hide();
            pnl_Login.Show();
        }

        private void btn_forgetPass_signUp_Click(object sender, EventArgs e)
        {
            pnl_ForgotPass.Hide();
            pnl_Signup.Show();
        }

        private void btn_login_clickHere_Click(object sender, EventArgs e)
        {
            
            pnl_Login.Hide();
            pnl_ForgotPass.Show();
        }

        private void btn_Login_LogIn_Click(object sender, EventArgs e)
        {


            //this.Hide();
         //  Form1 f2 = new Form1();
          // f2.ShowDialog();
            
            
            
            
            ////rony//
            String lgn_pass = txt_Login_Password.Text;
            String lgn_user_name = txt_Login_Username.Text;
            //// String access;
            try
            {
                db_accountDataContext db = new db_accountDataContext();
                tb_account acc = db.tb_accounts.SingleOrDefault(x => x.ac_username == lgn_user_name);
                 if ((lgn_user_name == acc.ac_username) && (lgn_user_name == acc.ac_password))
                if ((acc.ac_username == lgn_user_name) && (acc.ac_password == lgn_pass))
                {
                    this.Hide();
                    Form1 f2 = new Form1();
                    f2.ShowDialog();
                    // db.SubmitChanges();
                }
                else
                {
                    MessageBox.Show("Invalied User Name or Password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalied User Name or Password");
            }
        }

        private void btn_forgetPass_resetPassword_Click(object sender, EventArgs e)
        {


            String Given_Email = txtbox_forgetPass_email.Text;
            // String access;
            try
            {
                db_accountDataContext db = new db_accountDataContext();
                tb_account acc = db.tb_accounts.SingleOrDefault(x => x.ac_email == Given_Email);
                // if ((lgn_user_name == acc.ac_username) && (lgn_user_name == acc.ac_password))
                if (acc.ac_email == Given_Email)
                {
                    temporaryPassword=acc.ac_password;
                    emailSendStart();
                }
                else
                {
                    MessageBox.Show("Email Address Did not Matched");
                    txtbox_forgetPass_email.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Email Address Did not Matched");
            }
            
              
         
        }


        public void emailSendStart()
        {

            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("aiubprojectmanagement@gmail.com", "trkk12345");
                MailMessage msg = new MailMessage();
                msg.To.Add(txtbox_forgetPass_email.Text);
                msg.From = new MailAddress("aiubprojectmanagement@gmail.com");
                msg.Subject = "APM Reset password";
                msg.Body = temporaryPassword;
                client.Send(msg);
                MessageBox.Show("Password has been sent Successfully!!!");
                txtbox_forgetPass_email.Text = "";
                pnl_ForgotPass.Hide();
                pnl_Login.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error has been Occured :-( ");
                txtbox_forgetPass_email.Text = "";
            }


        }

        private void btn_createAccount_signup_Click(object sender, EventArgs e)
        {
            //rony//
            String name = txt_CreateAccount_Name.Text;
            String email = txt_CreateAccount_Email.Text;
            String pass = txt_CreateAccount_Password.Text;
            String re_pass = txt_CreateAccount_ReEnterPassword.Text;
            String user_name = txt_CreateAccount_Username.Text;
            if (pass == re_pass)
            {
                if (name != null && email != null && pass != null && user_name != null && (email.Contains("@gmail.com") || email.Contains("@aiub.edu") || email.Contains("@yahoo.com")))
                {
                    if ((user_name.Length >= 4) && (pass.Length >= 4))
                    {
                        db_accountDataContext db1 = new db_accountDataContext();
                        tb_account acc1 = db1.tb_accounts.SingleOrDefault(x => x.ac_email == email);
                        //    // if ((lgn_user_name == acc.ac_username) && (lgn_user_name == acc.ac_password))
                            if (db1.tb_accounts.SingleOrDefault(x => x.ac_email == email)!=null)
                           {
                                MessageBox.Show("Email Address is already taken");
                           }
                            else
                            {
                                db_accountDataContext db = new db_accountDataContext();
                                tb_account acc = new tb_account();
                                acc.ac_name = txt_CreateAccount_Name.Text;
                                acc.ac_email = txt_CreateAccount_Email.Text;
                                acc.ac_password = txt_CreateAccount_Password.Text;
                                acc.ac_username = txt_CreateAccount_Username.Text;
                                db.tb_accounts.InsertOnSubmit(acc);
                                try
                                {
                                    db.SubmitChanges();
                                    MessageBox.Show("Sign Up Successfully");
                                    txt_CreateAccount_Name.Text = "";
                                    txt_CreateAccount_Email.Text = "";
                                    txt_CreateAccount_Password.Text = "";
                                    txt_CreateAccount_ReEnterPassword.Text = "";
                                    txt_CreateAccount_Username.Text = "";
                                    pnl_Signup.Hide();
                                    pnl_ForgotPass.Hide();
                                    pnl_Login.Show();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Error;Please Fill the blank fields & try again");
                                }
                            }

                        


                        //tb_account acc = db.tb_accounts.SingleOrDefault
                    }
                    else
                    {
                        MessageBox.Show("You should follow the SignUp Rules");
                    }
                }
                else
                {
                    MessageBox.Show("Please Fill the blank field & try again");
                }

            }
            else
            {
                MessageBox.Show("Password doesn't match");
            }
        }

        private void chk_Login_PasswordMode_CheckedChanged(object sender, EventArgs e)
        {
            //rony//
            if (chk_Login_PasswordMode.Checked)
            {
                txt_Login_Password.isPassword = true;
            }
            else
            {
                txt_Login_Password.isPassword = false;
            }
            //rony//
        }

        private void txt_Login_Username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Login_Password.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_Login_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Login_LogIn.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_CreateAccount_Name_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_CreateAccount_Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_CreateAccount_Email.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_CreateAccount_Email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_CreateAccount_Username.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_CreateAccount_Username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_CreateAccount_Password.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_CreateAccount_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_CreateAccount_ReEnterPassword.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_CreateAccount_ReEnterPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_createAccount_signup.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        int move;
        int movex;
        int movey;

        private void pnl_Login_Top_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            movex = e.X;
            movey = e.Y;
        }

        private void pnl_Login_Top_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movex, MousePosition.Y - movey);
            }
        }

        private void pnl_Login_Top_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        
        private void btn_Login_LogIn_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void pnl_Login_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
           
        }

        private void txtbox_forgetPass_email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ////btn_forgetPass_resetPassword.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

       
    }
}
