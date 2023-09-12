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
    /// Interaction logic for wpf_slider.xaml
    /// </summary>
    public partial class wpf_slider : Window
    {
        public wpf_slider()
        {
            InitializeComponent();
        }

        private void my_slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            // System.Windows.MessageBox.Show("I changed!");
            if (this.value_lbl!=null) 
            {
               this.value_lbl.Content = this.my_slider.Value.ToString();
                this.test_butt.Width = this.my_slider.Value;
            }
           
        }

        private void height_slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (this.value_lbl != null)
            {
                //this.value_lbl.Content = this.my_slider.Value.ToString();
                this.test_butt.Height = this.height_slider.Value;
            }
        }
    }
}
