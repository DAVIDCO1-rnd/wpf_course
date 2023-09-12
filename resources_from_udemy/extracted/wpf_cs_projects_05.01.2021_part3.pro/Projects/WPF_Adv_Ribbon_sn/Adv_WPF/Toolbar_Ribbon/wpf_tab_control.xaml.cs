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
    /// Interaction logic for wpf_tab_control.xaml
    /// </summary>
    public partial class wpf_tab_control : Window
    {
        public wpf_tab_control()
        {
            InitializeComponent();
        }

        private void tab_ctl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Int32 si;
            si = this.tab_ctl.SelectedIndex;
            //---------------------
            if (si==0) 
            {
                this.sel_tab_item_lbl.Content ="Selected Tab is: "+ "Application";
            }
            //--------------------
            //---------------------
            if (si == 1)
            {
                this.sel_tab_item_lbl.Content = "Selected Tab is: " + "Settings";
            }
            //--------------------
            //---------------------
            if (si == 2)
            {
                this.sel_tab_item_lbl.Content = "Selected Tab is: " + "Display";
            }
            //--------------------
            //---------------------
            if (si == 3)
            {
                this.sel_tab_item_lbl.Content = "Selected Tab is: " + "About";
            }
            //--------------------
        }
    }
}
