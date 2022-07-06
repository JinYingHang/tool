using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace md5_timeStamp
{
    public partial class Form2 : Form
    {
        string _timeStamp;
        public Form2(string timeStamp)
        {
            _timeStamp = timeStamp;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = _timeStamp;
            Task.Factory.StartNew(() => {
                
                    while (true)
                    {

                        this.BackColor = Color.Red;
                        Thread.Sleep(100);

                        this.BackColor = Color.Green;
                        Thread.Sleep(100);

                        this.BackColor = Color.Yellow;
                        Thread.Sleep(100);
                    }
            });
          
        }

    }
}
