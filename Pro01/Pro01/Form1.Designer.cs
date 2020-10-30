namespace Pro01
{
    partial class FormTest1
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RB2 = new System.Windows.Forms.RadioButton();
            this.RB1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnCombo = new System.Windows.Forms.Button();
            this.combobox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RB4 = new System.Windows.Forms.RadioButton();
            this.RB3 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.tbTest = new System.Windows.Forms.TextBox();
            this.btnNoop = new System.Windows.Forms.Button();
            this.comboIndex = new System.Windows.Forms.ComboBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.tbTestPrint = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CharNum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(36, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 30);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Good Morning!!";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(43, 477);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(74, 19);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "대문자";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(123, 477);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(74, 19);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "소문자";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("양재백두체B", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(176, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("양재백두체B", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(175, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "LABEL2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.RB2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.RB1);
            this.groupBox1.Location = new System.Drawing.Point(30, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 176);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // RB2
            // 
            this.RB2.AutoSize = true;
            this.RB2.Location = new System.Drawing.Point(62, 126);
            this.RB2.Name = "RB2";
            this.RB2.Size = new System.Drawing.Size(80, 19);
            this.RB2.TabIndex = 9;
            this.RB2.TabStop = true;
            this.RB2.Text = "Option2";
            this.RB2.UseVisualStyleBackColor = true;
            // 
            // RB1
            // 
            this.RB1.AutoSize = true;
            this.RB1.Location = new System.Drawing.Point(62, 90);
            this.RB1.Name = "RB1";
            this.RB1.Size = new System.Drawing.Size(80, 19);
            this.RB1.TabIndex = 9;
            this.RB1.Text = "Option1";
            this.RB1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("양재백두체B", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(28, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Item Input";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(140, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(163, 30);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "Good Night!";
            // 
            // btnCombo
            // 
            this.btnCombo.Location = new System.Drawing.Point(313, 46);
            this.btnCombo.Name = "btnCombo";
            this.btnCombo.Size = new System.Drawing.Size(84, 29);
            this.btnCombo.TabIndex = 6;
            this.btnCombo.Text = "button2";
            this.btnCombo.UseVisualStyleBackColor = true;
            // 
            // combobox1
            // 
            this.combobox1.FormattingEnabled = true;
            this.combobox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.combobox1.Location = new System.Drawing.Point(41, 104);
            this.combobox1.Name = "combobox1";
            this.combobox1.Size = new System.Drawing.Size(205, 23);
            this.combobox1.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RB4);
            this.groupBox2.Controls.Add(this.RB3);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.combobox1);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.btnCombo);
            this.groupBox2.Location = new System.Drawing.Point(28, 269);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(412, 172);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // RB4
            // 
            this.RB4.AutoSize = true;
            this.RB4.Location = new System.Drawing.Point(277, 127);
            this.RB4.Name = "RB4";
            this.RB4.Size = new System.Drawing.Size(80, 19);
            this.RB4.TabIndex = 10;
            this.RB4.Text = "Option4";
            this.RB4.UseVisualStyleBackColor = true;
            // 
            // RB3
            // 
            this.RB3.AutoSize = true;
            this.RB3.Location = new System.Drawing.Point(277, 91);
            this.RB3.Name = "RB3";
            this.RB3.Size = new System.Drawing.Size(80, 19);
            this.RB3.TabIndex = 11;
            this.RB3.TabStop = true;
            this.RB3.Text = "Option3";
            this.RB3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("양재튼튼체B", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(503, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 47);
            this.button2.TabIndex = 10;
            this.button2.Text = "Call Form2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbTest
            // 
            this.tbTest.Location = new System.Drawing.Point(503, 201);
            this.tbTest.Multiline = true;
            this.tbTest.Name = "tbTest";
            this.tbTest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbTest.Size = new System.Drawing.Size(299, 136);
            this.tbTest.TabIndex = 11;
            this.tbTest.TextChanged += new System.EventHandler(this.tbTest_TextChanged);
            // 
            // btnNoop
            // 
            this.btnNoop.Enabled = false;
            this.btnNoop.Font = new System.Drawing.Font("양재튼튼체B", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNoop.Location = new System.Drawing.Point(676, 20);
            this.btnNoop.Name = "btnNoop";
            this.btnNoop.Size = new System.Drawing.Size(142, 34);
            this.btnNoop.TabIndex = 10;
            this.btnNoop.Text = "No Operation";
            this.btnNoop.UseVisualStyleBackColor = true;
            this.btnNoop.Visible = false;
            this.btnNoop.Click += new System.EventHandler(this.btnNoop_Click);
            // 
            // comboIndex
            // 
            this.comboIndex.FormattingEnabled = true;
            this.comboIndex.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.comboIndex.Location = new System.Drawing.Point(503, 110);
            this.comboIndex.Name = "comboIndex";
            this.comboIndex.Size = new System.Drawing.Size(112, 23);
            this.comboIndex.TabIndex = 12;
            this.comboIndex.SelectedIndexChanged += new System.EventHandler(this.comboIndex_SelectedIndexChanged_1);
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("양재튼튼체B", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnTest.Location = new System.Drawing.Point(676, 73);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(142, 34);
            this.btnTest.TabIndex = 13;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // tbTestPrint
            // 
            this.tbTestPrint.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTestPrint.Location = new System.Drawing.Point(503, 373);
            this.tbTestPrint.Multiline = true;
            this.tbTestPrint.Name = "tbTestPrint";
            this.tbTestPrint.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbTestPrint.Size = new System.Drawing.Size(299, 136);
            this.tbTestPrint.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(500, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Edit Text";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(502, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Hex View";
            // 
            // CharNum
            // 
            this.CharNum.Location = new System.Drawing.Point(708, 156);
            this.CharNum.Name = "CharNum";
            this.CharNum.Size = new System.Drawing.Size(100, 25);
            this.CharNum.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(632, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Char Num";
            // 
            // FormTest1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 537);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CharNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTestPrint);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.comboIndex);
            this.Controls.Add(this.tbTest);
            this.Controls.Add(this.btnNoop);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox1);
            this.Name = "FormTest1";
            this.Text = "C# Test Form Ver.2.1.5";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTest1_FormClosed);
            this.Load += new System.EventHandler(this.FormTest1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnCombo;
        private System.Windows.Forms.ComboBox combobox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RB1;
        private System.Windows.Forms.RadioButton RB2;
        private System.Windows.Forms.RadioButton RB4;
        private System.Windows.Forms.RadioButton RB3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbTest;
        private System.Windows.Forms.Button btnNoop;
        private System.Windows.Forms.ComboBox comboIndex;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox tbTestPrint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CharNum;
        private System.Windows.Forms.Label label6;
    }
}

