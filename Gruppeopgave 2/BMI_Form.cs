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
using DTO;

namespace Gruppeopgave_2
{
    public partial class BMI_Form : Form
    {
        private LogikStub logik_;
        public BMI_Form(LogikStub logik, string id)
        {
            logik_ = logik;
            InitializeComponent();

            List<Vægt_DTO> vægtliste = logik.getVægt(id);
            for (int i = 0; i < vægtliste.Count; i++)
            {

                BMI_chart.Series["Vægt"].Points.AddXY(vægtliste[i].getDateTime(), vægtliste[i].getWeight());
                BMI_chart.Series["BMI"].Points.AddXY(vægtliste[i].getDateTime(), vægtliste[i].getBMI());
            }
        }

        private void BMI_chart_Click(object sender, EventArgs e)
        {

        }
    }
}
