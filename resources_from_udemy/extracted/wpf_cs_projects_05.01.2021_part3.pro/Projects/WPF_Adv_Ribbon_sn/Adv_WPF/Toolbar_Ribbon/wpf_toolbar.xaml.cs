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
    /// Interaction logic for wpf_toolbar.xaml
    /// </summary>
    public partial class wpf_toolbar : Window
    {
        public wpf_toolbar()
        {
            InitializeComponent();
        }

        private void undo_butt_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("I'm undo button!");
        }

        private void copy_butt_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("I'm copy button!");
        }

        private void cut_butt_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("I'm cut button!");
        }

        private void paste_butt_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("I'm paste button!");
        }
    }
}
