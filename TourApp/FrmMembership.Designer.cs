namespace TourApp
{
    partial class FrmMembership
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
            this.btnFind = new System.Windows.Forms.Button();
            this.btnRegist = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.tbChk = new System.Windows.Forms.TextBox();
            this.lblChk = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblValid = new System.Windows.Forms.Label();
            this.lblValid1 = new System.Windows.Forms.Label();
            this.lblValid2 = new System.Windows.Forms.Label();
            this.lblValid3 = new System.Windows.Forms.Label();
            this.lblValid4 = new System.Windows.Forms.Label();
            this.lblBirth = new System.Windows.Forms.Label();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.cbDay = new System.Windows.Forms.ComboBox();
            this.mtbPhone = new System.Windows.Forms.MaskedTextBox();
            this.lblIDValid = new System.Windows.Forms.Label();
            this.lblIDRule = new System.Windows.Forms.Label();
            this.lblPwdRule = new System.Windows.Forms.Label();
            this.chkID = new System.Windows.Forms.CheckBox();
            this.chkPwd = new System.Windows.Forms.CheckBox();
            this.chkPwdChk = new System.Windows.Forms.CheckBox();
            this.chkPhone = new System.Windows.Forms.CheckBox();
            this.lblNameRule = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 

            this.pbClose.Location = new System.Drawing.Point(408, 1);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(44, 43);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 7;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pictureBox1_Click);
            // 

            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(308, 159);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 20;
            this.btnFind.Text = "계정 찾기";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click1);
            // 
            // btnRegist
            // 
            this.btnRegist.Location = new System.Drawing.Point(190, 159);
            this.btnRegist.Name = "btnRegist";
            this.btnRegist.Size = new System.Drawing.Size(75, 23);
            this.btnRegist.TabIndex = 19;
            this.btnRegist.Text = "회원가입";
            this.btnRegist.UseVisualStyleBackColor = true;
            this.btnRegist.Click += new System.EventHandler(this.btnRegist_Click1);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(72, 159);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 18;
            this.btnLogin.Text = "로그인";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(138, 99);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '●';
            this.tbPassword.Size = new System.Drawing.Size(200, 21);
            this.tbPassword.TabIndex = 17;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(138, 44);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(200, 21);
            this.tbID.TabIndex = 16;
            this.tbID.TextChanged += new System.EventHandler(this.tbID_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(40, 102);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(72, 12);
            this.lblPassword.TabIndex = 15;
            this.lblPassword.Text = "PASSWORD";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(96, 47);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(16, 12);
            this.lblID.TabIndex = 14;
            this.lblID.Text = "ID";
            // 
            // tbChk
            // 
            this.tbChk.Enabled = false;
            this.tbChk.Location = new System.Drawing.Point(183, 110);
            this.tbChk.Name = "tbChk";
            this.tbChk.PasswordChar = '●';
            this.tbChk.Size = new System.Drawing.Size(200, 21);
            this.tbChk.TabIndex = 21;
            this.tbChk.Visible = false;
            // 
            // lblChk
            // 
            this.lblChk.AutoSize = true;
            this.lblChk.Location = new System.Drawing.Point(31, 113);
            this.lblChk.Name = "lblChk";
            this.lblChk.Size = new System.Drawing.Size(118, 12);
            this.lblChk.TabIndex = 22;
            this.lblChk.Text = "PASSWORD CHECK";
            this.lblChk.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblChk.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(120, 125);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 12);
            this.lblName.TabIndex = 23;
            this.lblName.Text = "이름";
            this.lblName.Visible = false;
            // 
            // tbName
            // 
            this.tbName.Enabled = false;
            this.tbName.Location = new System.Drawing.Point(183, 122);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(200, 21);
            this.tbName.TabIndex = 24;
            this.tbName.Visible = false;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(72, 137);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(77, 12);
            this.lblPhone.TabIndex = 25;
            this.lblPhone.Text = "휴대전화번호";
            this.lblPhone.Visible = false;
            // 
            // lblValid
            // 
            this.lblValid.AutoSize = true;
            this.lblValid.ForeColor = System.Drawing.Color.Red;
            this.lblValid.Location = new System.Drawing.Point(12, 9);
            this.lblValid.Name = "lblValid";
            this.lblValid.Size = new System.Drawing.Size(107, 12);
            this.lblValid.TabIndex = 28;
            this.lblValid.Text = "* 표시는 필수 항목";
            // 
            // lblValid1
            // 
            this.lblValid1.AutoSize = true;
            this.lblValid1.ForeColor = System.Drawing.Color.Red;
            this.lblValid1.Location = new System.Drawing.Point(79, 47);
            this.lblValid1.Name = "lblValid1";
            this.lblValid1.Size = new System.Drawing.Size(11, 12);
            this.lblValid1.TabIndex = 29;
            this.lblValid1.Text = "*";
            this.lblValid1.Visible = false;
            // 
            // lblValid2
            // 
            this.lblValid2.AutoSize = true;
            this.lblValid2.ForeColor = System.Drawing.Color.Red;
            this.lblValid2.Location = new System.Drawing.Point(10, 63);
            this.lblValid2.Name = "lblValid2";
            this.lblValid2.Size = new System.Drawing.Size(11, 12);
            this.lblValid2.TabIndex = 30;
            this.lblValid2.Text = "*";
            this.lblValid2.Visible = false;
            // 
            // lblValid3
            // 
            this.lblValid3.AutoSize = true;
            this.lblValid3.ForeColor = System.Drawing.Color.Red;
            this.lblValid3.Location = new System.Drawing.Point(10, 90);
            this.lblValid3.Name = "lblValid3";
            this.lblValid3.Size = new System.Drawing.Size(11, 12);
            this.lblValid3.TabIndex = 31;
            this.lblValid3.Text = "*";
            this.lblValid3.Visible = false;
            // 
            // lblValid4
            // 
            this.lblValid4.AutoSize = true;
            this.lblValid4.ForeColor = System.Drawing.Color.Red;
            this.lblValid4.Location = new System.Drawing.Point(10, 114);
            this.lblValid4.Name = "lblValid4";
            this.lblValid4.Size = new System.Drawing.Size(11, 12);
            this.lblValid4.TabIndex = 32;
            this.lblValid4.Text = "*";
            this.lblValid4.Visible = false;
            // 
            // lblBirth
            // 
            this.lblBirth.AutoSize = true;
            this.lblBirth.Location = new System.Drawing.Point(94, 149);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(53, 12);
            this.lblBirth.TabIndex = 34;
            this.lblBirth.Text = "생년월일";
            this.lblBirth.Visible = false;
            // 
            // cbYear
            // 
            this.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYear.Enabled = false;
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(183, 146);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(85, 20);
            this.cbYear.TabIndex = 35;
            this.cbYear.Visible = false;
            this.cbYear.SelectedIndexChanged += new System.EventHandler(this.cbYear_SelectedIndexChanged);
            // 
            // cbMonth
            // 
            this.cbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonth.Enabled = false;
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Location = new System.Drawing.Point(274, 146);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(55, 20);
            this.cbMonth.TabIndex = 36;
            this.cbMonth.Visible = false;
            this.cbMonth.SelectedIndexChanged += new System.EventHandler(this.cbMonth_SelectedIndexChanged);
            // 
            // cbDay
            // 
            this.cbDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDay.Enabled = false;
            this.cbDay.FormattingEnabled = true;
            this.cbDay.Location = new System.Drawing.Point(335, 146);
            this.cbDay.Name = "cbDay";
            this.cbDay.Size = new System.Drawing.Size(48, 20);
            this.cbDay.TabIndex = 37;
            this.cbDay.Visible = false;
            // 
            // mtbPhone
            // 
            this.mtbPhone.Enabled = false;
            this.mtbPhone.Location = new System.Drawing.Point(183, 134);
            this.mtbPhone.Mask = "000-9000-0000";
            this.mtbPhone.Name = "mtbPhone";
            this.mtbPhone.Size = new System.Drawing.Size(200, 21);
            this.mtbPhone.TabIndex = 38;
            this.mtbPhone.Visible = false;
            // 
            // lblIDValid
            // 
            this.lblIDValid.AutoSize = true;
            this.lblIDValid.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblIDValid.Location = new System.Drawing.Point(330, 95);
            this.lblIDValid.Name = "lblIDValid";
            this.lblIDValid.Size = new System.Drawing.Size(53, 12);
            this.lblIDValid.TabIndex = 39;
            this.lblIDValid.Text = "중복확인";
            this.lblIDValid.Visible = false;
            this.lblIDValid.Click += new System.EventHandler(this.lblIDValid_Click);
            // 
            // lblIDRule
            // 
            this.lblIDRule.AutoSize = true;
            this.lblIDRule.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblIDRule.Location = new System.Drawing.Point(183, 99);
            this.lblIDRule.Name = "lblIDRule";
            this.lblIDRule.Size = new System.Drawing.Size(141, 11);
            this.lblIDRule.TabIndex = 40;
            this.lblIDRule.Text = "*(5~13)자리 영문,숫자 조합";
            this.lblIDRule.Visible = false;
            // 
            // lblPwdRule
            // 
            this.lblPwdRule.AutoSize = true;
            this.lblPwdRule.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPwdRule.Location = new System.Drawing.Point(183, 81);
            this.lblPwdRule.Name = "lblPwdRule";
            this.lblPwdRule.Size = new System.Drawing.Size(214, 11);
            this.lblPwdRule.TabIndex = 41;
            this.lblPwdRule.Text = "*(8~13)자리 영문,숫자,특수문자 동시 포함";
            this.lblPwdRule.Visible = false;
            // 
            // chkID
            // 
            this.chkID.AutoSize = true;
            this.chkID.Enabled = false;
            this.chkID.Location = new System.Drawing.Point(390, 110);
            this.chkID.Name = "chkID";
            this.chkID.Size = new System.Drawing.Size(15, 14);
            this.chkID.TabIndex = 42;
            this.chkID.UseVisualStyleBackColor = true;
            this.chkID.Visible = false;
            // 
            // chkPwd
            // 
            this.chkPwd.AutoSize = true;
            this.chkPwd.Enabled = false;
            this.chkPwd.Location = new System.Drawing.Point(390, 132);
            this.chkPwd.Name = "chkPwd";
            this.chkPwd.Size = new System.Drawing.Size(15, 14);
            this.chkPwd.TabIndex = 43;
            this.chkPwd.UseVisualStyleBackColor = true;
            this.chkPwd.Visible = false;
            // 
            // chkPwdChk
            // 
            this.chkPwdChk.AutoSize = true;
            this.chkPwdChk.Enabled = false;
            this.chkPwdChk.Location = new System.Drawing.Point(389, 154);
            this.chkPwdChk.Name = "chkPwdChk";
            this.chkPwdChk.Size = new System.Drawing.Size(15, 14);
            this.chkPwdChk.TabIndex = 44;
            this.chkPwdChk.UseVisualStyleBackColor = true;
            this.chkPwdChk.Visible = false;
            // 
            // chkPhone
            // 
            this.chkPhone.AutoSize = true;
            this.chkPhone.Enabled = false;
            this.chkPhone.Location = new System.Drawing.Point(389, 176);
            this.chkPhone.Name = "chkPhone";
            this.chkPhone.Size = new System.Drawing.Size(15, 14);
            this.chkPhone.TabIndex = 45;
            this.chkPhone.UseVisualStyleBackColor = true;
            this.chkPhone.Visible = false;
            // 
            // lblNameRule
            // 
            this.lblNameRule.AutoSize = true;
            this.lblNameRule.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblNameRule.Location = new System.Drawing.Point(183, 120);
            this.lblNameRule.Name = "lblNameRule";
            this.lblNameRule.Size = new System.Drawing.Size(96, 11);
            this.lblNameRule.TabIndex = 46;
            this.lblNameRule.Text = "*50자 이내의 문자";
            this.lblNameRule.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(92, 476);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(74, 446);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // pbClose
            // 
            this.pbClose.Location = new System.Drawing.Point(408, 1);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(44, 43);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 7;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmMembership
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 700);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblNameRule);
            this.Controls.Add(this.chkPhone);
            this.Controls.Add(this.chkPwdChk);
            this.Controls.Add(this.chkPwd);
            this.Controls.Add(this.chkID);
            this.Controls.Add(this.lblPwdRule);
            this.Controls.Add(this.lblIDRule);
            this.Controls.Add(this.lblIDValid);
            this.Controls.Add(this.mtbPhone);
            this.Controls.Add(this.cbDay);
            this.Controls.Add(this.cbMonth);
            this.Controls.Add(this.cbYear);
            this.Controls.Add(this.lblBirth);
            this.Controls.Add(this.lblValid4);
            this.Controls.Add(this.lblValid3);
            this.Controls.Add(this.lblValid2);
            this.Controls.Add(this.lblValid1);
            this.Controls.Add(this.lblValid);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblChk);
            this.Controls.Add(this.tbChk);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnRegist);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.pbClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMembership";
            this.Text = "로그인";
            this.Load += new System.EventHandler(this.FrmMembership_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox pbClose;
        public System.Windows.Forms.Button btnFind;
        public System.Windows.Forms.Button btnRegist;
        public System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox tbChk;
        private System.Windows.Forms.Label lblChk;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblValid;
        private System.Windows.Forms.Label lblValid1;
        private System.Windows.Forms.Label lblValid2;
        private System.Windows.Forms.Label lblValid3;
        private System.Windows.Forms.Label lblValid4;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.ComboBox cbDay;
        private System.Windows.Forms.MaskedTextBox mtbPhone;
        private System.Windows.Forms.Label lblIDValid;
        private System.Windows.Forms.Label lblIDRule;
        private System.Windows.Forms.Label lblPwdRule;
        private System.Windows.Forms.CheckBox chkID;
        private System.Windows.Forms.CheckBox chkPwd;
        private System.Windows.Forms.CheckBox chkPwdChk;
        private System.Windows.Forms.CheckBox chkPhone;
        private System.Windows.Forms.Label lblNameRule;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}