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
    /// Interaction logic for adv_io_file_folder.xaml
    /// </summary>
    public partial class io_file_info : Window
    {
        public io_file_info()
        {
            InitializeComponent();
        }

        private void get_info_butt_Click(object sender, RoutedEventArgs e)
        {
            //System.IO.FileInfo fi = new System.IO.FileInfo("E:\\tuts\\Koala.jpg");
            System.IO.FileInfo fi = new System.IO.FileInfo(this.file_path_tb.Text );
            this.file_creation_tb.Text = fi.CreationTime.ToString();
            this.file_last_access_tb.Text=  fi.LastAccessTime.ToString();
            this.file_last_modified_tb.Text = fi.LastWriteTime.ToString();
            //------------------------------------
            this.file_name_tb.Text = fi.Name;
            this.file_folder_tb.Text = fi.DirectoryName;
            this.file_drive_tb.Text = fi.Directory.Root.Name;
            this.file_ext_tb.Text = fi.Extension;
            //-------------------------------------
            double d,r;
            d = fi.Length;
            r = d / 1024;
            //---------------------
            this.file_size_tb.Text = r.ToString("N2") +" KB";
        }

        private void browse_butt_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog od = new Microsoft.Win32.OpenFileDialog();
            od.ShowDialog();
            //-----------------
            this.file_path_tb.Text = od.FileName;
        }
    }
}
