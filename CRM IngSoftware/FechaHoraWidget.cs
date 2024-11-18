using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_IngSoftware
{
    public partial class FechaHoraWidget : UserControl
    {
        public FechaHoraWidget()
        {
            InitializeComponent();
            timerFechaHora.Start();
        }

        private void timerFechaHora_Tick(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy hh:mm:ss tt");
        }
    }
}
