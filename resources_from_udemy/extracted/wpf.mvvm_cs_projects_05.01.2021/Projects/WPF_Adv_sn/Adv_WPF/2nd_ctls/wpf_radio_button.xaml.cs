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
    /// Interaction logic for wpf_radio_button.xaml
    /// </summary>
    public partial class wpf_radio_button : Window
    {
        public wpf_radio_button()
        {
            InitializeComponent();
        }

        private void female_rbutt_Checked(object sender, RoutedEventArgs e)
        {
            this.female_grid.Visibility = Visibility.Visible;
        }

        private void female_rbutt_Unchecked(object sender, RoutedEventArgs e)
        {
            this.female_grid.Visibility = Visibility.Hidden;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.female_grid.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (this.female_rbutt.IsChecked.Value==true) 
            {
                if (this.female_combobox.SelectedIndex==-1) 
                {
                    System.Windows.MessageBox.Show("Please select female user type!");
                    return;
                }
                //----------------------------
                //Your code!
                System.Windows.MessageBox.Show("It's done!");
                //----------------------------
            }
            //-------------------
            //Your code!
            //-------------------
        }
    }
}
