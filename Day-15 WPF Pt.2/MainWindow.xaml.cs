﻿using System;
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

namespace Day_15_WPF_Pt._2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public Suma ObjetoSuma { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            ObjetoSuma = new Suma {Num1 = "1",Num2="3"};
            this.DataContext = ObjetoSuma;
        }
    }
}
