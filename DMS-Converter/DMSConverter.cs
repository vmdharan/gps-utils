using System;
using System.Windows.Forms;

namespace DMS_Converter
{
    public partial class DMSConverter : Form
    {
        public DMSConverter()
        {
            InitializeComponent();
        }

        // Perform conversion.
        private void btnConvert_Click(object sender, EventArgs e)
        {
            // Declare variables for decimal latitude and longitude.
            double latDec = 0.0;
            double longDec = 0.0;

            // Declare variables for DMS latitude and longitude.
            int latDeg = 0;
            int latMin = 0;
            double latSec = 0.0;

            int longDeg = 0;
            int longMin = 0;
            double longSec = 0.0;

            // Convert based on Degrees-Minutes-Seconds.
            if (rbDMS.Checked)
            {
                try
                {
                    // Get the latitude DMS.
                    latDeg = Convert.ToInt32(tbLatDeg.Text);
                    latMin = Convert.ToInt32(tbLatMin.Text);
                    latSec = Convert.ToDouble(tbLatSec.Text);

                    // Get the longitude DMS.
                    longDeg = Convert.ToInt32(tbLongDeg.Text);
                    longMin = Convert.ToInt32(tbLongMin.Text);
                    longSec = Convert.ToDouble(tbLongSec.Text);

                    // Convert latitude DMS into decimal.
                    if(latDeg >= 0)
                    {
                        latDec = latDeg + (latMin / 60.0) + (latSec / 3600.0);
                    }
                    // Conversion for negative latitude degrees.
                    else
                    {
                        latDec = latDeg - (latMin / 60.0) - (latSec / 3600.0);
                    }

                    // Convert longitude DMS into decimal.
                    if (longDeg >= 0)
                    {
                        longDec = longDeg + (longMin / 60.0) + (longSec / 3600.0);
                    }
                    // Conversion for negative longitude degrees.
                    else
                    {
                        longDec = longDeg - (longMin / 60.0) - (longSec / 3600.0);
                    }

                    tbLatDec.Text = latDec.ToString();
                    tbLongDec.Text = longDec.ToString();
                }
                catch (Exception ex)
                {
                    // Show exception message.
                    MessageBox.Show(ex.Message);
                }
            }

            // Convert based on Decimal degrees.
            else if(rbDecimal.Checked)
            {
                try
                {
                    latDec = Convert.ToDouble(tbLatDec.Text);
                    longDec = Convert.ToDouble(tbLongDec.Text);

                    double latMin2;
                    double longMin2;

                    // Positive conversion - latitude
                    if(latDec >= 0)
                    {
                        latDeg = (int)latDec;
                        latMin2 = (latDec - latDeg) * 60.0;
                        latMin = (int)latMin2;
                        latSec = (latMin2 - latMin) * 60.0;
                    }
                    // Negative conversion -latitude
                    else
                    {
                        latDeg = (int)latDec;
                        latMin2 = (latDec - latDeg) * -60.0;
                        latMin = (int)latMin2;
                        latSec = (latMin2 - latMin) * 60.0;
                    }

                    // Positive conversion - longitude
                    if(longDec >= 0)
                    {
                        longDeg = (int)longDec;
                        longMin2 = (longDec - longDeg) * 60.0;
                        longMin = (int)longMin2;
                        longSec = (longMin2 - longMin) * 60.0;
                    }
                    // Negative conversion - longitude
                    else
                    {
                        longDeg = (int)longDec;
                        longMin2 = (longDec - longDeg) * -60.0;
                        longMin = (int)longMin2;
                        longSec = (longMin2 - longMin) * 60.0;
                    }

                    tbLatDeg.Text = latDeg.ToString();
                    tbLatMin.Text = latMin.ToString();
                    tbLatSec.Text = latSec.ToString();

                    tbLongDeg.Text = longDeg.ToString();
                    tbLongMin.Text = longMin.ToString();
                    tbLongSec.Text = longSec.ToString();
                }
                catch (Exception ex)
                {
                    // Show exception message.
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
