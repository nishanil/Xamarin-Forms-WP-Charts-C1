using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WinPhone;
using C1.Phone;
using custom = WPCharts.CustomControls;
using C1.Phone.Chart;

[assembly: ExportRenderer((typeof(custom.ChartView)), typeof(WPCharts.WinPhone.Renderers.ChatViewRenderer))]
namespace WPCharts.WinPhone.Renderers
{
    public class ChatViewRenderer : ViewRenderer <custom.ChartView, C1Chart>
    {
        C1Chart chart;

        public ChatViewRenderer()
        {




        }

        protected override void OnModelSet()
        {
            base.OnModelSet();

             chart = new C1Chart();
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



            // add series to the chart

            chart.Data.Children.Add(ds1);



            // add item names

            chart.Data.ItemNames = ProductNames;



            // Set chart type

            chart.ChartType = ChartType.Bar;

            SetNativeControl(chart);
        }


        protected override void HandlePropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == custom.ChartView.SelectedChartProperty.PropertyName)
            {
                var chartView = (custom.ChartView)sender;
                if (chartView != null)
                {
                    if (chartView.SelectedChart == custom.ChartType.Bar)
                        chart.ChartType = ChartType.Bar;
                    if (chartView.SelectedChart == custom.ChartType.Pie)
                        chart.ChartType = ChartType.Pie;
                    if (chartView.SelectedChart == custom.ChartType.PieDoughnut)
                        chart.ChartType = ChartType.PieDoughnut;
                }
            }
            base.HandlePropertyChanged(sender, e);
        }
    }
}
