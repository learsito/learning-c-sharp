/*
    Data Binding o Enlace de datos.
    Existen cuatro modos de hacer Data Binding, y esto depende de la direccionalidad que tenga ese
    enlace:

    -One way: Del origen al destino.
    -TwoWay: Puede ir tanto del origen al destino como del destino al origen. 
    -OneWayToSource: 'Una Mano hacia la fuente', Del destino al origen.
    -OneTime: desde el origen al destino, pero solo sucede una vez y deja de establecerse esa
     conección si se modifican los datos. Esto es porque esto se configura directamente en el constructor 
     del objeto, ya nace enlazado, pero después no se sostiene más ese enlace.
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

namespace Day_14._4_WPF__Data_Binding_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MySlider.Value = 30;
            MyTextBox.Text = MySlider.Value.ToString();
        }
    }
}
