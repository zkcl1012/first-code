using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.button1.Click += new System.EventHandler(this.button1_Click);
        }
        private void button1_Click(Object sender, EventArgs e)
        {
            MessageBox.Show("Hello world");
            MessageBox.Show("꿈을 꾸는 문어");
        }
    }
}
