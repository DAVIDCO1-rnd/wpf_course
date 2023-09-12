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

namespace Adv_WPF.Panels
{
    /// <summary>
    /// Interaction logic for wpf_panels_window_list.xaml
    /// </summary>
    public partial class wpf_panels_window_list : Window
    {
        public wpf_panels_window_list()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            wpf_canvas_panel frm = new wpf_canvas_panel();
            frm.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            wpf_stack_panel frm = new wpf_stack_panel();
            frm.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            wpf_wrap_panel frm = new wpf_wrap_panel();
            frm.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            wpf_dock_panel frm = new wpf_dock_panel();
            frm.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            wpf_panels_main_window frm = new wpf_panels_main_window();
            frm.Show();
        }
    }
}
