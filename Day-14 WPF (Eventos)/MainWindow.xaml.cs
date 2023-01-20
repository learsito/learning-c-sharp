/*
    RoutedEvents o eventos ruteados. Tipos:
        -Direct
        -Bubbling
        -Tunneling
    RotedEvents son eventos que son enviados desde un objeto hacia otra parte del programa que incluso puede ser el mismo
    objeto, es decir, el evento se va a manifestar en cualquier parte de nuestro programa aunque lo detone un elemento en 
    particular como puede ser un botón. 
    Tenemos tres tipos de RoutedEvent que son conocidos como: 
        -DirectEvent - Que son manejados por el elemento 
        -BubblingEvent - Que suben por el arbol hasta que alguien los maneje
        -TunnelingEvent - Que bajan hasta que alguien los maneje
    Ya se ha visto un evento directo en la clase anterior. 
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

namespace Day_14_WPF__Eventos_
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

        private void Button_Click(object sender, RoutedEventArgs e){
            //MessageBox.Show("El botón ha sido presionado - Direct Event");
            MessageBox.Show("Externo");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e){
            MessageBox.Show("Interno");
        }

        private void Button_MouseUp(object sender, MouseButtonEventArgs e){
            MessageBox.Show("El botón ha sido soltado - Bubbling Event");
        }

        private void Button_PreviewMouseUp(object sender, MouseButtonEventArgs e){
            MessageBox.Show("El botón ha sido soltado - Tunneling Event");
        }

        private void Button_MyNamedButton(object sender, MouseButtonEventArgs e){
            MessageBox.Show("El botón izquierdo ha sido presionado - Tunneling Event");
        }

        private void Button_PreviewMouseRightButtonUp(object sender, MouseButtonEventArgs e){
            MessageBox.Show("El botón derecho ha sido soltado - Tunneling Event");
        }

        private void Button_Tunneling(object sender, MouseButtonEventArgs e){
            MessageBox.Show("Interno1");
        }

    }
}
