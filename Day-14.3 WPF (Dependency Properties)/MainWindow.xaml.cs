/*
Propiedades de dependencia o dependency properties.
    Este tema será de suma importancia para el siguiente tema que será Data Binding.
    
*/

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

namespace Day_14_WPF__Dependency_Properties_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public int ColorDeOjos{
            get {return (int)GetValue(ColorDeOjosProperty);}
            set {SetValue(ColorDeOjosProperty,value);  }
        }

        public static readonly DependencyProperty ColorDeOjosProperty = DependencyProperty.Register("ColorDeOjos",typeof(int),typeof(MainWindow),new PropertyMetadata(0)); //Creando una Dependency Property

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
