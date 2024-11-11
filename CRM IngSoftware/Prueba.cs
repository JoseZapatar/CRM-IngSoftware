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
    public partial class Prueba : UserControl
    {
        public Prueba()
        {
            InitializeComponent();
            Label label = new Label();
            label.Text = "Control de prueba";
            label.Location = new System.Drawing.Point(10, 10);
            this.Controls.Add(label);

        }
    }
}
