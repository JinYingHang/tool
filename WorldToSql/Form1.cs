using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldToSql
{
    public partial class FORM1 : Form
    {
        public FORM1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var a = richTextBox1.Lines;
                var b = richTextBox2.Lines;
                var d = richTextBox4.Lines;
                if (a.Count() == 0 || b.Count() == 0)
                    return;

                var a1 = a.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
                string[] c = new string[a1.Count() + 2];
                c[0] = $@"
                        USE [{tBox_DBName.Text.Trim()}];
                        GO
                        /******OBJECT  [dbo].[{tBox_vName.Text.Trim()}]  {tBox_desc.Text.Trim()}******/
                        SET ANSI_NULLS ON;
                        GO
                        SET QUOTED_IDENTIFIER ON;
                        GO
                        CREATE VIEW [dbo].[{tBox_vName.Text.Trim()}]
                        AS
                        select ";
                c[c.Length - 1] = $@"
                                  from {tBox_tbName.Text.Trim()}
                                  GO";
                for (int i = 0; i < a1.Count(); i++)
                {
                    c[i + 1] = $"{a1[i]},--{b[i]} (*{d[i]}*)";
                }
                c[c.Length - 2] = c[c.Length - 2].Replace(',', ' ').Replace('，', ' ');
                richTextBox3.Lines = c;
                //richTextBox1.Lines = null;
                //richTextBox2.Lines = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private async void label1_Click(object sender, EventArgs e)
        {

            try
            {
                A();
                B();
            }
            catch (Exception rx)
            {

                MessageBox.Show(rx.ToString());
            }
            
        }

        private async Task<string> A()
        {
            try
            {
                await Task.Delay(2000);
                //string path = @"C:\Users\22143\Documents\企业微信下载\WXWork\1688856920322966\Cache\File\2022-06\20220628.log"; // 如果测试要改成自己地址
                //var contents3 = File.ReadAllText(path, Encoding.GetEncoding("GB2312111"));
                MessageBox.Show("A");
                return "a";
            }
            catch (Exception ex)
            {
                MessageBox.Show("EX");

                return ex.ToString();
            }
          

        }
        private async Task<string> B()
        {
            await Task.Delay(2000);
            MessageBox.Show("B");

            return "b";
        }

        private async Task D()
        {
            await Task.Run(async () =>
            {
                var a = await A();
                MessageBox.Show("结束A", a);
            });
            await Task.Run(async () =>
            {
                var b = await B();
                MessageBox.Show("结束B", b);
            });
        }
    }
}
