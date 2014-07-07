using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPCharts.CustomControls;

namespace WPCharts
{
	public partial class HomePage
	{
        ChartView charView;
		public HomePage ()
		{
			InitializeComponent ();

            foreach (var chartType in Enum.GetValues(typeof(ChartType)))
            {
                chartPicker.Items.Add(chartType.ToString());
            }
		}

        void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChartType selectedCharType;
            if (Enum.TryParse<ChartType>(chartPicker.Items[chartPicker.SelectedIndex], out selectedCharType))
                chart.SelectedChart = selectedCharType;
        }
	}
}
