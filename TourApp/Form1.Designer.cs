namespace TourApp
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbxArea = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxMuni = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbxService2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxService1 = new System.Windows.Forms.ComboBox();
            this.cbxService3 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(644, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(539, 569);
            this.textBox1.TabIndex = 0;
            // 
            // cbxArea
            // 
            this.cbxArea.FormattingEnabled = true;
            this.cbxArea.Location = new System.Drawing.Point(81, 14);
            this.cbxArea.Name = "cbxArea";
            this.cbxArea.Size = new System.Drawing.Size(121, 20);
            this.cbxArea.TabIndex = 1;
            this.cbxArea.Text = "대분류";
            this.cbxArea.SelectedIndexChanged += new System.EventHandler(this.cbxArea_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "지역 선택";
            // 
            // cbxMuni
            // 
            this.cbxMuni.FormattingEnabled = true;
            this.cbxMuni.Location = new System.Drawing.Point(221, 14);
            this.cbxMuni.Name = "cbxMuni";
            this.cbxMuni.Size = new System.Drawing.Size(121, 20);
            this.cbxMuni.TabIndex = 4;
            this.cbxMuni.Text = "소분류";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(548, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "JsonTest";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxService2
            // 
            this.cbxService2.FormattingEnabled = true;
            this.cbxService2.Location = new System.Drawing.Point(221, 52);
            this.cbxService2.Name = "cbxService2";
            this.cbxService2.Size = new System.Drawing.Size(121, 20);
            this.cbxService2.TabIndex = 8;
            this.cbxService2.Text = "중분류";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "서비스분류";
            // 
            // cbxService1
            // 
            this.cbxService1.FormattingEnabled = true;
            this.cbxService1.Location = new System.Drawing.Point(81, 52);
            this.cbxService1.Name = "cbxService1";
            this.cbxService1.Size = new System.Drawing.Size(121, 20);
            this.cbxService1.TabIndex = 6;
            this.cbxService1.Text = "대분류";
            // 
            // cbxService3
            // 
            this.cbxService3.FormattingEnabled = true;
            this.cbxService3.Location = new System.Drawing.Point(361, 52);
            this.cbxService3.Name = "cbxService3";
            this.cbxService3.Size = new System.Drawing.Size(121, 20);
            this.cbxService3.TabIndex = 9;
            this.cbxService3.Text = "소분류";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 680);
            this.Controls.Add(this.cbxService3);
            this.Controls.Add(this.cbxService2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxService1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbxMuni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxArea);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbxArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxMuni;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbxService2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxService1;
        private System.Windows.Forms.ComboBox cbxService3;
    }
}

