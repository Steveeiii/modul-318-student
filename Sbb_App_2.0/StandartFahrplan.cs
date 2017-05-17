using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace Sbb_App_2._0
{
    public partial class StandartFahrplan : UserControl
    {

        private Transport transport = new Transport();

        public StandartFahrplan()
        {
            InitializeComponent();
        }

        private void btnSuchen_Click(object sender, EventArgs e)
        {

        }
    }
}
