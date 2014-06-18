using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WinPhone;
using C1.Phone;
using Custom = WPCharts.CustomControls;
using C1.Phone.Chart;

[assembly: ExportRenderer((typeof(Custom.ChartView)), typeof(WPCharts.WinPhone.Renderers.ChatViewRenderer))]
namespace WPCharts.WinPhone.Renderers
{
    public class ChatViewRenderer : ViewRenderer <Custom.ChartView, C1Chart>
    {
        C1Chart chart;

        public ChatViewRenderer()
        {
<<<<<<< HEAD
            chart = new C1Chart();
=======
>>>>>>> origin/master
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Custom.ChartView> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null || this.Element == null)
                return;

<<<<<<< HEAD
=======
            chart = new C1Chart();
>>>>>>> origin/master
            chart.Data.Children.Clear();

            chart.Margin = new System.Windows.Thickness(15, 0, 0, 0);

            // Add Data
            string[] ProductNames = { "Hand Mixer", "Stand Mixer", "Can Opener", "Toaster", "Blender", "Food Processor", "Slow Cooker", "Microwave" };
            int[] PriceX = { 80, 400, 20, 60, 150, 300, 130, 500 };

            // create single series for product price
            DataSeries ds1 = new DataSeries();
            ds1.Label = "Price X";
            //set price data
            ds1.ValuesSource = PriceX;
<<<<<<< HEAD
            chart.Data.Children.Add(ds1);
            // add item names
=======
            // add series to the chart
            chart.Data.Children.Add(ds1);
             // add item names
>>>>>>> origin/master
            chart.Data.ItemNames = ProductNames;
            // Set chart type
            chart.ChartType = ChartType.Bar;
            SetNativeControl(chart);

        }

        protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == Custom.ChartView.SelectedChartProperty.PropertyName)
            {
                if (Control == null || Element == null)
                    return;
		            Control.ChartType = Element.SelectedChart.ToChartType();
                
            }
        }

    }
}
