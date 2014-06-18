using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCharts.WinPhone.Renderers
{
    public static class Helpers
    {
        public static C1.Phone.Chart.ChartType ToChartType(this WPCharts.CustomControls.ChartType chartType)
        {
            if (chartType == CustomControls.ChartType.Column)
                return C1.Phone.Chart.ChartType.Column;
           
            if (chartType == CustomControls.ChartType.Bar)
                return C1.Phone.Chart.ChartType.Bar;
            if (chartType == CustomControls.ChartType.Pie)
                return C1.Phone.Chart.ChartType.Pie;
            if (chartType == CustomControls.ChartType.PieDoughnut)
                return C1.Phone.Chart.ChartType.PieDoughnut;

            //default
            return C1.Phone.Chart.ChartType.Column;
        }
    }
}
