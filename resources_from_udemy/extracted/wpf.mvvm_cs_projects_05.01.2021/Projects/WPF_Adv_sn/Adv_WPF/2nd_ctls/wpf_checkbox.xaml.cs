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
using System.Windows.Shapes;

namespace Adv_WPF._2nd_ctls
{
    /// <summary>
    /// Interaction logic for wpf_checkbox.xaml
    /// </summary>
    public partial class wpf_checkbox : Window
    {
        public wpf_checkbox()
        {
            InitializeComponent();
        }

        private void enable_cbox_Checked(object sender, RoutedEventArgs e)
        {
            //System.Windows.MessageBox.Show("I checked!");
            this.alert_butt.IsEnabled = this.enable_cbox.IsChecked.Value;
        }

        private void enable_cbox_Unchecked(object sender, RoutedEventArgs e)
        {
            //System.Windows.MessageBox.Show("I'm Unchecked!");
            this.alert_butt.IsEnabled = this.enable_cbox.IsChecked.Value;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.alert_butt.IsEnabled = this.enable_cbox.IsChecked.Value;
            if (this.show_hide_cbox.IsChecked.Value == true)
            {
                this.alert_butt.Visibility = Visibility.Visible;
            }
        }

        private void show_hide_cbox_Checked(object sender, RoutedEventArgs e)
        {
            if (this.show_hide_cbox.IsChecked.Value==true) 
            {
                this.alert_butt.Visibility = Visibility.Visible;
            }
        }

        private void show_hide_cbox_Unchecked(object sender, RoutedEventArgs e)
        {
            if (this.show_hide_cbox.IsChecked.Value == false)
            {
                this.alert_butt.Visibility = Visibility.Hidden;
            }
        }
    }
}
