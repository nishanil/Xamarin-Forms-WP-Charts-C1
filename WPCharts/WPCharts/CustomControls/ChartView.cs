using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace WPCharts.CustomControls
{
    public class ChartView : View
    {
        public static readonly BindableProperty SelectedChartProperty = BindableProperty.Create<ChartView, ChartType>(p => p.SelectedChart, ChartType.Bar);

        public ChartType SelectedChart {
            get { return (ChartType)GetValue(SelectedChartProperty); }
            set { SetValue(SelectedChartProperty, value); } 
        }
    }

    public enum ChartType { 
        Bar = 0,
        Pie = 1,
        PieDoughnut =2
        //add more if needed
    }
}
