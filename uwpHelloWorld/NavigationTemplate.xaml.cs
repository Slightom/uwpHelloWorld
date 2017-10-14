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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace uwpHelloWorld
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class NavigationTemplate : Page
    {
        public NavigationTemplate()
        {
            this.InitializeComponent();
            MyFrame.Navigate(typeof(Page1));
        }


        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //Button myButton = new Button();
            //myButton.Name = "ClickMeButton";
            //myButton.Content = "Click Me";
            //myButton.Width = 400;
            //myButton.Height = 100;
            //myButton.Margin = new Thickness(20, 20, 0, 0);
            //myButton.HorizontalAlignment = HorizontalAlignment.Left;
            //myButton.VerticalAlignment = VerticalAlignment.Top;
            //myButton.Background = new SolidColorBrush(Windows.UI.Colors.Red);
            //myButton.Click += ClickMeButton_Click;

            //LayoutGrid.Children.Add(myButton);
        }



        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(Page1));
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (MyFrame.CanGoBack)
            {
                MyFrame.GoBack();
            }
        }

        private void ForwardButton_Click(object sender, RoutedEventArgs e)
        {
            if (MyFrame.CanGoForward)
            {
                MyFrame.GoForward();
            }
        }

        private void NavigationButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Page2));
        }
    }
}
