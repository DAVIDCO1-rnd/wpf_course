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

namespace wpf_diary_app
{
    /// <summary>
    /// Interaction logic for about_us.xaml
    /// </summary>
    public partial class about_us : Window
    {
        public about_us()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.FileVersionInfo fv;
            string fn = Environment.CurrentDirectory + "\\wpf_diary_app.exe";
            fv = System.Diagnostics.FileVersionInfo.GetVersionInfo(fn);
            //-------------------------
            this.company_lbl.Content = fv.CompanyName;
            this.version_lbl.Content = fv.FileVersion;
            this.product_name_lbl.Content=fv.ProductName;
            this.web_site_lbl.Content = fv.Comments;
            this.Trademark_lbl.Content = fv.LegalTrademarks;
            this.copy_right_lbl.Content = fv.LegalCopyright;
            //-------------------------
        }
    }
}
