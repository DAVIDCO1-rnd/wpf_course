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
    /// Interaction logic for wpf_ribbon.xaml
    /// </summary>
    public partial class wpf_ribbon : Window
    {
        public wpf_ribbon()
        {
            InitializeComponent();
        }

        private void cut_butt_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("I'm cut button!");
        }

        private void copy_butt_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("I'm copy button!");
        }

        private void paste_menu_butt_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("I'm paste menubutton!");
        }

        private void paste_menu_butt_Checked(object sender, RoutedEventArgs e)
        {
            
            System.Windows.Controls.Ribbon.RibbonMenuItem mi;
            mi = (System.Windows.Controls.Ribbon.RibbonMenuItem)sender;
            //---------------
            if (mi.IsChecked==true) 
            {
                System.Windows.MessageBox.Show("paste menubutton is checked!");
            }
             
        }

        private void paste_menu_butt_Unchecked(object sender, RoutedEventArgs e)
        {
           
                //---------------
            if (this.paste_menu_butt.IsChecked == false)
            {
                System.Windows.MessageBox.Show("paste menubutton is unchecked!");
            }
        }

        private void exit_butt_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
