using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                    c[i + 1] = $"{a1[i]},--{b[i]}";
                }
                c[c.Length - 2] = c[c.Length - 2].Replace(',', ' ').Replace('，', ' ');
                richTextBox3.Lines=c;
                richTextBox1.Lines = null;
                richTextBox2.Lines = null;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
