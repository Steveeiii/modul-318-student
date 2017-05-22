using System;
using System.Windows.Forms;
using SwissTransport;
using System.Net;
using System.Collections.Generic;

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
            dgvStandartFahrplan.Rows.Clear();
            dgvStandartFahrplan.Refresh();

            //Suche wird gestartet
            Transport tp = new Transport();
            string datum = dtpDatum.Value.ToString("yyyy-MM-dd");
            string zeit = dtpZeit.Value.ToString("HH:mm");
            Connections connections = tp.GetConnectionsDetailed(cbVon.Text, cbNach.Text, datum, zeit);
            foreach (Connection connection in connections.ConnectionList)
            {

                //DataGrind wird abgefüllt
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

        private void btnWechseln_Click(object sender, EventArgs e)
        {
            //Inhalt der Comboxen wechseln

            String wechselVon = cbVon.Text;
            cbVon.Text = cbNach.Text;
            cbNach.Text = wechselVon;
        }

        private void cbVon_DropDown(object sender, EventArgs e)
        {
            //Helperklasse wird aufgerufen
            HelperClass a = new HelperClass();
            a.autofill(cbVon);

        }

        private void cbNach_DropDown(object sender, EventArgs e)
        {
            //Helperklasse wird aufgerufen
            HelperClass a = new HelperClass();
            a.autofill(cbNach);
        }

        private void btnKarteVon_Click(object sender, EventArgs e)
        {
            if (cbVon.Text != null || cbVon.Text != "")
            {
                HelperClass a = new HelperClass();
                a.browserOeffnen(cbVon);
            }

        }

        private void btnKarteNach_Click(object sender, EventArgs e)
        {
            HelperClass a = new HelperClass();
            a.browserOeffnen(cbNach);
        }

    }
}
