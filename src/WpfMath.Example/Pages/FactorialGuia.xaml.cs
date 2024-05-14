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
    /// Lógica de interacción para FactorialGuia.xaml
    /// </summary>
    public partial class FactorialGuia : Page
    {
        public FactorialGuia()
        {
            InitializeComponent();
        }

        private void Ejercicio1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (ejercicio1.Text == "120")
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
    }
}
