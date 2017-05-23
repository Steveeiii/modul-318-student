using SwissTransport;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;

namespace Sbb_App_2._0
{
    public class HelperClass
    {
        public void autofill(ComboBox cbBox)
        {
            try
            {
                String suchText = cbBox.Text;
                Transport tp = new Transport();
                Stations stationen = tp.GetStations(suchText);
                if (suchText.Length <= 3)
                    return;
                cbBox.Items.Clear();

                //Liste wird abgefüllt in comboBox
                List<Station> stationList = tp.GetStations(suchText).StationList;
                foreach (Station station in stationList)
                    cbBox.Items.Add(station.Name);
            }
            catch (WebException fehlerObjekt)
            {
                MessageBox.Show("Sie haben zu viele Serveranfragen auf einmal gestellt.\nBitte versuchen Sie es erneut!\n\n" + fehlerObjekt.Message, "Zu viele Anfragen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        public void browserOeffnen(ComboBox cbBox)
        {
            //Suche wird gestartet
            Transport tp = new Transport();
            Stations stationVon = tp.GetStations(cbBox.Text);
            foreach (Station station in stationVon.StationList)
            {
                //Google Maps wird geöffnet und nach Koordinaten gefiltert
                Coordinate cordinates = station.Coordinate;
                string xValue = cordinates.XCoordinate.ToString().Replace(",", ".");
                string yValue = cordinates.YCoordinate.ToString().Replace(",", ".");
                string url = "https://www.google.ch/maps/?q=loc:" + xValue + "+" + yValue;
                Process.Start(url);
            }
        }
    }
}
