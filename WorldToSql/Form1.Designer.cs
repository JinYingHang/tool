namespace WorldToSql
{
    partial class FORM1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.字段名 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tBox_DBName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tBox_vName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tBox_desc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tBox_tbName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(2, 158);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(137, 499);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(145, 158);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(137, 499);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBox3.Location = new System.Drawing.Point(288, 158);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(137, 499);
            this.richTextBox3.TabIndex = 4;
            this.richTextBox3.Text = "";
            // 
            // 字段名
            // 
            this.字段名.AutoSize = true;
            this.字段名.Location = new System.Drawing.Point(36, 143);
            this.字段名.Name = "字段名";
            this.字段名.Size = new System.Drawing.Size(71, 12);
            this.字段名.TabIndex = 5;
            this.字段名.Text = "Excel字段列";
            this.字段名.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Excel注释列";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "生成视图sql";
            // 
            // tBox_DBName
            // 
            this.tBox_DBName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tBox_DBName.Location = new System.Drawing.Point(89, 8);
            this.tBox_DBName.Name = "tBox_DBName";
            this.tBox_DBName.Size = new System.Drawing.Size(252, 21);
            this.tBox_DBName.TabIndex = 8;
            this.tBox_DBName.Text = "Inroad-YTWH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "数据库名称：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "视图名称：";
            // 
            // tBox_vName
            // 
            this.tBox_vName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tBox_vName.Location = new System.Drawing.Point(89, 74);
            this.tBox_vName.Name = "tBox_vName";
            this.tBox_vName.Size = new System.Drawing.Size(336, 21);
            this.tBox_vName.TabIndex = 11;
            this.tBox_vName.Text = "V_SafeOperationLicenseRecord";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "视图说明：";
            // 
            // tBox_desc
            // 
            this.tBox_desc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tBox_desc.Location = new System.Drawing.Point(89, 104);
            this.tBox_desc.Name = "tBox_desc";
            this.tBox_desc.Size = new System.Drawing.Size(336, 21);
            this.tBox_desc.TabIndex = 13;
            this.tBox_desc.Text = "CreatTime: 2022/6/20  CreatBy：yhJin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "表名：";
            // 
            // tBox_tbName
            // 
            this.tBox_tbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tBox_tbName.Location = new System.Drawing.Point(89, 45);
            this.tBox_tbName.Name = "tBox_tbName";
            this.tBox_tbName.Size = new System.Drawing.Size(336, 21);
            this.tBox_tbName.TabIndex = 15;
            this.tBox_tbName.Text = "SafeOperationLicenseRecord";
            // 
            // FORM1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 669);
            this.Controls.Add(this.tBox_tbName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tBox_desc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tBox_vName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBox_DBName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.字段名);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FORM1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Label 字段名;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBox_DBName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBox_vName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBox_desc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tBox_tbName;
    }
}

