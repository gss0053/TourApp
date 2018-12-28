using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourApp
{
    public partial class frm_admin : Form
    {
        private SqlDataAdapter adapter;
        private DataSet memberSet;
        private DataTable memberTable;
        private Membership member;

        public frm_admin()
        {
            InitializeComponent();
            ClearFields();
        }


        private void frm_admin_Load(object sender, EventArgs e)
        {
            string conStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
            string selectCommand = "Select * from dbo.Members";

            adapter = new SqlDataAdapter(selectCommand, conStr);


            SqlConnection con = adapter.SelectCommand.Connection;

            // update
            adapter.UpdateCommand = con.CreateCommand();
            adapter.UpdateCommand.CommandType = CommandType.StoredProcedure;
            adapter.UpdateCommand.CommandText = "MModify";
            AddParameter(adapter.UpdateCommand, "ID", "PASSWORD", "NAME", "PHONE", "BIRTHDAY");

            // delete
            adapter.DeleteCommand = con.CreateCommand();
            adapter.DeleteCommand.CommandType = CommandType.StoredProcedure;
            adapter.DeleteCommand.CommandText = "MDelete";
            AddParameter(adapter.DeleteCommand, "ID");




            memberSet = new DataSet();
            adapter.Fill(memberSet, "tblmember");

            update_GV();

        }

        private void AddParameter(SqlCommand cmd, params string[] cols)
        {
            foreach (string item in cols)
            {
                if (item == "ID")
                {
                    cmd.Parameters.Add("@" + item, SqlDbType.NVarChar, 0, item);
                }
                else
                {
                    cmd.Parameters.Add("@" + item, SqlDbType.NVarChar, 0, item);
                }
            }
        }


        private void update_GV()
        {
            this.dataGridView1.DataSource = null;
            memberSet.Clear();

            adapter.Fill(memberSet, "tblmember");

            memberTable = memberSet.Tables["tblmember"]; // 가상의 테이블 역활

            dataGridView1.DataSource = memberTable;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DataRow targetRow = memberTable.Rows[dataGridView1.CurrentRow.Index];

            var result = MessageBox.Show("삭제 하시겠습니까?", "delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                targetRow.Delete();

                try
                {
                    adapter.Update(memberSet, "tblmember");
                    memberSet.AcceptChanges(); // commit
                    update_GV();
                    ClearFields();
                }
                catch (SqlException)
                {
                    MessageBox.Show("삭제 취소");
                    memberSet.RejectChanges(); // rollback
                }
            }
        }



        private void btn_update_Click(object sender, EventArgs e)
        {

    
            // 업데이트 버튼을 누른 시점의 현재 라벨과 텍스트박스에서 친구 객체 만듬
            Membership mmem = new Membership
            {
                Id = lbl_id.Text,
                Password = txt_pw.Text,
                Name = txt_name.Text,
                Phone = txt_ph.Text,
                Birthday = txt_Bd.Text
            };
            if (!member.Equals(mmem))
            {
                // update문 수행 
                DataRow targetRow = memberTable.Rows[dataGridView1.CurrentRow.Index];

                targetRow.BeginEdit();  // 변경된 사항이 있는지 추적
                targetRow["ID"] = lbl_id.Text;
                targetRow["Password"] = txt_pw.Text;
                targetRow["Name"] = txt_name.Text;
                targetRow["Phone"] = txt_ph.Text;
                targetRow["Birthday"] = txt_Bd.Text;
                targetRow.EndEdit();    

                DataSet changeSet = memberSet.GetChanges(DataRowState.Modified);   // 변경된 데이터셋 가져옴( targetRow에 의해 변경된 DataSet)

                if (changeSet.HasErrors)
                {
                    MessageBox.Show("수정된 내용에 에러가 있습니다");
                }
                else
                {
                    try
                    {
                        adapter.Update(changeSet, "tblmember");
                        memberSet.AcceptChanges(); // commit
                        update_GV();
                        ClearFields();
                        MessageBox.Show("수정완료");
                    }
                    catch (NullReferenceException)
                    {

                        MessageBox.Show("수정 취소");
                        memberSet.RejectChanges(); // rollback
                    }
                }
            }
        }

        private void ClearFields()
        {
            txt_pw.Text = txt_name.Text = txt_ph.Text = txt_Bd.Text= lbl_id.Text= String.Empty;
        }

     
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count == 1)
            {
                DataRow dt = memberSet.Tables["tblmember"].Rows[e.RowIndex];
                lbl_id.Text = dt["ID"].ToString();
                txt_pw.Text = dt["Password"].ToString();
                txt_name.Text = dt["Name"].ToString();
                txt_ph.Text = dt["Phone"].ToString();
                txt_Bd.Text = dt["Birthday"].ToString();

                member = new Membership
                {
                    Id = lbl_id.Text,
                    Password = txt_pw.Text,
                    Name = txt_name.Text,
                    Phone = txt_ph.Text,
                    Birthday = txt_Bd.Text
                };
            }
        }

   
    }
}
