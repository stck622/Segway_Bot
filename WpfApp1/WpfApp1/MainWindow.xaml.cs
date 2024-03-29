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

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void P_SLIDER_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            P_TEXT.Text = ((float)P_SLIDER.Value).ToString();
        }

        private void P_SLIDER_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            P_TEXT.Text = ((float)P_SLIDER.Value).ToString();
        }

        private void P_TEXT_FocusableChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            P_SLIDER.Value = Convert.ToDouble(P_TEXT.Text);
        }
    }
}
   