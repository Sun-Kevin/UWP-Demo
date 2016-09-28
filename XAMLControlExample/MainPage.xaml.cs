using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace XAMLControlExample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private string[] searchitem = { "sunkai", "jiangjie", "guyuting", "fengweixiang", "libowen", "haohe", "sunmiao" };
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void calendarview_SelectedDatesChanged(CalendarView sender, CalendarViewSelectedDatesChangedEventArgs args)
        {
            var date = sender.SelectedDates.Select(d => d.Month + "/" + d.Day).ToArray();
            calendarviewresult.Text = string.Join(",", date);
        }

        private void innerflyoutbutton_Click(object sender, RoutedEventArgs e)
        {
            flyout.Hide();
        }

        private void autosuggestbox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (!string.IsNullOrEmpty(sender.Text))
            {
                var filter = searchitem.Where(s => s.StartsWith(sender.Text, StringComparison.CurrentCultureIgnoreCase)).ToArray();
                sender.ItemsSource = filter;
            }
            else { sender.ItemsSource = null; }
        }
    }
}
