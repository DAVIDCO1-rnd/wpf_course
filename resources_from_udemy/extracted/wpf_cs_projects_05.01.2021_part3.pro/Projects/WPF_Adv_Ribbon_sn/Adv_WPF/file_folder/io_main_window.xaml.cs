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

namespace Adv_WPF.file_folder
{
    /// <summary>
    /// Interaction logic for io_main_window.xaml
    /// </summary>
    public partial class io_main_window : Window
    {
        public io_main_window()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Adv_WPF.file_folder.io_file_folder f = new io_file_folder();
            f.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Adv_WPF.file_folder.io_file_info f = new io_file_info();
            f.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Adv_WPF.file_folder.io_folder_info f = new io_folder_info();
            f.Show();
        }
    }
}
