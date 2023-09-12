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
    /// Interaction logic for io_folder_info.xaml
    /// </summary>
    public partial class io_folder_info : Window
    {
        public io_folder_info()
        {
            InitializeComponent();
        }

        private void get_info_butt_Click(object sender, RoutedEventArgs e)
        {
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo("E:\\tuts\\Test");
            this.folder_name_tb.Text = di.Name;
            this.parent_folder_tb.Text = di.Parent.Name;
            this.folder_drive_tb.Text = di.Root.Name;
            //--------date and time of folder-----
            this.folder_creation_tb.Text = di.CreationTime.ToString();
            this.folder_last_access_tb.Text = di.LastAccessTime.ToString();
            this.folder_last_modified_tb.Text = di.LastWriteTime.ToString();
            //------------------------------------
        }
    }
}
