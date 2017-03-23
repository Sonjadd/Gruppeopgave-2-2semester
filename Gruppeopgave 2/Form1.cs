using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logik; 

namespace Gruppeopgave_2
{
    public partial class Form1 : Form
    {
        LogikStub logik;
        private string id = "cpr";
        private BS_Form BSform;
        private BT_Form BTform;
        private BMI_Form BMIform;
        public Form1()
        {
            InitializeComponent();
            logik = new LogikStub();
            
        }
       
        private void blodsukker_Click(object sender, EventArgs e)
        {
           
            BSform = new BS_Form(logik,id);
            BSform.Show();
        }

        private void blodtryk_Click(object sender, EventArgs e)
        {

            BTform = new BT_Form(logik, id);
            BTform.Show();
        }

        private void BMI_Click(object sender, EventArgs e)
        {
            BMIform = new BMI_Form(logik, id);
            BMIform.Show();
        }
    }
}
