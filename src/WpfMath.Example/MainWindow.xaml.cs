using System.Windows;
using System.Windows.Controls;
using System.Text;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace WpfMath.Example;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void sidebar_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
                var selected = sidebar.SelectedItem as NavButton;

        navframe.Navigate(selected.Navlink);
    }
    private void Button_Click(object sender, RoutedEventArgs e)
    {
        if (menuText.Visibility == Visibility.Collapsed)
        {
            menuText.Visibility = Visibility.Visible;
        }
        else menuText.Visibility = Visibility.Collapsed;

    }
}
