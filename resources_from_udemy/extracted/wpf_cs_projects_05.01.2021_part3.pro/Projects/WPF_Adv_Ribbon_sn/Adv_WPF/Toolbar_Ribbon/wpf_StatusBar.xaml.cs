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
    /// Interaction logic for wpf_StatusBar.xaml
    /// </summary>
    public partial class wpf_StatusBar : Window
    {
        public wpf_StatusBar()
        {
            InitializeComponent();
        }

        private void st_butt_info_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("I'm info button!");
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //----------------------------
            if (this.text_tbox == null)
            {
                return;
            }
            //----------------------------
            //System.Windows.MessageBox.Show("I'm zoom Combobox!");
            if (this.zoom_combo.SelectedIndex==0) //50%
            {
                this.text_tbox.FontSize =7;
            }
            if (this.zoom_combo.SelectedIndex == 1)//75%
            {
                this.text_tbox.FontSize =10;
            }
            if (this.zoom_combo.SelectedIndex == 2)//100%
            {
                this.text_tbox.FontSize =14;
            }
            if (this.zoom_combo.SelectedIndex == 3)//125%
            {
                this.text_tbox.FontSize =18;
            }
            if (this.zoom_combo.SelectedIndex == 4)//150%
            {
                this.text_tbox.FontSize =21;
            }
        }

        private void text_tbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.count_lbl.Content = this.text_tbox.Text.Length.ToString();
        }
    }
}
