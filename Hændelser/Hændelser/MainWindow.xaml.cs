using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Hændelser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        float cur;
        string curss = "";
        
        // Udregnings knap
        void submit_Click(object sender, RoutedEventArgs e)
        {
            string str = input.Text;
            float Input = float.Parse(str);
            output.Content = Input * cur + curss;

        }

        /* Knapper for skift mellem valuta */
        // Knappernes funktioner ved udregning fra anden valuta til Dansk
        void euro_Click(object sender, RoutedEventArgs e)
        {
            cur = 7.47f;
            regn.Content = "Du regner nu fra EUR til DKK";
            curss = " Kr.";
        }

        void usd_Click(object sender, RoutedEventArgs e)
        {
            cur = 6.76f;
            regn.Content = "Du regner nu fra USD til DKK";
            curss = " Kr.";
        }

        void jpy_Click(object sender, RoutedEventArgs e)
        {
            cur = 0.062f;
            regn.Content = "Du regner fra JPY til DKK";
            curss = " Kr.";
        }

        // Udregning fra Dansk til anden valuta
        void eurot_Click(object sender, RoutedEventArgs e)
        {
            cur = 0.13f;
            regn.Content = "Du regner nu fra DKK til EUR";
            curss = " €";
        }

        void usdt_Click(object sender, RoutedEventArgs e)
        {
            cur = 0.15f;
            regn.Content = "Du regner nu fra DKK til USD";
            curss = " $";
        }

        void jpyt_Click(object sender, RoutedEventArgs e)
        {
            cur = 16.08f;
            regn.Content = "Du regner nu fra DKK til JPY";
            curss = " ¥";
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
