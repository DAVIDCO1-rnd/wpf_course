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
    /// Interaction logic for wpf_main_ctls.xaml
    /// </summary>
    public partial class wpf_main_ctls : Window
    {
        public wpf_main_ctls()
        {
            InitializeComponent();
        }

        private void Check_Box_butt_Click(object sender, RoutedEventArgs e)
        {
            Adv_WPF._2nd_ctls.wpf_checkbox frm = new wpf_checkbox();
            frm.Show();
        }

        private void Border_butt_Click(object sender, RoutedEventArgs e)
        {
            Adv_WPF._2nd_ctls.wpf_border frm = new wpf_border();
            frm.Show();
        }

        private void Password_Box_butt_Click(object sender, RoutedEventArgs e)
        {
            Adv_WPF._2nd_ctls.wpf_password_tbox frm = new wpf_password_tbox();
            frm.Show();
        }

        private void Radio_Button_butt_Click(object sender, RoutedEventArgs e)
        {
            Adv_WPF._2nd_ctls.wpf_radio_button frm = new wpf_radio_button();
            frm.Show();
        }

        private void Progress_Bar_butt_Click(object sender, RoutedEventArgs e)
        {
            Adv_WPF._2nd_ctls.wpf_progress_bar frm = new wpf_progress_bar();
            frm.Show();

        }

        private void Slider_butt_Click(object sender, RoutedEventArgs e)
        {
            Adv_WPF._2nd_ctls.wpf_slider frm = new wpf_slider();
            frm.Show();
        }

        private void Group_Box_butt_Click(object sender, RoutedEventArgs e)
        {
            Adv_WPF._2nd_ctls.wpf_groupbox frm = new wpf_groupbox();
            frm.Show();
        }
    }
}
