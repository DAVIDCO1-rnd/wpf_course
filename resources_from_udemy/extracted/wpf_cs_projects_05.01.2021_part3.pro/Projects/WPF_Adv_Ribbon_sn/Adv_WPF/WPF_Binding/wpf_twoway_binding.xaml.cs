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
    /// Interaction logic for wpf_twoway_binding.xaml
    /// </summary>
    public partial class wpf_twoway_binding : Window
    {
        public wpf_twoway_binding()
        {
            InitializeComponent();
        }

        private void update_butt_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Data.BindingExpression bx;
            bx = this.my_tbox.GetBindingExpression(TextBox.TextProperty);
            bx.UpdateSource();
        }

        private void my_tbox_SourceUpdated(object sender, DataTransferEventArgs e)
        {
            System.Windows.MessageBox.Show("Source is updated!");
        }

        private void my_tbox_TargetUpdated(object sender, DataTransferEventArgs e)
        {
            System.Windows.MessageBox.Show("Target is updated!");
        }
    }
}
