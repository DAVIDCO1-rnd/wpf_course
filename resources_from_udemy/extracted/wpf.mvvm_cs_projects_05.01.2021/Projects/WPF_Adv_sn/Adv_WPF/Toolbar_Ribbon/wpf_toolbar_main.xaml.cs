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

namespace Adv_WPF.Toolbar_Ribbon
{
    /// <summary>
    /// Interaction logic for wpf_toolbar_main.xaml
    /// </summary>
    public partial class wpf_toolbar_main : Window
    {
        public wpf_toolbar_main()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Adv_WPF.Toolbar_Ribbon.wpf_toolbar frm = new wpf_toolbar();
            frm.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Adv_WPF.Toolbar_Ribbon.wpf_StatusBar frm = new wpf_StatusBar();
            frm.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Adv_WPF.ContextMenu.wpf_contextmenu frm = new Adv_WPF.ContextMenu.wpf_contextmenu();
            frm.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Adv_WPF.Toolbar_Ribbon.wpf_tab_control frm = new wpf_tab_control();
            frm.Show();
        }
    }
}
