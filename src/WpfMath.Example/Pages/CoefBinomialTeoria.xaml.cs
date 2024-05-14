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
using Microsoft.Win32;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.Xaml.Behaviors.Core;
using WpfMath.Converters;
using WpfMath.Parsers;
using WpfMath.Rendering;
using XamlMath;
using XamlMath.Exceptions;

namespace WpfMath.Example.Pages{
    /// <summary>
    /// Lógica de interacción para CoefBinomialTeoria.xaml
    /// </summary>
    public partial class CoefBinomialTeoria : Page
    {
        public CoefBinomialTeoria()
        {
            InitializeComponent();
        }    
    }
}
