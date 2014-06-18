using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WPCharts.CustomControls;
using Xamarin.Forms;

namespace WPCharts
{
    public class App
    {
        public static Page GetMainPage()
        {
            return new ChartPage();
        }
    }

    public class ChartPage : ContentPage
    {
        ChartView chart;
        Picker picker;
        public ChartPage()
        {
            Grid grid = new Grid
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Padding = new Thickness(20),
                RowDefinitions = 
                {
                    new RowDefinition() {Height = 80},

                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                }
                ,
                ColumnDefinitions = {
                     new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    
                }

            };

            picker = new Picker
            {

                Title = "Chart Type",
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            foreach (var chartType in Enum.GetValues(typeof(ChartType)))
            {
                picker.Items.Add(chartType.ToString());
            }

            picker.SelectedIndex = 0;
            picker.SelectedIndexChanged += picker_SelectedIndexChanged;
            grid.Children.Add(picker);
            grid.Children.Add(chart = new ChartView(), 0, 1);

            this.Content = grid;
        }

        void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChartType selectedCharType;
            if (Enum.TryParse<ChartType>(picker.Items[picker.SelectedIndex], out selectedCharType))
                chart.SelectedChart = selectedCharType;
        }


    }
}
