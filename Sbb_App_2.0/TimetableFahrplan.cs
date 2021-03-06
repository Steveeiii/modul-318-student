﻿using System;
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

            //Suche wird gestartet
            Transport tp = new Transport();
            Stations stations = tp.GetStations(cbAbfahrtsort.Text);
            foreach (Station station in stations.StationList)
            {
                String id = station.Id;
                StationBoardRoot stationBoardRoot = tp.GetStationBoard(cbAbfahrtsort.Text, id);
                foreach (StationBoard stBoard in stationBoardRoot.Entries)
                {
                    //DataGrind wird abgefüllt
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvTimetableFahrplan);
                    row.Cells[0].Value = stBoard.Name;
                    row.Cells[1].Value = stBoard.To;
                    row.Cells[2].Value = stBoard.Stop.Departure.ToString("HH:mm:ss");

                    dgvTimetableFahrplan.Rows.Add(row);
                }
            }
        }

        private void cbAbfahrtsort_Dropdown(object sender, EventArgs e)
        {
            //Helperklasse wird aufgerufen
            HelperClass a = new HelperClass();
            a.autofill(cbAbfahrtsort);
        }

        private void btnSuchen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Code für Enter Taste
                btnSuchen_Click(this, new EventArgs());
            }
        }
    }
}

