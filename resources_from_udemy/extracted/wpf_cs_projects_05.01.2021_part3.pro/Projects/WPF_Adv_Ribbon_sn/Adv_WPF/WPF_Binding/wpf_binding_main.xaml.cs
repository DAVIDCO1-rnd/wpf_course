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

namespace Adv_WPF.WPF_Binding
{
    /// <summary>
    /// Interaction logic for wpf_binding_main.xaml
    /// </summary>
    public partial class wpf_binding_main : Window
    {
        public wpf_binding_main()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            wpf_binding frm = new wpf_binding();
            frm.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            wpf_twoway_binding frm = new wpf_twoway_binding();
            frm.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            wpf_oneway_2_source_binding frm = new wpf_oneway_2_source_binding();
            frm.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            wpf_string_format frm = new wpf_string_format();
            frm.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            wpf_binding_project frm = new wpf_binding_project();
            frm.Show();
        }
    }
}
