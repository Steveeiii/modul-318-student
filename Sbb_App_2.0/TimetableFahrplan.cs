using System;
using System.Windows.Forms;
using SwissTransport;

namespace Sbb_App_2._0
{
    public partial class TimetableFahrplan : UserControl
    {
        public TimetableFahrplan()
        {
            InitializeComponent();

        }

        private void btnSuchen_Click(object sender, EventArgs e)
        {
            dgvTimetableFahrplan.Rows.Clear();
            dgvTimetableFahrplan.Refresh();
            foreach (DataGridViewRow item in this.dgvTimetableFahrplan.SelectedRows)
            {
                dgvTimetableFahrplan.Rows.RemoveAt(item.Index);
            }
            Transport tp = new Transport();
            Stations stations = tp.GetStations(txtAbfahrtsort.Text);
            foreach (Station station in stations.StationList)
            { 
                DataGridViewRow row = new DataGridViewRow();
                row.Cells[0].Value = station.Name;
                row.Cells[1].Value = 
                row.Cells[2].Value = 

                dgvTimetableFahrplan.Rows.Add(row);
            }
        }
    }
}
