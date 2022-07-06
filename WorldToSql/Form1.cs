using System;
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
            rbox_key3.Text = AESUtils.encrypt(rbox_text.Text,rbox_key1.Text);
        }

    }
}
