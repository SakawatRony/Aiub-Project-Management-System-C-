namespace Project_Management
{
    partial class Form0
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form0));
            this.pnl_Login_Top = new System.Windows.Forms.Panel();
            this.lbl_ProjectTitle1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_Minus = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.pnl_Signup = new System.Windows.Forms.Panel();
            this.txt_CreateAccount_ReEnterPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_CreateAccount_Password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_CreateAccount_Username = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_CreateAccount_Email = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_CreateAccount_Name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbl_CreateAccount_UserNameTip = new System.Windows.Forms.Label();
            this.btn_createAccount_signup = new System.Windows.Forms.Button();
            this.btn_createAccount_cancel = new System.Windows.Forms.Button();
            this.btn_CreateAccount_Terms = new System.Windows.Forms.Button();
            this.lbl_CreateAccount_Name = new System.Windows.Forms.Label();
            this.lbl_CreateAccount_Email = new System.Windows.Forms.Label();
            this.lbl_CreateAccount_Username = new System.Windows.Forms.Label();
            this.lbl_CreateAccount_Password = new System.Windows.Forms.Label();
            this.lbl_CreateAccount_ReEnterPassword = new System.Windows.Forms.Label();
            this.lbl_CreateAccount_Condition = new System.Windows.Forms.Label();
            this.lbl_CreateAccount_PasswordTip = new System.Windows.Forms.Label();
            this.pnl_ForgotPass = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_forgetPass_password = new System.Windows.Forms.Label();
            this.txtbox_forgetPass_email = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lbl_forgetPass_notAmember = new System.Windows.Forms.Label();
            this.lbl_forgetPass_enterEmail = new System.Windows.Forms.Label();
            this.lbl_forgetPass_sendLink = new System.Windows.Forms.Label();
            this.lbl_forgetPass_forgetYour = new System.Windows.Forms.Label();
            this.btn_forgetPass_back = new System.Windows.Forms.Button();
            this.btn_forgetPass_resetPassword = new System.Windows.Forms.Button();
            this.btn_forgetPass_signUp = new System.Windows.Forms.Button();
            this.pnl_Login = new System.Windows.Forms.Panel();
            this.swt_Login_RememberMode1 = new Bunifu.Framework.UI.BunifuSwitch();
            this.lbl_Login_RememberMode = new System.Windows.Forms.Label();
            this.swt_Login_RememberMode = new Bunifu.Framework.UI.BunifuSwitch();
            this.chk_Login_PasswordMode = new System.Windows.Forms.CheckBox();
            this.txt_Login_Password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_Login_Username = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_login_clickHere = new System.Windows.Forms.Button();
            this.btn_Login_LogIn = new System.Windows.Forms.Button();
            this.btn_Login_CreateAccount = new System.Windows.Forms.Button();
            this.lbl_Login_ForgotPassword = new System.Windows.Forms.Label();
            this.lbl_Login_Password = new System.Windows.Forms.Label();
            this.lbl_Login_Username = new System.Windows.Forms.Label();
            this.lbl_Login_ProjectTitle = new System.Windows.Forms.Label();
            this.picBox_logo = new System.Windows.Forms.PictureBox();
            this.pnl_Login_Top.SuspendLayout();
            this.pnl_Signup.SuspendLayout();
            this.pnl_ForgotPass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Login_Top
            // 
            this.pnl_Login_Top.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnl_Login_Top.Controls.Add(this.lbl_ProjectTitle1);
            this.pnl_Login_Top.Controls.Add(this.btn_Minus);
            this.pnl_Login_Top.Controls.Add(this.btn_Exit);
            this.pnl_Login_Top.Location = new System.Drawing.Point(0, -1);
            this.pnl_Login_Top.Name = "pnl_Login_Top";
            this.pnl_Login_Top.Size = new System.Drawing.Size(893, 31);
            this.pnl_Login_Top.TabIndex = 0;
            this.pnl_Login_Top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Login_Top_MouseDown);
            this.pnl_Login_Top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Login_Top_MouseMove);
            this.pnl_Login_Top.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Login_Top_MouseUp);
            // 
            // lbl_ProjectTitle1
            // 
            this.lbl_ProjectTitle1.Font = new System.Drawing.Font("Sitka Small", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProjectTitle1.ForeColor = System.Drawing.Color.White;
            this.lbl_ProjectTitle1.Image = global::Project_Management.Properties.Resources.projectLogoSmall;
            this.lbl_ProjectTitle1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_ProjectTitle1.Location = new System.Drawing.Point(276, 2);
            this.lbl_ProjectTitle1.Name = "lbl_ProjectTitle1";
            this.lbl_ProjectTitle1.Size = new System.Drawing.Size(315, 25);
            this.lbl_ProjectTitle1.TabIndex = 8;
            this.lbl_ProjectTitle1.Text = "AIUB PROJECT MANAGEMENT";
            this.lbl_ProjectTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_Minus
            // 
            this.btn_Minus.FlatAppearance.BorderSize = 0;
            this.btn_Minus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_Minus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minus.ForeColor = System.Drawing.Color.White;
            this.btn_Minus.Image = global::Project_Management.Properties.Resources.icon_Minus_BW;
            this.btn_Minus.Location = new System.Drawing.Point(811, 1);
            this.btn_Minus.Name = "btn_Minus";
            this.btn_Minus.Size = new System.Drawing.Size(28, 28);
            this.btn_Minus.TabIndex = 10;
            this.btn_Minus.UseVisualStyleBackColor = true;
            this.btn_Minus.Click += new System.EventHandler(this.btn_Minus_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Image = global::Project_Management.Properties.Resources.icon_Exit_BW;
            this.btn_Exit.Location = new System.Drawing.Point(843, 1);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(28, 28);
            this.btn_Exit.TabIndex = 9;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // pnl_Signup
            // 
            this.pnl_Signup.Controls.Add(this.txt_CreateAccount_ReEnterPassword);
            this.pnl_Signup.Controls.Add(this.txt_CreateAccount_Password);
            this.pnl_Signup.Controls.Add(this.txt_CreateAccount_Username);
            this.pnl_Signup.Controls.Add(this.txt_CreateAccount_Email);
            this.pnl_Signup.Controls.Add(this.txt_CreateAccount_Name);
            this.pnl_Signup.Controls.Add(this.lbl_CreateAccount_UserNameTip);
            this.pnl_Signup.Controls.Add(this.btn_createAccount_signup);
            this.pnl_Signup.Controls.Add(this.btn_createAccount_cancel);
            this.pnl_Signup.Controls.Add(this.btn_CreateAccount_Terms);
            this.pnl_Signup.Controls.Add(this.lbl_CreateAccount_Name);
            this.pnl_Signup.Controls.Add(this.lbl_CreateAccount_Email);
            this.pnl_Signup.Controls.Add(this.lbl_CreateAccount_Username);
            this.pnl_Signup.Controls.Add(this.lbl_CreateAccount_Password);
            this.pnl_Signup.Controls.Add(this.lbl_CreateAccount_ReEnterPassword);
            this.pnl_Signup.Controls.Add(this.lbl_CreateAccount_Condition);
            this.pnl_Signup.Controls.Add(this.lbl_CreateAccount_PasswordTip);
            this.pnl_Signup.Location = new System.Drawing.Point(2, 33);
            this.pnl_Signup.Name = "pnl_Signup";
            this.pnl_Signup.Size = new System.Drawing.Size(879, 524);
            this.pnl_Signup.TabIndex = 1;
            // 
            // txt_CreateAccount_ReEnterPassword
            // 
            this.txt_CreateAccount_ReEnterPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.txt_CreateAccount_ReEnterPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.txt_CreateAccount_ReEnterPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CreateAccount_ReEnterPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CreateAccount_ReEnterPassword.ForeColor = System.Drawing.Color.White;
            this.txt_CreateAccount_ReEnterPassword.HintForeColor = System.Drawing.Color.White;
            this.txt_CreateAccount_ReEnterPassword.HintText = "";
            this.txt_CreateAccount_ReEnterPassword.isPassword = false;
            this.txt_CreateAccount_ReEnterPassword.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txt_CreateAccount_ReEnterPassword.LineIdleColor = System.Drawing.Color.White;
            this.txt_CreateAccount_ReEnterPassword.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txt_CreateAccount_ReEnterPassword.LineThickness = 1;
            this.txt_CreateAccount_ReEnterPassword.Location = new System.Drawing.Point(364, 307);
            this.txt_CreateAccount_ReEnterPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_CreateAccount_ReEnterPassword.Name = "txt_CreateAccount_ReEnterPassword";
            this.txt_CreateAccount_ReEnterPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_CreateAccount_ReEnterPassword.Size = new System.Drawing.Size(292, 31);
            this.txt_CreateAccount_ReEnterPassword.TabIndex = 54;
            this.txt_CreateAccount_ReEnterPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_CreateAccount_ReEnterPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_CreateAccount_ReEnterPassword_KeyDown);
            // 
            // txt_CreateAccount_Password
            // 
            this.txt_CreateAccount_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.txt_CreateAccount_Password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.txt_CreateAccount_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CreateAccount_Password.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CreateAccount_Password.ForeColor = System.Drawing.Color.White;
            this.txt_CreateAccount_Password.HintForeColor = System.Drawing.Color.White;
            this.txt_CreateAccount_Password.HintText = "";
            this.txt_CreateAccount_Password.isPassword = false;
            this.txt_CreateAccount_Password.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txt_CreateAccount_Password.LineIdleColor = System.Drawing.Color.White;
            this.txt_CreateAccount_Password.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txt_CreateAccount_Password.LineThickness = 1;
            this.txt_CreateAccount_Password.Location = new System.Drawing.Point(364, 242);
            this.txt_CreateAccount_Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_CreateAccount_Password.Name = "txt_CreateAccount_Password";
            this.txt_CreateAccount_Password.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_CreateAccount_Password.Size = new System.Drawing.Size(292, 31);
            this.txt_CreateAccount_Password.TabIndex = 53;
            this.txt_CreateAccount_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_CreateAccount_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_CreateAccount_Password_KeyDown);
            // 
            // txt_CreateAccount_Username
            // 
            this.txt_CreateAccount_Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.txt_CreateAccount_Username.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.txt_CreateAccount_Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CreateAccount_Username.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CreateAccount_Username.ForeColor = System.Drawing.Color.White;
            this.txt_CreateAccount_Username.HintForeColor = System.Drawing.Color.White;
            this.txt_CreateAccount_Username.HintText = "";
            this.txt_CreateAccount_Username.isPassword = false;
            this.txt_CreateAccount_Username.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txt_CreateAccount_Username.LineIdleColor = System.Drawing.Color.White;
            this.txt_CreateAccount_Username.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txt_CreateAccount_Username.LineThickness = 1;
            this.txt_CreateAccount_Username.Location = new System.Drawing.Point(364, 175);
            this.txt_CreateAccount_Username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_CreateAccount_Username.Name = "txt_CreateAccount_Username";
            this.txt_CreateAccount_Username.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_CreateAccount_Username.Size = new System.Drawing.Size(292, 31);
            this.txt_CreateAccount_Username.TabIndex = 52;
            this.txt_CreateAccount_Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_CreateAccount_Username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_CreateAccount_Username_KeyDown);
            // 
            // txt_CreateAccount_Email
            // 
            this.txt_CreateAccount_Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.txt_CreateAccount_Email.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.txt_CreateAccount_Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CreateAccount_Email.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CreateAccount_Email.ForeColor = System.Drawing.Color.White;
            this.txt_CreateAccount_Email.HintForeColor = System.Drawing.Color.White;
            this.txt_CreateAccount_Email.HintText = "";
            this.txt_CreateAccount_Email.isPassword = false;
            this.txt_CreateAccount_Email.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txt_CreateAccount_Email.LineIdleColor = System.Drawing.Color.White;
            this.txt_CreateAccount_Email.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txt_CreateAccount_Email.LineThickness = 1;
            this.txt_CreateAccount_Email.Location = new System.Drawing.Point(364, 110);
            this.txt_CreateAccount_Email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_CreateAccount_Email.Name = "txt_CreateAccount_Email";
            this.txt_CreateAccount_Email.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_CreateAccount_Email.Size = new System.Drawing.Size(292, 31);
            this.txt_CreateAccount_Email.TabIndex = 51;
            this.txt_CreateAccount_Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_CreateAccount_Email.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_CreateAccount_Email_KeyDown);
            // 
            // txt_CreateAccount_Name
            // 
            this.txt_CreateAccount_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.txt_CreateAccount_Name.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.txt_CreateAccount_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CreateAccount_Name.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CreateAccount_Name.ForeColor = System.Drawing.Color.White;
            this.txt_CreateAccount_Name.HintForeColor = System.Drawing.Color.White;
            this.txt_CreateAccount_Name.HintText = "";
            this.txt_CreateAccount_Name.isPassword = false;
            this.txt_CreateAccount_Name.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txt_CreateAccount_Name.LineIdleColor = System.Drawing.Color.White;
            this.txt_CreateAccount_Name.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txt_CreateAccount_Name.LineThickness = 1;
            this.txt_CreateAccount_Name.Location = new System.Drawing.Point(364, 43);
            this.txt_CreateAccount_Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_CreateAccount_Name.Name = "txt_CreateAccount_Name";
            this.txt_CreateAccount_Name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_CreateAccount_Name.Size = new System.Drawing.Size(292, 31);
            this.txt_CreateAccount_Name.TabIndex = 50;
            this.txt_CreateAccount_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_CreateAccount_Name.OnValueChanged += new System.EventHandler(this.txt_CreateAccount_Name_OnValueChanged);
            this.txt_CreateAccount_Name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_CreateAccount_Name_KeyDown);
            // 
            // lbl_CreateAccount_UserNameTip
            // 
            this.lbl_CreateAccount_UserNameTip.AutoSize = true;
            this.lbl_CreateAccount_UserNameTip.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CreateAccount_UserNameTip.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_CreateAccount_UserNameTip.Location = new System.Drawing.Point(363, 213);
            this.lbl_CreateAccount_UserNameTip.Name = "lbl_CreateAccount_UserNameTip";
            this.lbl_CreateAccount_UserNameTip.Size = new System.Drawing.Size(193, 17);
            this.lbl_CreateAccount_UserNameTip.TabIndex = 49;
            this.lbl_CreateAccount_UserNameTip.Text = "Tip : Use at least 4 characters";
            // 
            // btn_createAccount_signup
            // 
            this.btn_createAccount_signup.AutoEllipsis = true;
            this.btn_createAccount_signup.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_createAccount_signup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_createAccount_signup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_createAccount_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_createAccount_signup.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createAccount_signup.ForeColor = System.Drawing.Color.White;
            this.btn_createAccount_signup.Image = global::Project_Management.Properties.Resources.icon_Signup_CLR;
            this.btn_createAccount_signup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_createAccount_signup.Location = new System.Drawing.Point(262, 427);
            this.btn_createAccount_signup.Name = "btn_createAccount_signup";
            this.btn_createAccount_signup.Size = new System.Drawing.Size(103, 36);
            this.btn_createAccount_signup.TabIndex = 48;
            this.btn_createAccount_signup.Text = "Sign Up";
            this.btn_createAccount_signup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_createAccount_signup.UseVisualStyleBackColor = false;
            this.btn_createAccount_signup.Click += new System.EventHandler(this.btn_createAccount_signup_Click);
            // 
            // btn_createAccount_cancel
            // 
            this.btn_createAccount_cancel.AutoEllipsis = true;
            this.btn_createAccount_cancel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_createAccount_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_createAccount_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_createAccount_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_createAccount_cancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createAccount_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_createAccount_cancel.Image = global::Project_Management.Properties.Resources.icon_Cancel2_CLR;
            this.btn_createAccount_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_createAccount_cancel.Location = new System.Drawing.Point(515, 427);
            this.btn_createAccount_cancel.Name = "btn_createAccount_cancel";
            this.btn_createAccount_cancel.Size = new System.Drawing.Size(104, 36);
            this.btn_createAccount_cancel.TabIndex = 47;
            this.btn_createAccount_cancel.Text = "Cancel";
            this.btn_createAccount_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_createAccount_cancel.UseVisualStyleBackColor = false;
            this.btn_createAccount_cancel.Click += new System.EventHandler(this.btn_createAccount_cancel_Click);
            // 
            // btn_CreateAccount_Terms
            // 
            this.btn_CreateAccount_Terms.AutoEllipsis = true;
            this.btn_CreateAccount_Terms.BackColor = System.Drawing.Color.Transparent;
            this.btn_CreateAccount_Terms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CreateAccount_Terms.FlatAppearance.BorderSize = 0;
            this.btn_CreateAccount_Terms.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_CreateAccount_Terms.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_CreateAccount_Terms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CreateAccount_Terms.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreateAccount_Terms.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_CreateAccount_Terms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CreateAccount_Terms.Location = new System.Drawing.Point(475, 358);
            this.btn_CreateAccount_Terms.Name = "btn_CreateAccount_Terms";
            this.btn_CreateAccount_Terms.Size = new System.Drawing.Size(141, 36);
            this.btn_CreateAccount_Terms.TabIndex = 46;
            this.btn_CreateAccount_Terms.Text = "Terms of services";
            this.btn_CreateAccount_Terms.UseVisualStyleBackColor = false;
            // 
            // lbl_CreateAccount_Name
            // 
            this.lbl_CreateAccount_Name.AutoSize = true;
            this.lbl_CreateAccount_Name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CreateAccount_Name.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_CreateAccount_Name.Location = new System.Drawing.Point(184, 53);
            this.lbl_CreateAccount_Name.Name = "lbl_CreateAccount_Name";
            this.lbl_CreateAccount_Name.Size = new System.Drawing.Size(58, 21);
            this.lbl_CreateAccount_Name.TabIndex = 45;
            this.lbl_CreateAccount_Name.Text = "Name";
            // 
            // lbl_CreateAccount_Email
            // 
            this.lbl_CreateAccount_Email.AutoSize = true;
            this.lbl_CreateAccount_Email.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CreateAccount_Email.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_CreateAccount_Email.Location = new System.Drawing.Point(184, 120);
            this.lbl_CreateAccount_Email.Name = "lbl_CreateAccount_Email";
            this.lbl_CreateAccount_Email.Size = new System.Drawing.Size(51, 21);
            this.lbl_CreateAccount_Email.TabIndex = 44;
            this.lbl_CreateAccount_Email.Text = "Email";
            // 
            // lbl_CreateAccount_Username
            // 
            this.lbl_CreateAccount_Username.AutoSize = true;
            this.lbl_CreateAccount_Username.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CreateAccount_Username.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_CreateAccount_Username.Location = new System.Drawing.Point(184, 185);
            this.lbl_CreateAccount_Username.Name = "lbl_CreateAccount_Username";
            this.lbl_CreateAccount_Username.Size = new System.Drawing.Size(94, 21);
            this.lbl_CreateAccount_Username.TabIndex = 43;
            this.lbl_CreateAccount_Username.Text = "User Name";
            // 
            // lbl_CreateAccount_Password
            // 
            this.lbl_CreateAccount_Password.AutoSize = true;
            this.lbl_CreateAccount_Password.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CreateAccount_Password.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_CreateAccount_Password.Location = new System.Drawing.Point(184, 252);
            this.lbl_CreateAccount_Password.Name = "lbl_CreateAccount_Password";
            this.lbl_CreateAccount_Password.Size = new System.Drawing.Size(82, 21);
            this.lbl_CreateAccount_Password.TabIndex = 42;
            this.lbl_CreateAccount_Password.Text = "Password";
            // 
            // lbl_CreateAccount_ReEnterPassword
            // 
            this.lbl_CreateAccount_ReEnterPassword.AutoSize = true;
            this.lbl_CreateAccount_ReEnterPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CreateAccount_ReEnterPassword.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_CreateAccount_ReEnterPassword.Location = new System.Drawing.Point(184, 317);
            this.lbl_CreateAccount_ReEnterPassword.Name = "lbl_CreateAccount_ReEnterPassword";
            this.lbl_CreateAccount_ReEnterPassword.Size = new System.Drawing.Size(153, 21);
            this.lbl_CreateAccount_ReEnterPassword.TabIndex = 41;
            this.lbl_CreateAccount_ReEnterPassword.Text = "Re-enter Password";
            // 
            // lbl_CreateAccount_Condition
            // 
            this.lbl_CreateAccount_Condition.AutoSize = true;
            this.lbl_CreateAccount_Condition.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CreateAccount_Condition.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_CreateAccount_Condition.Location = new System.Drawing.Point(184, 365);
            this.lbl_CreateAccount_Condition.Name = "lbl_CreateAccount_Condition";
            this.lbl_CreateAccount_Condition.Size = new System.Drawing.Size(311, 20);
            this.lbl_CreateAccount_Condition.TabIndex = 40;
            this.lbl_CreateAccount_Condition.Text = "*By submitting this form you are agreed to";
            // 
            // lbl_CreateAccount_PasswordTip
            // 
            this.lbl_CreateAccount_PasswordTip.AutoSize = true;
            this.lbl_CreateAccount_PasswordTip.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CreateAccount_PasswordTip.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_CreateAccount_PasswordTip.Location = new System.Drawing.Point(365, 280);
            this.lbl_CreateAccount_PasswordTip.Name = "lbl_CreateAccount_PasswordTip";
            this.lbl_CreateAccount_PasswordTip.Size = new System.Drawing.Size(193, 17);
            this.lbl_CreateAccount_PasswordTip.TabIndex = 39;
            this.lbl_CreateAccount_PasswordTip.Text = "Tip : Use at least 4 characters";
            // 
            // pnl_ForgotPass
            // 
            this.pnl_ForgotPass.Controls.Add(this.pictureBox1);
            this.pnl_ForgotPass.Controls.Add(this.lbl_forgetPass_password);
            this.pnl_ForgotPass.Controls.Add(this.txtbox_forgetPass_email);
            this.pnl_ForgotPass.Controls.Add(this.lbl_forgetPass_notAmember);
            this.pnl_ForgotPass.Controls.Add(this.lbl_forgetPass_enterEmail);
            this.pnl_ForgotPass.Controls.Add(this.lbl_forgetPass_sendLink);
            this.pnl_ForgotPass.Controls.Add(this.lbl_forgetPass_forgetYour);
            this.pnl_ForgotPass.Controls.Add(this.btn_forgetPass_back);
            this.pnl_ForgotPass.Controls.Add(this.btn_forgetPass_resetPassword);
            this.pnl_ForgotPass.Controls.Add(this.btn_forgetPass_signUp);
            this.pnl_ForgotPass.Location = new System.Drawing.Point(5, 36);
            this.pnl_ForgotPass.Name = "pnl_ForgotPass";
            this.pnl_ForgotPass.Size = new System.Drawing.Size(876, 521);
            this.pnl_ForgotPass.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_Management.Properties.Resources.icon_Email_CLR;
            this.pictureBox1.Location = new System.Drawing.Point(583, 268);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 23);
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_forgetPass_password
            // 
            this.lbl_forgetPass_password.AutoSize = true;
            this.lbl_forgetPass_password.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_forgetPass_password.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_forgetPass_password.Location = new System.Drawing.Point(302, 110);
            this.lbl_forgetPass_password.Name = "lbl_forgetPass_password";
            this.lbl_forgetPass_password.Size = new System.Drawing.Size(268, 56);
            this.lbl_forgetPass_password.TabIndex = 48;
            this.lbl_forgetPass_password.Text = "Password?";
            // 
            // txtbox_forgetPass_email
            // 
            this.txtbox_forgetPass_email.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.txtbox_forgetPass_email.BorderColorIdle = System.Drawing.Color.White;
            this.txtbox_forgetPass_email.BorderColorMouseHover = System.Drawing.Color.DodgerBlue;
            this.txtbox_forgetPass_email.BorderThickness = 2;
            this.txtbox_forgetPass_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_forgetPass_email.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_forgetPass_email.ForeColor = System.Drawing.Color.AliceBlue;
            this.txtbox_forgetPass_email.isPassword = false;
            this.txtbox_forgetPass_email.Location = new System.Drawing.Point(261, 258);
            this.txtbox_forgetPass_email.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_forgetPass_email.Name = "txtbox_forgetPass_email";
            this.txtbox_forgetPass_email.Size = new System.Drawing.Size(359, 44);
            this.txtbox_forgetPass_email.TabIndex = 47;
            this.txtbox_forgetPass_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbox_forgetPass_email.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbox_forgetPass_email_KeyDown);
            // 
            // lbl_forgetPass_notAmember
            // 
            this.lbl_forgetPass_notAmember.AutoSize = true;
            this.lbl_forgetPass_notAmember.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_forgetPass_notAmember.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_forgetPass_notAmember.Location = new System.Drawing.Point(330, 417);
            this.lbl_forgetPass_notAmember.Name = "lbl_forgetPass_notAmember";
            this.lbl_forgetPass_notAmember.Size = new System.Drawing.Size(133, 21);
            this.lbl_forgetPass_notAmember.TabIndex = 46;
            this.lbl_forgetPass_notAmember.Text = "Not a Member?";
            // 
            // lbl_forgetPass_enterEmail
            // 
            this.lbl_forgetPass_enterEmail.AutoSize = true;
            this.lbl_forgetPass_enterEmail.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_forgetPass_enterEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_forgetPass_enterEmail.Location = new System.Drawing.Point(276, 186);
            this.lbl_forgetPass_enterEmail.Name = "lbl_forgetPass_enterEmail";
            this.lbl_forgetPass_enterEmail.Size = new System.Drawing.Size(324, 23);
            this.lbl_forgetPass_enterEmail.TabIndex = 45;
            this.lbl_forgetPass_enterEmail.Text = "Enter your email address and we\'ll";
            // 
            // lbl_forgetPass_sendLink
            // 
            this.lbl_forgetPass_sendLink.AutoSize = true;
            this.lbl_forgetPass_sendLink.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_forgetPass_sendLink.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_forgetPass_sendLink.Location = new System.Drawing.Point(257, 212);
            this.lbl_forgetPass_sendLink.Name = "lbl_forgetPass_sendLink";
            this.lbl_forgetPass_sendLink.Size = new System.Drawing.Size(363, 23);
            this.lbl_forgetPass_sendLink.TabIndex = 44;
            this.lbl_forgetPass_sendLink.Text = "send you a link to reset your password.";
            // 
            // lbl_forgetPass_forgetYour
            // 
            this.lbl_forgetPass_forgetYour.AutoSize = true;
            this.lbl_forgetPass_forgetYour.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_forgetPass_forgetYour.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_forgetPass_forgetYour.Location = new System.Drawing.Point(293, 54);
            this.lbl_forgetPass_forgetYour.Name = "lbl_forgetPass_forgetYour";
            this.lbl_forgetPass_forgetYour.Size = new System.Drawing.Size(288, 56);
            this.lbl_forgetPass_forgetYour.TabIndex = 43;
            this.lbl_forgetPass_forgetYour.Text = "Forgot Your";
            // 
            // btn_forgetPass_back
            // 
            this.btn_forgetPass_back.AutoEllipsis = true;
            this.btn_forgetPass_back.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_forgetPass_back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_forgetPass_back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_forgetPass_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_forgetPass_back.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_forgetPass_back.ForeColor = System.Drawing.Color.White;
            this.btn_forgetPass_back.Image = global::Project_Management.Properties.Resources.icon_Cancel2_CLR1;
            this.btn_forgetPass_back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_forgetPass_back.Location = new System.Drawing.Point(538, 362);
            this.btn_forgetPass_back.Name = "btn_forgetPass_back";
            this.btn_forgetPass_back.Size = new System.Drawing.Size(82, 30);
            this.btn_forgetPass_back.TabIndex = 42;
            this.btn_forgetPass_back.Text = "Back";
            this.btn_forgetPass_back.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_forgetPass_back.UseVisualStyleBackColor = false;
            this.btn_forgetPass_back.Click += new System.EventHandler(this.btn_forgetPass_back_Click);
            // 
            // btn_forgetPass_resetPassword
            // 
            this.btn_forgetPass_resetPassword.AutoEllipsis = true;
            this.btn_forgetPass_resetPassword.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_forgetPass_resetPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_forgetPass_resetPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_forgetPass_resetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_forgetPass_resetPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_forgetPass_resetPassword.ForeColor = System.Drawing.Color.White;
            this.btn_forgetPass_resetPassword.Image = global::Project_Management.Properties.Resources.icon_Reset_CLR;
            this.btn_forgetPass_resetPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_forgetPass_resetPassword.Location = new System.Drawing.Point(264, 362);
            this.btn_forgetPass_resetPassword.Name = "btn_forgetPass_resetPassword";
            this.btn_forgetPass_resetPassword.Size = new System.Drawing.Size(162, 30);
            this.btn_forgetPass_resetPassword.TabIndex = 41;
            this.btn_forgetPass_resetPassword.Text = "Reset Password";
            this.btn_forgetPass_resetPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_forgetPass_resetPassword.UseVisualStyleBackColor = false;
            this.btn_forgetPass_resetPassword.Click += new System.EventHandler(this.btn_forgetPass_resetPassword_Click);
            // 
            // btn_forgetPass_signUp
            // 
            this.btn_forgetPass_signUp.AutoEllipsis = true;
            this.btn_forgetPass_signUp.BackColor = System.Drawing.Color.Transparent;
            this.btn_forgetPass_signUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_forgetPass_signUp.FlatAppearance.BorderSize = 0;
            this.btn_forgetPass_signUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_forgetPass_signUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_forgetPass_signUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_forgetPass_signUp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_forgetPass_signUp.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_forgetPass_signUp.Image = global::Project_Management.Properties.Resources.icon_Signup_CLR1;
            this.btn_forgetPass_signUp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_forgetPass_signUp.Location = new System.Drawing.Point(456, 408);
            this.btn_forgetPass_signUp.Name = "btn_forgetPass_signUp";
            this.btn_forgetPass_signUp.Size = new System.Drawing.Size(97, 38);
            this.btn_forgetPass_signUp.TabIndex = 40;
            this.btn_forgetPass_signUp.Text = "Sign Up";
            this.btn_forgetPass_signUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_forgetPass_signUp.UseVisualStyleBackColor = false;
            this.btn_forgetPass_signUp.Click += new System.EventHandler(this.btn_forgetPass_signUp_Click);
            // 
            // pnl_Login
            // 
            this.pnl_Login.Controls.Add(this.swt_Login_RememberMode1);
            this.pnl_Login.Controls.Add(this.lbl_Login_RememberMode);
            this.pnl_Login.Controls.Add(this.swt_Login_RememberMode);
            this.pnl_Login.Controls.Add(this.chk_Login_PasswordMode);
            this.pnl_Login.Controls.Add(this.txt_Login_Password);
            this.pnl_Login.Controls.Add(this.txt_Login_Username);
            this.pnl_Login.Controls.Add(this.btn_login_clickHere);
            this.pnl_Login.Controls.Add(this.btn_Login_LogIn);
            this.pnl_Login.Controls.Add(this.btn_Login_CreateAccount);
            this.pnl_Login.Controls.Add(this.lbl_Login_ForgotPassword);
            this.pnl_Login.Controls.Add(this.lbl_Login_Password);
            this.pnl_Login.Controls.Add(this.lbl_Login_Username);
            this.pnl_Login.Controls.Add(this.lbl_Login_ProjectTitle);
            this.pnl_Login.Controls.Add(this.picBox_logo);
            this.pnl_Login.Location = new System.Drawing.Point(2, 29);
            this.pnl_Login.Name = "pnl_Login";
            this.pnl_Login.Size = new System.Drawing.Size(879, 529);
            this.pnl_Login.TabIndex = 3;
            this.pnl_Login.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.pnl_Login_PreviewKeyDown);
            // 
            // swt_Login_RememberMode1
            // 
            this.swt_Login_RememberMode1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.swt_Login_RememberMode1.BorderRadius = 0;
            this.swt_Login_RememberMode1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.swt_Login_RememberMode1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.swt_Login_RememberMode1.Location = new System.Drawing.Point(305, 425);
            this.swt_Login_RememberMode1.Margin = new System.Windows.Forms.Padding(8);
            this.swt_Login_RememberMode1.Name = "swt_Login_RememberMode1";
            this.swt_Login_RememberMode1.Oncolor = System.Drawing.Color.DarkSlateGray;
            this.swt_Login_RememberMode1.Onoffcolor = System.Drawing.Color.DarkGray;
            this.swt_Login_RememberMode1.Size = new System.Drawing.Size(51, 19);
            this.swt_Login_RememberMode1.TabIndex = 141;
            this.swt_Login_RememberMode1.Textcolor = System.Drawing.Color.White;
            this.swt_Login_RememberMode1.Value = true;
            // 
            // lbl_Login_RememberMode
            // 
            this.lbl_Login_RememberMode.AutoSize = true;
            this.lbl_Login_RememberMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Login_RememberMode.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login_RememberMode.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbl_Login_RememberMode.Location = new System.Drawing.Point(362, 424);
            this.lbl_Login_RememberMode.Name = "lbl_Login_RememberMode";
            this.lbl_Login_RememberMode.Size = new System.Drawing.Size(146, 21);
            this.lbl_Login_RememberMode.TabIndex = 140;
            this.lbl_Login_RememberMode.Text = "Remember Mode";
            // 
            // swt_Login_RememberMode
            // 
            this.swt_Login_RememberMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.swt_Login_RememberMode.BorderRadius = 0;
            this.swt_Login_RememberMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.swt_Login_RememberMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.swt_Login_RememberMode.Location = new System.Drawing.Point(430, 686);
            this.swt_Login_RememberMode.Margin = new System.Windows.Forms.Padding(8);
            this.swt_Login_RememberMode.Name = "swt_Login_RememberMode";
            this.swt_Login_RememberMode.Oncolor = System.Drawing.Color.SeaGreen;
            this.swt_Login_RememberMode.Onoffcolor = System.Drawing.Color.DarkGray;
            this.swt_Login_RememberMode.Size = new System.Drawing.Size(51, 19);
            this.swt_Login_RememberMode.TabIndex = 139;
            this.swt_Login_RememberMode.Textcolor = System.Drawing.Color.White;
            this.swt_Login_RememberMode.Value = true;
            // 
            // chk_Login_PasswordMode
            // 
            this.chk_Login_PasswordMode.AutoSize = true;
            this.chk_Login_PasswordMode.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.chk_Login_PasswordMode.FlatAppearance.BorderSize = 5;
            this.chk_Login_PasswordMode.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.chk_Login_PasswordMode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.chk_Login_PasswordMode.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Login_PasswordMode.ForeColor = System.Drawing.Color.White;
            this.chk_Login_PasswordMode.Location = new System.Drawing.Point(100, 421);
            this.chk_Login_PasswordMode.Name = "chk_Login_PasswordMode";
            this.chk_Login_PasswordMode.Size = new System.Drawing.Size(156, 24);
            this.chk_Login_PasswordMode.TabIndex = 138;
            this.chk_Login_PasswordMode.Text = "Password Mode?";
            this.chk_Login_PasswordMode.UseVisualStyleBackColor = true;
            this.chk_Login_PasswordMode.CheckedChanged += new System.EventHandler(this.chk_Login_PasswordMode_CheckedChanged);
            // 
            // txt_Login_Password
            // 
            this.txt_Login_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.txt_Login_Password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.txt_Login_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Login_Password.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Login_Password.ForeColor = System.Drawing.Color.White;
            this.txt_Login_Password.HintForeColor = System.Drawing.Color.White;
            this.txt_Login_Password.HintText = "";
            this.txt_Login_Password.isPassword = false;
            this.txt_Login_Password.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txt_Login_Password.LineIdleColor = System.Drawing.Color.White;
            this.txt_Login_Password.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txt_Login_Password.LineThickness = 1;
            this.txt_Login_Password.Location = new System.Drawing.Point(189, 364);
            this.txt_Login_Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Login_Password.Name = "txt_Login_Password";
            this.txt_Login_Password.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Login_Password.Size = new System.Drawing.Size(211, 31);
            this.txt_Login_Password.TabIndex = 137;
            this.txt_Login_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Login_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Login_Password_KeyDown);
            // 
            // txt_Login_Username
            // 
            this.txt_Login_Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.txt_Login_Username.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.txt_Login_Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Login_Username.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Login_Username.ForeColor = System.Drawing.Color.White;
            this.txt_Login_Username.HintForeColor = System.Drawing.Color.White;
            this.txt_Login_Username.HintText = "";
            this.txt_Login_Username.isPassword = false;
            this.txt_Login_Username.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txt_Login_Username.LineIdleColor = System.Drawing.Color.White;
            this.txt_Login_Username.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txt_Login_Username.LineThickness = 1;
            this.txt_Login_Username.Location = new System.Drawing.Point(190, 314);
            this.txt_Login_Username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Login_Username.Name = "txt_Login_Username";
            this.txt_Login_Username.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Login_Username.Size = new System.Drawing.Size(210, 31);
            this.txt_Login_Username.TabIndex = 136;
            this.txt_Login_Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Login_Username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Login_Username_KeyDown);
            // 
            // btn_login_clickHere
            // 
            this.btn_login_clickHere.AutoEllipsis = true;
            this.btn_login_clickHere.BackColor = System.Drawing.Color.Transparent;
            this.btn_login_clickHere.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login_clickHere.FlatAppearance.BorderSize = 0;
            this.btn_login_clickHere.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_login_clickHere.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_login_clickHere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login_clickHere.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login_clickHere.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_login_clickHere.Image = global::Project_Management.Properties.Resources.icon_ClickHere_CLR;
            this.btn_login_clickHere.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_login_clickHere.Location = new System.Drawing.Point(237, 466);
            this.btn_login_clickHere.Name = "btn_login_clickHere";
            this.btn_login_clickHere.Size = new System.Drawing.Size(119, 36);
            this.btn_login_clickHere.TabIndex = 135;
            this.btn_login_clickHere.Text = "Click Here";
            this.btn_login_clickHere.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_login_clickHere.UseVisualStyleBackColor = false;
            this.btn_login_clickHere.Click += new System.EventHandler(this.btn_login_clickHere_Click);
            // 
            // btn_Login_LogIn
            // 
            this.btn_Login_LogIn.AutoEllipsis = true;
            this.btn_Login_LogIn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Login_LogIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Login_LogIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Login_LogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login_LogIn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login_LogIn.ForeColor = System.Drawing.Color.White;
            this.btn_Login_LogIn.Image = global::Project_Management.Properties.Resources.icon_Login_CLR;
            this.btn_Login_LogIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Login_LogIn.Location = new System.Drawing.Point(448, 349);
            this.btn_Login_LogIn.Name = "btn_Login_LogIn";
            this.btn_Login_LogIn.Size = new System.Drawing.Size(90, 36);
            this.btn_Login_LogIn.TabIndex = 134;
            this.btn_Login_LogIn.Text = "Log In";
            this.btn_Login_LogIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Login_LogIn.UseVisualStyleBackColor = false;
            this.btn_Login_LogIn.Click += new System.EventHandler(this.btn_Login_LogIn_Click);
            this.btn_Login_LogIn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Login_LogIn_KeyDown);
            // 
            // btn_Login_CreateAccount
            // 
            this.btn_Login_CreateAccount.AutoEllipsis = true;
            this.btn_Login_CreateAccount.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Login_CreateAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Login_CreateAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Login_CreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login_CreateAccount.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login_CreateAccount.ForeColor = System.Drawing.Color.White;
            this.btn_Login_CreateAccount.Image = global::Project_Management.Properties.Resources.icon_CreateAccount_CLR;
            this.btn_Login_CreateAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Login_CreateAccount.Location = new System.Drawing.Point(576, 349);
            this.btn_Login_CreateAccount.Name = "btn_Login_CreateAccount";
            this.btn_Login_CreateAccount.Size = new System.Drawing.Size(205, 36);
            this.btn_Login_CreateAccount.TabIndex = 133;
            this.btn_Login_CreateAccount.Text = "Create New Account";
            this.btn_Login_CreateAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Login_CreateAccount.UseVisualStyleBackColor = false;
            this.btn_Login_CreateAccount.Click += new System.EventHandler(this.btn_Login_CreateAccount_Click);
            // 
            // lbl_Login_ForgotPassword
            // 
            this.lbl_Login_ForgotPassword.AutoSize = true;
            this.lbl_Login_ForgotPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Login_ForgotPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login_ForgotPassword.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbl_Login_ForgotPassword.Location = new System.Drawing.Point(96, 473);
            this.lbl_Login_ForgotPassword.Name = "lbl_Login_ForgotPassword";
            this.lbl_Login_ForgotPassword.Size = new System.Drawing.Size(146, 21);
            this.lbl_Login_ForgotPassword.TabIndex = 132;
            this.lbl_Login_ForgotPassword.Text = "Forgot Password?";
            // 
            // lbl_Login_Password
            // 
            this.lbl_Login_Password.AutoSize = true;
            this.lbl_Login_Password.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login_Password.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Login_Password.Location = new System.Drawing.Point(96, 376);
            this.lbl_Login_Password.Name = "lbl_Login_Password";
            this.lbl_Login_Password.Size = new System.Drawing.Size(82, 21);
            this.lbl_Login_Password.TabIndex = 131;
            this.lbl_Login_Password.Text = "Password";
            // 
            // lbl_Login_Username
            // 
            this.lbl_Login_Username.AutoSize = true;
            this.lbl_Login_Username.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login_Username.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Login_Username.Location = new System.Drawing.Point(96, 322);
            this.lbl_Login_Username.Name = "lbl_Login_Username";
            this.lbl_Login_Username.Size = new System.Drawing.Size(88, 21);
            this.lbl_Login_Username.TabIndex = 130;
            this.lbl_Login_Username.Text = "Username";
            // 
            // lbl_Login_ProjectTitle
            // 
            this.lbl_Login_ProjectTitle.AutoSize = true;
            this.lbl_Login_ProjectTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Login_ProjectTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login_ProjectTitle.ForeColor = System.Drawing.Color.Honeydew;
            this.lbl_Login_ProjectTitle.Location = new System.Drawing.Point(203, 235);
            this.lbl_Login_ProjectTitle.Name = "lbl_Login_ProjectTitle";
            this.lbl_Login_ProjectTitle.Size = new System.Drawing.Size(344, 25);
            this.lbl_Login_ProjectTitle.TabIndex = 129;
            this.lbl_Login_ProjectTitle.Text = "AIUB PROJECT MANAGEMENT";
            this.lbl_Login_ProjectTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBox_logo
            // 
            this.picBox_logo.Image = global::Project_Management.Properties.Resources.projectLogoBig;
            this.picBox_logo.Location = new System.Drawing.Point(332, 19);
            this.picBox_logo.Name = "picBox_logo";
            this.picBox_logo.Size = new System.Drawing.Size(207, 204);
            this.picBox_logo.TabIndex = 128;
            this.picBox_logo.TabStop = false;
            // 
            // Form0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.pnl_Login_Top);
            this.Controls.Add(this.pnl_ForgotPass);
            this.Controls.Add(this.pnl_Login);
            this.Controls.Add(this.pnl_Signup);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form0";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnl_Login_Top.ResumeLayout(false);
            this.pnl_Signup.ResumeLayout(false);
            this.pnl_Signup.PerformLayout();
            this.pnl_ForgotPass.ResumeLayout(false);
            this.pnl_ForgotPass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_Login.ResumeLayout(false);
            this.pnl_Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Login_Top;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_ProjectTitle1;
        private System.Windows.Forms.Button btn_Minus;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Panel pnl_Signup;
        private System.Windows.Forms.Panel pnl_ForgotPass;
        private System.Windows.Forms.Panel pnl_Login;
        private System.Windows.Forms.Label lbl_Login_RememberMode;
        private Bunifu.Framework.UI.BunifuSwitch swt_Login_RememberMode;
        private System.Windows.Forms.CheckBox chk_Login_PasswordMode;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Login_Password;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Login_Username;
        private System.Windows.Forms.Button btn_login_clickHere;
        private System.Windows.Forms.Button btn_Login_LogIn;
        private System.Windows.Forms.Button btn_Login_CreateAccount;
        private System.Windows.Forms.Label lbl_Login_ForgotPassword;
        private System.Windows.Forms.Label lbl_Login_Password;
        private System.Windows.Forms.Label lbl_Login_Username;
        private System.Windows.Forms.Label lbl_Login_ProjectTitle;
        private System.Windows.Forms.PictureBox picBox_logo;
        private Bunifu.Framework.UI.BunifuSwitch swt_Login_RememberMode1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_CreateAccount_ReEnterPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_CreateAccount_Password;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_CreateAccount_Username;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_CreateAccount_Email;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_CreateAccount_Name;
        private System.Windows.Forms.Label lbl_CreateAccount_UserNameTip;
        private System.Windows.Forms.Button btn_createAccount_signup;
        private System.Windows.Forms.Button btn_createAccount_cancel;
        private System.Windows.Forms.Button btn_CreateAccount_Terms;
        private System.Windows.Forms.Label lbl_CreateAccount_Name;
        private System.Windows.Forms.Label lbl_CreateAccount_Email;
        private System.Windows.Forms.Label lbl_CreateAccount_Username;
        private System.Windows.Forms.Label lbl_CreateAccount_Password;
        private System.Windows.Forms.Label lbl_CreateAccount_ReEnterPassword;
        private System.Windows.Forms.Label lbl_CreateAccount_Condition;
        private System.Windows.Forms.Label lbl_CreateAccount_PasswordTip;
        private System.Windows.Forms.Label lbl_forgetPass_password;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtbox_forgetPass_email;
        private System.Windows.Forms.Label lbl_forgetPass_notAmember;
        private System.Windows.Forms.Label lbl_forgetPass_enterEmail;
        private System.Windows.Forms.Label lbl_forgetPass_sendLink;
        private System.Windows.Forms.Label lbl_forgetPass_forgetYour;
        private System.Windows.Forms.Button btn_forgetPass_back;
        private System.Windows.Forms.Button btn_forgetPass_resetPassword;
        private System.Windows.Forms.Button btn_forgetPass_signUp;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}