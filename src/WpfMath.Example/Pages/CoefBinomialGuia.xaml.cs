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

namespace WpfMath.Example.Pages
{
    /// <summary>
    /// Lógica de interacción para CoefBinomialGuia.xaml
    /// </summary>
    public partial class CoefBinomialGuia : Page
    {
        public CoefBinomialGuia()
        {
            InitializeComponent();
        }

        private void Ejercicio1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (ejercicio1.Text == "20")
                {
                    ejercicio1.Background = Brushes.LightGreen;
                }
                else ejercicio1.Background = Brushes.IndianRed;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ejercicio1_resultado.Visibility == Visibility.Visible)
            {
                ejercicio1_resultado.Visibility = Visibility.Collapsed;
            }
            else ejercicio1_resultado.Visibility = Visibility.Visible;
        }

        private void Ejercicio2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (ejercicio2.Text == "28")
                {
                    ejercicio2.Background = Brushes.LightGreen;
                }
                else ejercicio2.Background = Brushes.IndianRed;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (ejercicio2_resultado.Visibility == Visibility.Visible)
            {
                ejercicio2_resultado.Visibility = Visibility.Collapsed;
            }
            else ejercicio2_resultado.Visibility = Visibility.Visible;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (ejercicio3_resultado.Visibility == Visibility.Visible)
            {
                ejercicio3_resultado.Visibility = Visibility.Collapsed;
            }
            else ejercicio3_resultado.Visibility = Visibility.Visible;
        }

        private void Ejercicio3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (ejercicio3.Text == "126")
                {
                    ejercicio3.Background = Brushes.LightGreen;
                }
                else ejercicio3.Background = Brushes.IndianRed;
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (ejercicio4_resultado.Visibility == Visibility.Visible)
            {
                ejercicio4_resultado.Visibility = Visibility.Collapsed;
            }
            else ejercicio4_resultado.Visibility = Visibility.Visible;
        }

        private void Ejercicio4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (ejercicio4.Text == "1140")
                {
                    ejercicio4.Background = Brushes.LightGreen;
                }
                else ejercicio4.Background = Brushes.IndianRed;
            }
        }
    }
}
