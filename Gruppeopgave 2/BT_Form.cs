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
    public partial class BT_Form : Form
    {
        private LogikStub logik_;
        public BT_Form(LogikStub logik, string id)
        {
            logik_ = logik;
            InitializeComponent();

            List<BT_DTO> btliste = logik.getBT(id);
            for (int i = 0; i < btliste.Count; i++)
            {

                BT_chart.Series["Systole"].Points.AddXY(btliste[i].getDateTime(), btliste[i].getSys());
                BT_chart.Series["Diastole"].Points.AddXY(btliste[i].getDateTime(), btliste[i].getDia());
            }
        }

        private void BT_chart_Click(object sender, EventArgs e)
        {

        }
    }
}
