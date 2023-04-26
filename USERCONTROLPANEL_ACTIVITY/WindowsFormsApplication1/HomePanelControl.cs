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
    public partial class HomePanelControl : UserControl
    {
        public HomePanelControl()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            var InputBox1_text = this.InputBox1_text.Text;
            var InputBox2_text = this.InputBox2_text.Text;

            //Parent
            var parent = this.Parent as Form1;
            parent.InputOne = InputBox1_text;
            parent.InputTwo = InputBox2_text;
        }
    }
}
