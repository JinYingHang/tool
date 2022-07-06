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
                var d = richTextBox4.Lines;
                if (a.Count() == 0 || b.Count() == 0)
                    return;

                var a1 = a.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
                string[] c = new string[a1.Count()];
                for (int i = 0; i < a1.Count(); i++)
                {
                    c[i] = $"///<summary>\r\n///{b[i]}--{d[i]}\r\n/// </summary>\r\n public string {a1[i]} "+"{get; set; }";
                }
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
            
            Dictionary<string, string> a = new Dictionary<string, string>();
            a.Add("a", "1");
            a.Add("a", "2");
            a.Add("a", "3");
            a.Add("a", "4");
            a.Add("a", "5");
            var b = a["a"];
        }
    }
}
