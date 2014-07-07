using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace WPCharts.CustomControls
{
    public class ChartView : View
    {
        public ChartView()
        {

        }
        public static readonly BindableProperty SelectedChartProperty = BindableProperty.Create<ChartView, ChartType>(p => p.SelectedChart, ChartType.Bar);

        public static readonly BindableProperty ValuesProperty = BindableProperty.Create<ChartView, IEnumerable>(p => p.Values, null);

        public static readonly BindableProperty ItemNamesProperty = BindableProperty.Create<ChartView, IEnumerable>(p => p.ItemNames, null);

        public static readonly BindableProperty ValuesLabelProperty = BindableProperty.Create<ChartView, string>(p => p.ValuesLabel, string.Empty);


        public ChartType SelectedChart {
            get { return (ChartType)GetValue(SelectedChartProperty); }
            set { SetValue(SelectedChartProperty, value); } 
        }

        public IEnumerable Values
        {
            get { return (IEnumerable)GetValue(ValuesProperty); }
            set { SetValue(ValuesProperty, value); }
        }

        public string ValuesLabel
        {
            get { return (string)GetValue(ValuesLabelProperty); }
            set { SetValue(ValuesLabelProperty, value); }
        }

        public IEnumerable ItemNames
        {
            get { return (IEnumerable)GetValue(ItemNamesProperty); }
            set { SetValue(ItemNamesProperty, value); }
        }


    }

    public enum ChartType { 
        Column = 0,
        Bar = 1,
        Pie = 2,
        PieDoughnut = 3
        //add more if needed
    }
}
