using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for users_window.xaml
    /// </summary>
    public partial class users_window : Window
    {
        public users_window()
        {
            InitializeComponent();
        }

        private void users_wind_Loaded(object sender, RoutedEventArgs e)
        {
            this.user_combo.SelectedIndex = 0;
        }

        private void user_combo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //-------------first user---------------------------
            if (this.user_combo.SelectedIndex==0) 
            {
                this.user_name_tbox.Text = wpf_diary_app.Properties.Settings.Default.user1_name;
                this.user_pass_tbox.Password = wpf_diary_app.Properties.Settings.Default.user1_pass;
            }
            //-------------second user---------------------------
            if (this.user_combo.SelectedIndex == 1)
            {
                this.user_name_tbox.Text = wpf_diary_app.Properties.Settings.Default.user2_name;
                this.user_pass_tbox.Password = wpf_diary_app.Properties.Settings.Default.user2_pass;
            }
            //-------------third user---------------------------
            if (this.user_combo.SelectedIndex == 2)
            {
                this.user_name_tbox.Text = wpf_diary_app.Properties.Settings.Default.user3_name;
                this.user_pass_tbox.Password = wpf_diary_app.Properties.Settings.Default.user3_pass;
            }
            //-----------load selected user image---------------
            //--------------
            String fn;
            fn = Environment.CurrentDirectory + "\\Data\\Pics\\User\\" + this.user_combo.SelectedIndex.ToString() + ".jpg";
           //------------------------------
            if (System.IO.File.Exists(fn)==false) 
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

        private void save_butt_Click(object sender, RoutedEventArgs e)
        {
            //------------------------------
            if (this.user_combo.SelectedIndex == -1) 
            {
                System.Windows.MessageBox.Show("Please select your user!");
                return;
            }
            //------------------------
            if (this.user_pass_tbox.Password!=this.user_pass_confirm_tbox.Password) 
            {
                System.Windows.MessageBox.Show("Please enter the same passwords!");
                return;
            }
            //------------------------------------------------
            //-------------first user---------------------------
            if (this.user_combo.SelectedIndex == 0)
            {
                   wpf_diary_app.Properties.Settings.Default.user1_name= this.user_name_tbox.Text;
                  wpf_diary_app.Properties.Settings.Default.user1_pass= this.user_pass_tbox.Password;
            }
            //-------------second user---------------------------
            if (this.user_combo.SelectedIndex == 1)
            {
                 wpf_diary_app.Properties.Settings.Default.user2_name = this.user_name_tbox.Text;
                  wpf_diary_app.Properties.Settings.Default.user2_pass= this.user_pass_tbox.Password;
            }
            //-------------third user---------------------------
            if (this.user_combo.SelectedIndex == 2)
            {
                  wpf_diary_app.Properties.Settings.Default.user3_name = this.user_name_tbox.Text;
                  wpf_diary_app.Properties.Settings.Default.user3_pass= this.user_pass_tbox.Password;
            }
            //------------------------------
            wpf_diary_app.Properties.Settings.Default.Save();
            //---------save user image ----------------

            String fn;
            fn = Environment.CurrentDirectory + "\\Data\\Pics\\User\\" +  this.user_combo.SelectedIndex.ToString() + ".jpg";
            //-----------------------------------
            if (this.image_img.Source==null) 
            {
                System.Windows.MessageBox.Show("Saved!");
                return;
            }
            //-----------------------------------
            JpegBitmapEncoder je = new JpegBitmapEncoder();
            BitmapSource bms =(BitmapSource)this.image_img.Source;
            //----------------------
            je.Frames.Add(BitmapFrame.Create(bms));
            //----------------------
            using (FileStream fs = new FileStream(fn, FileMode.Create))
            {
                je.Save(fs);
            }
            //-----------------------
                //-----------------------------------------
                System.Windows.MessageBox.Show("Saved!");
        }

        private void sel_image_butt_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog op = new Microsoft.Win32.OpenFileDialog();
            op.Filter = "Jpeg Files|*.jpg|Png Files|*.png";
            op.Title = "Select the user image";
            op.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            //--------------
            op.ShowDialog();
            //--------------
            if (op.FileName=="") 
            {
                return;
            }
            //--------------
            String fn;
            fn = op.FileName;
            System.Uri ur = new Uri(fn);
            //----------------
            BitmapImage bm = new BitmapImage();
            bm.BeginInit();
            bm.CacheOption = BitmapCacheOption.OnLoad;
            bm.UriSource = ur;
            bm.EndInit();
            //----------------
            this.image_img.Source = bm;
        }
    }
}
