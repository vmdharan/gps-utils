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
                    // Get the latitude DMS.
                    int latDeg = Convert.ToInt32(tbLatDeg.Text);
                    int latMin = Convert.ToInt32(tbLatMin.Text);
                    double latSec = Convert.ToDouble(tbLatSec.Text);

                    // Get the longitude DMS.
                    int longDeg = Convert.ToInt32(tbLongDeg.Text);
                    int longMin = Convert.ToInt32(tbLongMin.Text);
                    double longSec = Convert.ToDouble(tbLongSec.Text);

                    // Convert latitude and longitude DMS into decimal.
                    double latDec = latDeg + (latMin / 60.0) + (latSec / 3600.0);
                    double longDec = longDeg + (longMin / 60.0) + (longSec / 3600.0);

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

                    int latDeg = (int) latDec;
                    double latMin2 = (latDec - latDeg) * 60.0;
                    int latMin = (int) latMin2;
                    double latSec = (latMin2 - latMin) * 60.0;

                    int longDeg = (int) longDec;
                    double longMin2 = (longDec - longDeg) * 60.0;
                    int longMin = (int) longMin2;
                    double longSec = (longMin2 - longMin) * 60.0;

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
