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
    public partial class BS_Form : Form
    {
        private LogikStub logik_;
        
        public BS_Form(LogikStub logik,string id)

        {
            logik_ = logik;
            InitializeComponent();
           
            
                List<BS_DTO> bsliste = logik.getBS(id);
            for (int i = 0; i < bsliste.Count; i++)
            {
               
                BS_chart.Series["Blodsukker"].Points.AddXY(bsliste[i].getDateTime(), bsliste[i].getBloodSugar());
            }
            
        }

        private void BS_chart_Click(object sender, EventArgs e)
        {

        }
    }
}
