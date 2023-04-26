using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Panel2UserControl : UserControl
    {
        public Panel2UserControl()
        {
            InitializeComponent();
        }

        private void submit2_btn_Click(object sender, EventArgs e)
        {
            var textBox1 = this.textBox1.Text;
            var textBox2 = this.textBox2.Text;

            //Parent
            var parent = this.Parent as Form1;
            parent.p2InputOne = textBox1;
            parent.p2InputTwo = textBox2;
        }
    }
}
