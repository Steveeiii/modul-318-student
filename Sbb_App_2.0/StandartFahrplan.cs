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

        public StandartFahrplan()
        {
            InitializeComponent();
        }

        private void btnSuchen_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dgvStandartFahrplan.SelectedRows)
            {
                dgvStandartFahrplan.Rows.RemoveAt(item.Index);
            }
            Transport tp = new Transport();
            Connections connections = tp.GetConnections(txtVon.Text, txtNach.Text);
            foreach (Connection connection in connections.ConnectionList)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvStandartFahrplan);
                String endDauer = connection.Duration.Remove(0, 3);
                row.Cells[0].Value = connection.From.Station.Name;
                row.Cells[1].Value = connection.To.Station.Name;
                row.Cells[2].Value = Convert.ToDateTime(connection.From.Departure).ToString("HH:mm");
                row.Cells[3].Value = Convert.ToDateTime(connection.To.Arrival).ToString("HH:mm");
                row.Cells[4].Value = Convert.ToDateTime(endDauer).ToString("HH:mm:ss");
                dgvStandartFahrplan.Rows.Add(row);
            }
            

        }
    }
}
