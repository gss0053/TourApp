using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourApp
{
    public partial class FrmMembership : Form
    {
        List<Membership> lstMembership;
        DBConnect dbconnect = new DBConnect();
       // List<Language> languages;

        

        public FrmMembership(List<Membership> lstMembership)
        {
            InitializeComponent();
            this.lstMembership = lstMembership;
            //this.languages = languages;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegist_Click1(object sender, EventArgs e)
        {
            FormattingControls();
            ControlCB();
        }

        private void FormattingControls()
        {
            lblID.Location = new Point(131, 33);
            tbID.Location = new Point(183, 30);
            lblValid1.Location = new Point(114, 33);
            lblValid1.Visible = true;
            lblIDRule.Location = new Point(182, 56);
            lblIDRule.Visible = true;
            lblIDValid.Location = new Point(330, 58);
            lblIDValid.Visible = true;
            lblPassword.Location = new Point(72, 93);
            tbPassword.Location = new Point(183, 90);
            lblPwdRule.Location = new Point(182, 116);
            lblPwdRule.Visible = true;
            lblValid2.Location = new Point(55, 93);
            lblValid2.Visible = true;
            chkID.Location = new Point(399, 34);
            chkID.Visible = true;
            chkPwd.Location = new Point(399, 94);
            chkPwd.Visible = true;

            lblChk.Location = new Point(31, 153);
            tbChk.Location = new Point(183, 150);
            lblValid3.Location = new Point(14, 153);
            lblValid3.Visible = true;
            chkPwdChk.Location = new Point(399, 154);
            chkPwdChk.Visible = true;

            lblName.Location = new Point(120, 213);
            lblName.Visible = true;
            tbName.Location = new Point(183, 210);
            tbName.Visible = true;
            tbName.Enabled = true;
            lblNameRule.Location = new Point(182, 236);
            lblNameRule.Visible = true;

            lblPhone.Location = new Point(72, 273);
            lblPhone.Visible = true;
            mtbPhone.Location = new Point(183, 270);
            mtbPhone.Visible = true;
            mtbPhone.Enabled = true;
            lblValid4.Location = new Point(55, 273);
            lblValid4.Visible = true;
            chkPhone.Location = new Point(399, 274);
            chkPhone.Visible = true;

            lblBirth.Location = new Point(94, 333);
            lblBirth.Visible = true;
            cbYear.Location = new Point(183, 330);
            cbYear.Visible = true;
            cbYear.Enabled = true;
            cbMonth.Location = new Point(274, 330);
            cbMonth.Visible = true;
            cbDay.Location = new Point(335, 330);
            cbDay.Visible = true;

            lblChk.Visible = true;
            tbChk.Visible = true;
            tbChk.Enabled = true;

            btnLogin.Visible = false;
            btnLogin.Enabled = false;
            btnRegist.Text = "등록";
            btnRegist.Location = new Point(190, 650);
            btnFind.Location = new Point(308, 650);
            btnFind.Text = "뒤로";
            btnFind.Click += btnFind_Click2;
            btnFind.Click -= btnFind_Click1;
            btnRegist.Click += btnRegist_Click2;
            btnRegist.Click -= btnRegist_Click1;


            this.Size = new System.Drawing.Size(454, 700);
        }

        private void btnRegist_Click2(object sender, EventArgs e)
        {
            string month = cbMonth.Text;
            string day = cbDay.Text;
            if (cbMonth.Text.Length == 1)
            {
                month = "0" + cbMonth.Text;
            }
            if (cbDay.Text.Length == 1)
            {
                day = "0" + cbDay.Text;
            }
            string birthday = cbYear.Text + month + day;
            string[] memberinfo = new string[5] { tbID.Text, tbPassword.Text, tbName.Text, mtbPhone.Text, birthday };
            dbconnect.ExecuteInsert(memberinfo);
        }

        private void ControlCB()
        {
            for (int i = DateTime.Today.Year; i > 1899; i--)
            {
                cbYear.Items.Add(i);
            }
        }

        private void btnFind_Click1(object sender, EventArgs e)
        {

        }

        private void btnFind_Click2(object sender, EventArgs e)
        {
            Controls.Clear();
            InitializeComponent();
        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMonth.Enabled = true;
            for (int i = 1; i < 13; i++)
            {
                cbMonth.Items.Add(i);
            }
        }

        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDay.Enabled = true;
            cbDay.Items.Clear();
            if (cbMonth.SelectedIndex == 1)
            {
                for (int i = 1; i < 29; i++)
                {
                    cbDay.Items.Add(i);
                }
            }
            else if (cbMonth.SelectedIndex == 0 || cbMonth.SelectedIndex == 2 || cbMonth.SelectedIndex == 4 || cbMonth.SelectedIndex == 6 || cbMonth.SelectedIndex == 7 || cbMonth.SelectedIndex == 9 || cbMonth.SelectedIndex == 11)
            {
                for (int i = 1; i < 32; i++)
                {
                    cbDay.Items.Add(i);
                }
            }
            else if (cbMonth.SelectedIndex == 3 || cbMonth.SelectedIndex == 5 || cbMonth.SelectedIndex == 8 || cbMonth.SelectedIndex == 10)
            {
                for (int i = 1; i < 31; i++)
                {
                    cbDay.Items.Add(i);
                }
            }
        }

        private void lblIDValid_Click(object sender, EventArgs e)
        {
            foreach (Membership item in lstMembership)
            {
                if (item.Id == tbID.Text)
                {
                    MessageBox.Show("중복된 ID가 존재합니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (item.Id != tbID.Text)
                {
                    MessageBox.Show("사용 가능한 ID입니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void FrmMembership_Load(object sender, EventArgs e)
        {
            pbClose.ImageLocation = Application.StartupPath + @"\images\icon.png";
            dbconnect.ExcuteSelect(lstMembership);


            //string a = CultureInfo.CurrentCulture.EnglishName;
            //MessageBox.Show(a);

            switch (ConfigurationManager.AppSettings["lang"])
            {             
                case "Kor":
                    lblValid.Text = Lang_Resource.Kor.Necessary;                  
                    lblIDValid.Text = Lang_Resource.Kor.Overlap;
                    lblPwdRule.Text = Lang_Resource.Kor.Combination;
                    lblIDRule.Text = Lang_Resource.Kor.Combination2;
                    lblNameRule.Text = Lang_Resource.Kor.Within;                
                    break;
                case "Eng":
                    lblValid.Text = Lang_Resource.Eng.Necessary;
                    lblIDValid.Text = Lang_Resource.Eng.Overlap;
                    lblPwdRule.Text = Lang_Resource.Eng.Combination;
                    lblIDRule.Text = Lang_Resource.Eng.Combination2;
                    lblNameRule.Text = Lang_Resource.Eng.Within;
                    break;
                case "Cht":
                    lblValid.Text = Lang_Resource.Cht.Necessary;
                    lblIDValid.Text = Lang_Resource.Cht.Overlap;
                    lblPwdRule.Text = Lang_Resource.Cht.Combination;
                    lblIDRule.Text = Lang_Resource.Cht.Combination2;
                    lblNameRule.Text = Lang_Resource.Cht.Within;
                    break;
                case "Chs":
                    lblValid.Text = Lang_Resource.Chs.Necessary;
                    lblIDValid.Text = Lang_Resource.Chs.Overlap;
                    lblPwdRule.Text = Lang_Resource.Chs.Combination;
                    lblIDRule.Text = Lang_Resource.Chs.Combination2;
                    lblNameRule.Text = Lang_Resource.Chs.Within;
                    break;
                case "Jpn":
                    lblValid.Text = Lang_Resource.Jpn.Necessary;
                    lblIDValid.Text = Lang_Resource.Jpn.Overlap;
                    lblPwdRule.Text = Lang_Resource.Jpn.Combination;
                    lblIDRule.Text = Lang_Resource.Jpn.Combination2;
                    lblNameRule.Text = Lang_Resource.Jpn.Within;
                    break;
                case "Rus":
                    lblValid.Text = Lang_Resource.Rus.Necessary;
                    lblIDValid.Text = Lang_Resource.Rus.Overlap;
                    lblPwdRule.Text = Lang_Resource.Rus.Combination;
                    lblIDRule.Text = Lang_Resource.Rus.Combination2;
                    lblNameRule.Text = Lang_Resource.Rus.Within;
                    break;
                case "Fre":
                    lblValid.Text = Lang_Resource.Fre.Necessary;
                    lblIDValid.Text = Lang_Resource.Fre.Overlap;
                    lblPwdRule.Text = Lang_Resource.Fre.Combination;
                    lblIDRule.Text = Lang_Resource.Fre.Combination2;
                    lblNameRule.Text = Lang_Resource.Fre.Within;
                    break;
                case "Ger":
                    lblValid.Text = Lang_Resource.Ger.Necessary;
                    lblIDValid.Text = Lang_Resource.Ger.Overlap;
                    lblPwdRule.Text = Lang_Resource.Ger.Combination;
                    lblIDRule.Text = Lang_Resource.Ger.Combination2;
                    lblNameRule.Text = Lang_Resource.Ger.Within;
                    break;
                case "Spn":
                    lblValid.Text = Lang_Resource.Spn.Necessary;
                    lblIDValid.Text = Lang_Resource.Spn.Overlap;
                    lblPwdRule.Text = Lang_Resource.Spn.Combination;
                    lblIDRule.Text = Lang_Resource.Spn.Combination2;
                    lblNameRule.Text = Lang_Resource.Spn.Within;
                    break;

                default:
                    break;
            }

            //lblValid.Text = languages[lang_index].Necessary;
            //lblIDValid.Text = languages[lang_index].Overlap;
            //lblPwdRule.Text = languages[lang_index].Combination;
            //lblIDRule.Text = languages[lang_index].Combination2;
            //lblNameRule.Text = languages[lang_index].Within;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbID_TextChanged(object sender, EventArgs e)
        {
            // ^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,13}$
            string patternID = "^(?=.*?[A-Za-z])(?=.*?[0-9]).{5,13}$";
            if (Regex.IsMatch(tbID.Text,patternID))    // 패턴에 안맞을시에 메세지 박스뜸
            {
                // 체크박스 추가하면됨
                chkID.Checked = true;
            }
            else
            {
                chkID.Checked = false;
            }
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            //string patternPASS = "^[~`!@#$%\\^&*()A-Za-z0-9+]{8,13}$";
            string patternPASS = "^(?=.*?[A-Za-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,13}$";
            if (Regex.IsMatch(tbPassword.Text, patternPASS)) // 패턴에 안맞을시에 메세지 박스뜸
            {
                chkPwd.Checked = true;
            }
            else
            {
                chkPwd.Checked = false;
            }
        }
    }
}