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
using System.Windows.Media.TextFormatting;
using System.Windows.Shapes;

namespace Adv_WPF
{
    /// <summary>
    /// Interaction logic for wpf_events.xaml
    /// </summary>
    public partial class wpf_events : Window
    {
        public wpf_events()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("Saved!");
        }

        private void hello_butt_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("New!");
        }

        private void hello_butt_MouseEnter(object sender, MouseEventArgs e)
        {
            //System.Windows.MessageBox.Show("Hi!!!!");
        }

        private void hello_butt_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void event_window_Loaded(object sender, RoutedEventArgs e)
        {
            //this.hi_butt.Content = "Hi !!!!!!!";
            System.Windows.MessageBox.Show("I'm loading...");
        }

        

        private void event_window_KeyDown(object sender, KeyEventArgs e)
        {
            //System.Windows.MessageBox.Show(e.Key.ToString() );
            this.Title = e.Key.ToString()+"|"+e.SystemKey.ToString();
            //--------------------
            if (e.Key==Key.F2) 
            {
                // System.Windows.MessageBox.Show("I'm F2...");
                Button_Click(sender, e);
            }
            //--------------------
            if (e.Key == Key.F8)
            {
                // System.Windows.MessageBox.Show("I'm F8...");
                hello_butt_Click(sender, e);
            }
            //--------------------
            if (e.Key == Key.Escape)
            {
                this.Close();
            }
            //--------------------
            if (e.SystemKey == Key.F10)
            {
                System.Windows.MessageBox.Show("I'm F10...");
            }
            //--------------------
            if (e.SystemKey == Key.RightAlt)
            {
                System.Windows.MessageBox.Show("I'm RightAlt...");
            }
            //--------------------
        }



        private void event_window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
           System.Windows.MessageBox.Show("Closing...");
        }

        private void first_tbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.Title = this.first_tbox.Text;
        }

        private void first_tbox_GotFocus(object sender, RoutedEventArgs e)
        {
            this.first_tbox.Background = System.Windows.Media.Brushes.Yellow;
        }

        private void first_tbox_LostFocus(object sender, RoutedEventArgs e)
        {
            this.first_tbox.Background = System.Windows.Media.Brushes.White;
        }

        private void second_tbox_GotFocus(object sender, RoutedEventArgs e)
        {
            this.second_tbox.Background = System.Windows.Media.Brushes.Yellow;
        }

        private void second_tbox_LostFocus(object sender, RoutedEventArgs e)
        {
            this.second_tbox.Background = System.Windows.Media.Brushes.White;
        }

        private void third_tbox_GotFocus(object sender, RoutedEventArgs e)
        {
            this.third_tbox.Background = System.Windows.Media.Brushes.Yellow;
        }

        private void third_tbox_LostFocus(object sender, RoutedEventArgs e)
        {
            this.third_tbox.Background = System.Windows.Media.Brushes.White;
        }

        private void edit_butt_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("I'm Button!...");
        }

        private void edit_butt_MouseEnter(object sender, MouseEventArgs e)
        {
            this.edit_butt.FontSize = 20;
        }

        private void edit_butt_MouseLeave(object sender, MouseEventArgs e)
        {
            this.edit_butt.FontSize = 12;
        }

        private void fname_cbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // System.Windows.MessageBox.Show("I Changed!...");
            //this.first_tbox.Text = this.fname_cbox.SelectedIndex.ToString();
            //System.Windows.Controls.ComboBoxItem cbi;
            //cbi = (System.Windows.Controls.ComboBoxItem)this.fname_cbox.SelectedItem;
            //this.second_tbox.Text =cbi.Content.ToString();
        }

        private void show_butt_Click(object sender, RoutedEventArgs e)
        {
            this.first_tbox.Text = this.fname_cbox.SelectedIndex.ToString();
            if (this.fname_cbox.SelectedIndex==-1) 
            {
                System.Windows.MessageBox.Show("Please select your item first!");
                return;
            }
            //-----------------------------
            System.Windows.Controls.ComboBoxItem cbi;
            cbi = (System.Windows.Controls.ComboBoxItem)this.fname_cbox.SelectedItem;
            //---------------------------
            this.second_tbox.Text = cbi.Content.ToString();
        }

        private void fname_listbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //System.Windows.MessageBox.Show("I Changed!...");
            this.first_tbox.Text = this.fname_listbox.SelectedIndex.ToString();
            System.Windows.Controls.ListBoxItem cbi;
            cbi = (System.Windows.Controls.ListBoxItem)this.fname_listbox.SelectedItem;
            this.second_tbox.Text = cbi.Content.ToString();
        }

        private void show_list_butt_Click(object sender, RoutedEventArgs e)
        {
            //System.Windows.MessageBox.Show("I Changed!...");
            this.first_tbox.Text = this.fname_listbox.SelectedIndex.ToString();
            //----------------------------------
            if (this.fname_listbox.SelectedIndex == -1)
            {
                System.Windows.MessageBox.Show("Please select your item first!");
                return;
            }
            //-----------------------------
            System.Windows.Controls.ListBoxItem cbi;
            cbi = (System.Windows.Controls.ListBoxItem)this.fname_listbox.SelectedItem;
            this.second_tbox.Text = cbi.Content.ToString();
        }
    }
}
