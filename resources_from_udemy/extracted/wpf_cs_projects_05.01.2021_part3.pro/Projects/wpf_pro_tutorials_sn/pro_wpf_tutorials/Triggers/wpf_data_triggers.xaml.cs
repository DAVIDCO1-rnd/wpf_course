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
using System.Windows.Shapes;

namespace pro_wpf_tutorials.Triggers
{
    /// <summary>
    /// Interaction logic for wpf_data_triggers.xaml
    /// </summary>
    public partial class wpf_data_triggers : Window
    {
        public wpf_data_triggers()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            pro_wpf_tutorials.Triggers.wpf_triggers frm = new wpf_triggers();
            frm.Show();
        }
    }
}
