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
            this.rbox_key1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rbox_text = new System.Windows.Forms.RichTextBox();
            this.字段名 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbox_key3 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rbox_key1
            // 
            this.rbox_key1.Location = new System.Drawing.Point(66, 334);
            this.rbox_key1.Name = "rbox_key1";
            this.rbox_key1.Size = new System.Drawing.Size(405, 21);
            this.rbox_key1.TabIndex = 1;
            this.rbox_key1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(459, 70);
            this.button1.TabIndex = 2;
            this.button1.Text = "加密";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbox_text
            // 
            this.rbox_text.Location = new System.Drawing.Point(66, 13);
            this.rbox_text.Name = "rbox_text";
            this.rbox_text.Size = new System.Drawing.Size(405, 169);
            this.rbox_text.TabIndex = 3;
            this.rbox_text.Text = "测试数据-0a1+ssss";
            // 
            // 字段名
            // 
            this.字段名.AutoSize = true;
            this.字段名.Location = new System.Drawing.Point(31, 15);
            this.字段名.Name = "字段名";
            this.字段名.Size = new System.Drawing.Size(29, 12);
            this.字段名.TabIndex = 5;
            this.字段名.Text = "明文";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "key";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "密文";
            // 
            // rbox_key3
            // 
            this.rbox_key3.Location = new System.Drawing.Point(66, 188);
            this.rbox_key3.Name = "rbox_key3";
            this.rbox_key3.Size = new System.Drawing.Size(405, 140);
            this.rbox_key3.TabIndex = 13;
            this.rbox_key3.Text = "";
            // 
            // FORM1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 443);
            this.Controls.Add(this.rbox_key3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.字段名);
            this.Controls.Add(this.rbox_text);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbox_key1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FORM1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rbox_key1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rbox_text;
        private System.Windows.Forms.Label 字段名;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rbox_key3;
    }
}

