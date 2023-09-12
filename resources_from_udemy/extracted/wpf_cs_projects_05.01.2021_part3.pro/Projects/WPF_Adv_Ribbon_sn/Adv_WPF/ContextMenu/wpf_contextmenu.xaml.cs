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

namespace Adv_WPF.ContextMenu
{
    /// <summary>
    /// Interaction logic for wpf_contextmenu.xaml
    /// </summary>
    public partial class wpf_contextmenu : Window
    {
        public wpf_contextmenu()
        {
            InitializeComponent();
        }

        private void Exit_app_cm_Click(object sender, RoutedEventArgs e)
        {
            //System.Windows.MessageBox.Show("I'm exit Button!");
            //this.Close();
            Application.Current.Shutdown();
        }

        private void cut_cm_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("I'm cut Button!");
        }

        private void copy_cm_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("I'm copy Button!");
        }

        private void paste_cm_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("I'm paste Button!");
        }

        private void wind_exit_cm_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("I'm window exit Button!");
        }

        private void wind_about_cm_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("I'm window about Button!");
        }

        private void show_cm_butt_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.ContextMenu cm;
            cm = (System.Windows.Controls.ContextMenu)this.FindResource("com_cm");
            cm.IsOpen = true;
            
        }
    }
}
