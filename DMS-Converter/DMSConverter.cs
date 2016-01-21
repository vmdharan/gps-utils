using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            // Convert based on Degrees-Minutes-Seconds.
            if(rbDMS.Checked)
            {
                try
                {
                    double latDec = 0.0;
                    double longDec = 0.0;

                    // Get the latitude DMS.
                    int latDeg = Convert.ToInt32(tbLatDeg.Text);
                    int latMin = Convert.ToInt32(tbLatMin.Text);
                    double latSec = Convert.ToDouble(tbLatSec.Text);

                    // Get the longitude DMS.
                    int longDeg = Convert.ToInt32(tbLongDeg.Text);
                    int longMin = Convert.ToInt32(tbLongMin.Text);
                    double longSec = Convert.ToDouble(tbLongSec.Text);

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
                    // Display exception.
                }
            }

            // Convert based on Decimal degrees.
            else if(rbDecimal.Checked)
            {
                try
                {
                    double latDec = Convert.ToDouble(tbLatDec.Text);
                    double longDec = Convert.ToDouble(tbLongDec.Text);

                    int latDeg, latMin;
                    double latMin2, latSec;

                    int longDeg, longMin;
                    double longMin2, longSec;

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

                }
            }
        }
    }
}
