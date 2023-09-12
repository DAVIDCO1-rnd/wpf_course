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
    /// Interaction logic for login_window.xaml
    /// </summary>
    public partial class login_window : Window
    {
        public login_window()
        {
            InitializeComponent();
        }

        private void cancel_butt_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        private void save_butt_Click(object sender, RoutedEventArgs e)
        {
            //----------------------
            if (this.user_pass_tbox.Password=="") 
            {
                System.Windows.MessageBox.Show("Please enter the password!");
                return;
            }
            //----------------------
            string org_pass;
            org_pass = "not_defined";
            //------------------
            if (this.user_combo.SelectedIndex==0)
            {
                org_pass = wpf_diary_app.Properties.Settings.Default.user1_pass;
            }
            //----------------------
            if (this.user_combo.SelectedIndex == 1)
            {
                org_pass = wpf_diary_app.Properties.Settings.Default.user2_pass;
            }
            //----------------------
            if (this.user_combo.SelectedIndex == 2)
            {
                org_pass = wpf_diary_app.Properties.Settings.Default.user3_pass;
            }
            //----------------------
            if ( this.user_pass_tbox.Password!= org_pass)
            {
                System.Windows.MessageBox.Show("Password is not correct!");
                return;
            }
            //----------------------
            this.DialogResult = true;
        }

        private void login_wind_Loaded(object sender, RoutedEventArgs e)
        {
            this.user_combo.Items.Add(wpf_diary_app.Properties.Settings.Default.user1_name);
            this.user_combo.Items.Add(wpf_diary_app.Properties.Settings.Default.user2_name);
            this.user_combo.Items.Add(wpf_diary_app.Properties.Settings.Default.user3_name);
            //-----set default user------------------
            this.user_combo.SelectedIndex = 0;
            //----------------------------------------
        }

        private void user_combo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //--------------
            String fn;
            fn = Environment.CurrentDirectory + "\\Data\\Pics\\User\\" + this.user_combo.SelectedIndex.ToString() + ".jpg";
            //------------------------------
            if (System.IO.File.Exists(fn) == false)
            {
                return;
            }
            //-----------------------------
            System.Uri ur = new Uri(fn);
            //----------------
            BitmapImage bm = new BitmapImage();
            bm.BeginInit();
            bm.CacheOption = BitmapCacheOption.OnLoad;
            bm.UriSource = ur;
            bm.EndInit();
            //----------------
            this.image_img.Source = bm;
            //--------------------------------------------------
        }
    }
}
