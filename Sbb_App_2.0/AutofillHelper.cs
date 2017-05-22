using SwissTransport;
using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;

namespace Sbb_App_2._0
{
    public class AutofillHelper
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
    }
}
