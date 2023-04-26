using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel_btn_Click(object sender, EventArgs e)
        {
            homePanelControl1.Show();
            homePanelControl1.BringToFront();

            panel2UserControl1.Hide();

        }

        public string InputOne
        {

            set
            {
                InputData_text.Text = value;
            }
        }
        
         public string InputTwo {

            set
            {
               InputData2_text.Text = value;
            }
        
            
        }

         public string p2InputOne
         {
             set
             {
                 InputData_text.Text = value;
             }
            
         }

         public string p2InputTwo
         {

             set 
             {
                 InputData2_text.Text = value;
             }

         }


        private void panel2_btn_Click(object sender, EventArgs e)
        {
            panel2UserControl1.Show();
            panel2UserControl1.BringToFront();

            homePanelControl1.Hide();
        }
    }
}
