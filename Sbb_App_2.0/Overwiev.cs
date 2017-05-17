using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sbb_App_2._0
{
    public partial class Overview : Form
    {
        public Overview()
        {
            InitializeComponent();
        }

        private void btnStandart_Click(object sender, EventArgs e)
        {
            userControlPanel.Controls.Clear();
            var standartFahrplan = new StandartFahrplan();
            standartFahrplan.Anchor = AnchorStyles.Right;
            standartFahrplan.Anchor = AnchorStyles.Left;
            standartFahrplan.Anchor = AnchorStyles.Top;
            userControlPanel.Controls.Add(standartFahrplan);
        }

        private void btnTimetable_Click(object sender, EventArgs e)
        {
            userControlPanel.Controls.Clear();
            var timeTableFahrplan = new TimetableFahrplan();
            timeTableFahrplan.Anchor = AnchorStyles.Right;
            timeTableFahrplan.Anchor = AnchorStyles.Left;
            timeTableFahrplan.Anchor = AnchorStyles.Top;
            userControlPanel.Controls.Add(timeTableFahrplan);
        }
    }
}
