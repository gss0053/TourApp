﻿namespace TourApp
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
            this.lbl_region = new System.Windows.Forms.Label();
            this.cbxMuni = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbxService2 = new System.Windows.Forms.ComboBox();
            this.lbl_service = new System.Windows.Forms.Label();
            this.cbxService1 = new System.Windows.Forms.ComboBox();
            this.cbxService3 = new System.Windows.Forms.ComboBox();
            this.lbl_language = new System.Windows.Forms.Label();
            this.cbx_language = new System.Windows.Forms.ComboBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.lbl_main1 = new System.Windows.Forms.Label();
            this.lbl_main2 = new System.Windows.Forms.Label();
            this.lbl_small1 = new System.Windows.Forms.Label();
            this.lbl_middle = new System.Windows.Forms.Label();
            this.lbl_small2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.cbxArea.Location = new System.Drawing.Point(145, 65);
            this.cbxArea.Name = "cbxArea";
            this.cbxArea.Size = new System.Drawing.Size(121, 20);
            this.cbxArea.TabIndex = 1;
            this.cbxArea.Text = "대분류";
            this.cbxArea.SelectedIndexChanged += new System.EventHandler(this.cbxArea_SelectedIndexChanged);
            // 
            // lbl_region
            // 
            this.lbl_region.AutoSize = true;
            this.lbl_region.Location = new System.Drawing.Point(12, 68);
            this.lbl_region.Name = "lbl_region";
            this.lbl_region.Size = new System.Drawing.Size(57, 12);
            this.lbl_region.TabIndex = 3;
            this.lbl_region.Text = "지역 선택";
            // 
            // cbxMuni
            // 
            this.cbxMuni.FormattingEnabled = true;
            this.cbxMuni.Location = new System.Drawing.Point(285, 65);
            this.cbxMuni.Name = "cbxMuni";
            this.cbxMuni.Size = new System.Drawing.Size(121, 20);
            this.cbxMuni.TabIndex = 4;
            this.cbxMuni.Text = "소분류";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(563, 16);
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
            this.cbxService2.Location = new System.Drawing.Point(285, 105);
            this.cbxService2.Name = "cbxService2";
            this.cbxService2.Size = new System.Drawing.Size(121, 20);
            this.cbxService2.TabIndex = 8;
            this.cbxService2.Text = "중분류";
            this.cbxService2.SelectedIndexChanged += new System.EventHandler(this.cbxService2_SelectedIndexChanged);
            // 
            // lbl_service
            // 
            this.lbl_service.AutoSize = true;
            this.lbl_service.Location = new System.Drawing.Point(12, 108);
            this.lbl_service.Name = "lbl_service";
            this.lbl_service.Size = new System.Drawing.Size(65, 12);
            this.lbl_service.TabIndex = 7;
            this.lbl_service.Text = "서비스분류";
            // 
            // cbxService1
            // 
            this.cbxService1.FormattingEnabled = true;
            this.cbxService1.Location = new System.Drawing.Point(145, 105);
            this.cbxService1.Name = "cbxService1";
            this.cbxService1.Size = new System.Drawing.Size(121, 20);
            this.cbxService1.TabIndex = 6;
            this.cbxService1.Text = "대분류";
            this.cbxService1.SelectedIndexChanged += new System.EventHandler(this.cbxService1_SelectedIndexChanged);
            // 
            // cbxService3
            // 
            this.cbxService3.FormattingEnabled = true;
            this.cbxService3.Location = new System.Drawing.Point(425, 105);
            this.cbxService3.Name = "cbxService3";
            this.cbxService3.Size = new System.Drawing.Size(121, 20);
            this.cbxService3.TabIndex = 9;
            this.cbxService3.Text = "소분류";
            // 
            // lbl_language
            // 
            this.lbl_language.AutoSize = true;
            this.lbl_language.Location = new System.Drawing.Point(12, 30);
            this.lbl_language.Name = "lbl_language";
            this.lbl_language.Size = new System.Drawing.Size(57, 12);
            this.lbl_language.TabIndex = 11;
            this.lbl_language.Text = "언어 선택";
            // 
            // cbx_language
            // 
            this.cbx_language.FormattingEnabled = true;
            this.cbx_language.Location = new System.Drawing.Point(145, 27);
            this.cbx_language.Name = "cbx_language";
            this.cbx_language.Size = new System.Drawing.Size(121, 20);
            this.cbx_language.TabIndex = 10;
            this.cbx_language.SelectedIndexChanged += new System.EventHandler(this.cbx_language_SelectedIndexChanged);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(561, 102);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(48, 23);
            this.btn_clear.TabIndex = 12;
            this.btn_clear.Text = "clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // lbl_main1
            // 
            this.lbl_main1.AutoSize = true;
            this.lbl_main1.Location = new System.Drawing.Point(143, 50);
            this.lbl_main1.Name = "lbl_main1";
            this.lbl_main1.Size = new System.Drawing.Size(41, 12);
            this.lbl_main1.TabIndex = 13;
            this.lbl_main1.Text = "대분류";
            // 
            // lbl_main2
            // 
            this.lbl_main2.AutoSize = true;
            this.lbl_main2.Location = new System.Drawing.Point(143, 90);
            this.lbl_main2.Name = "lbl_main2";
            this.lbl_main2.Size = new System.Drawing.Size(41, 12);
            this.lbl_main2.TabIndex = 14;
            this.lbl_main2.Text = "대분류";
            // 
            // lbl_small1
            // 
            this.lbl_small1.AutoSize = true;
            this.lbl_small1.Location = new System.Drawing.Point(283, 50);
            this.lbl_small1.Name = "lbl_small1";
            this.lbl_small1.Size = new System.Drawing.Size(41, 12);
            this.lbl_small1.TabIndex = 15;
            this.lbl_small1.Text = "소분류";
            // 
            // lbl_middle
            // 
            this.lbl_middle.AutoSize = true;
            this.lbl_middle.Location = new System.Drawing.Point(283, 90);
            this.lbl_middle.Name = "lbl_middle";
            this.lbl_middle.Size = new System.Drawing.Size(41, 12);
            this.lbl_middle.TabIndex = 16;
            this.lbl_middle.Text = "중분류";
            // 
            // lbl_small2
            // 
            this.lbl_small2.AutoSize = true;
            this.lbl_small2.Location = new System.Drawing.Point(423, 90);
            this.lbl_small2.Name = "lbl_small2";
            this.lbl_small2.Size = new System.Drawing.Size(41, 12);
            this.lbl_small2.TabIndex = 17;
            this.lbl_small2.Text = "소분류";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 12);
            this.label1.TabIndex = 18;
            this.label1.Text = "Language";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 680);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_small2);
            this.Controls.Add(this.lbl_middle);
            this.Controls.Add(this.lbl_small1);
            this.Controls.Add(this.lbl_main2);
            this.Controls.Add(this.lbl_main1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.lbl_language);
            this.Controls.Add(this.cbx_language);
            this.Controls.Add(this.cbxService3);
            this.Controls.Add(this.cbxService2);
            this.Controls.Add(this.lbl_service);
            this.Controls.Add(this.cbxService1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbxMuni);
            this.Controls.Add(this.lbl_region);
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
        private System.Windows.Forms.Label lbl_region;
        private System.Windows.Forms.ComboBox cbxMuni;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbxService2;
        private System.Windows.Forms.Label lbl_service;
        private System.Windows.Forms.ComboBox cbxService1;
        private System.Windows.Forms.ComboBox cbxService3;
        private System.Windows.Forms.Label lbl_language;
        private System.Windows.Forms.ComboBox cbx_language;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label lbl_main1;
        private System.Windows.Forms.Label lbl_main2;
        private System.Windows.Forms.Label lbl_small1;
        private System.Windows.Forms.Label lbl_middle;
        private System.Windows.Forms.Label lbl_small2;
        private System.Windows.Forms.Label label1;
    }
}

