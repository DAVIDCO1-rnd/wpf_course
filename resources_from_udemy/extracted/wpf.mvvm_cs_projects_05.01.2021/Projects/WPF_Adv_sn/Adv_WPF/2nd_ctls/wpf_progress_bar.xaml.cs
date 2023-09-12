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
    /// Interaction logic for wpf_progress_bar.xaml
    /// </summary>
    public partial class wpf_progress_bar : Window
    {
        public wpf_progress_bar()
        {
            InitializeComponent();
        }

        private void my_prog_bar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (this.prog_lbl!=null) 
            {
                this.prog_lbl.Content = this.my_prog_bar.Value.ToString() + "%";
            }
           
        }

        private void incr_butt_Click(object sender, RoutedEventArgs e)
        {
            this.my_prog_bar.Value = this.my_prog_bar.Value + 5;
            //this.prog_lbl.Content = this.my_prog_bar.Value.ToString()+"%";
        }

        private void desc_butt_Click(object sender, RoutedEventArgs e)
        {
            this.my_prog_bar.Value = this.my_prog_bar.Value - 5;
            //this.prog_lbl.Content = this.my_prog_bar.Value.ToString() + "%";
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.my_prog_bar.Value = 0;
        }
    }
}
