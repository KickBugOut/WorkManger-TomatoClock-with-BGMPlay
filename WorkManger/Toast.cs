using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exercise
{
    public partial class Toast : Form
    {
        public Toast(string msg)
        {
            InitializeComponent();
            this.SetText(msg);
            this.Show();
        }
        private void SetText(string msg)
        {
            this.msg.Location = new Point(0, 0);
            this.msg.Text = msg;
            this.Size = this.msg.Size;
        }
        private System.Windows.Forms.Timer timer;
        private void Toast_Load(object sender, EventArgs e)
        {  
            timer = new System.Windows.Forms.Timer();
            timer.Tick += delegate {
                 this.Close();
            };
            timer.Interval = (int) TimeSpan.FromSeconds(2).TotalMilliseconds;
            timer.Start(); 
        }
    }
}
