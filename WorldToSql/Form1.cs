using md5_timespan;
using md5_timeStamp;
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
            rbox_key3.Text = (new Class1()).GetMD5Str(rbox_text.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var timeStamp = (new Class1()).GetTimeStamp();
            (new Form2(timeStamp)).ShowDialog();
        }
    }
}
