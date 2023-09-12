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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace wpf_diary_app
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void pic_cbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                String fn;
                fn = Environment.CurrentDirectory + "\\Data\\Pics\\" + (this.pic_cbox.SelectedIndex + 1).ToString() + ".jpg";
                System.Uri ur = new Uri(fn);
                System.Windows.Media.ImageBrush im = new ImageBrush(new BitmapImage(ur));
                im.Stretch = Stretch.Fill;
                this.Background = im;
                //------------ Save settings---------------
                wpf_diary_app.Properties.Settings.Default.sel_image_main_window = this.pic_cbox.SelectedIndex;
                wpf_diary_app.Properties.Settings.Default.Save();
                //-----------------------------------------
                
            }
            catch (Exception ex)
            {

                System.Windows.MessageBox.Show("Error:" + ex.Message);
            }
          
        }
    
        private void main_window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                //--------show login window---------------------
                wpf_diary_app.login_window frm = new login_window();
                frm.Topmost = true;
                frm.ShowDialog();
                // MessageBox.Show(frm.DialogResult.ToString());

                if (frm.DialogResult == false)
                {
                    MessageBox.Show("Have a nice day!");
                    this.Close();
                }
                //-----------------
                if (frm.DialogResult == true)
                {
                    //===========the user selected the ok button=================================
                    //----------------------------------------------
                    Int32 fi;

                    fi = wpf_diary_app.Properties.Settings.Default.sel_image_main_window;
                    //------------------------
                    //////String fn;
                    //////fn = Environment.CurrentDirectory + "\\Data\\Pics\\" + (fi + 1).ToString() + ".jpg";
                    //////System.Uri ur = new Uri(fn);
                    //////System.Windows.Media.ImageBrush im = new ImageBrush(new BitmapImage(ur));
                    //////im.Stretch = Stretch.Fill;
                    //////this.Background = im;
                    //---------------------------
                    this.pic_cbox.SelectedIndex = fi;
                    //---------------------------
                    //---------update digital clock------
                    this.time_lbl.Content = "...";
                    DispatcherTimer t = new DispatcherTimer();
                    t.Interval = new System.TimeSpan(0, 0, 1);
                    t.Tick += time_update;
                    t.Start();
                    //-----------------------------------
                    //--------------update cal-----------
                    this.year_lbl.Content = System.DateTime.Now.Year.ToString();

                    //------------get the day in month------
                    this.day_in_month_lbl.Content = System.DateTime.Now.Day.ToString();

                    //------------get the day in week-------
                    this.day_in_week_lbl.Content = System.DateTime.Now.DayOfWeek.ToString();

                    //-------get the month name-------------
                    Int32 mn;
                    mn = System.DateTime.Now.Month;
                    if (mn == 1)
                    {
                        this.month_lbl.Content = "January";
                    }
                    //-------------
                    if (mn == 2)
                    {
                        this.month_lbl.Content = "February";
                    }
                    //-------------
                    if (mn == 3)
                    {
                        this.month_lbl.Content = "March";
                    }
                    //-------------
                    if (mn == 4)
                    {
                        this.month_lbl.Content = "April";
                    }
                    //-------------
                    if (mn == 5)
                    {
                        this.month_lbl.Content = "May";
                    }
                    //-------------
                    if (mn == 6)
                    {
                        this.month_lbl.Content = "June";
                    }
                    //-------------
                    if (mn == 7)
                    {
                        this.month_lbl.Content = "July";
                    }
                    //-------------
                    if (mn == 8)
                    {
                        this.month_lbl.Content = "August";
                    }
                    //-------------
                    if (mn == 9)
                    {
                        this.month_lbl.Content = "September";
                    }
                    //-------------
                    if (mn == 10)
                    {
                        this.month_lbl.Content = "October";
                    }
                    //-------------
                    if (mn == 11)
                    {
                        this.month_lbl.Content = "November";
                    }
                    //-------------
                    if (mn == 12)
                    {
                        this.month_lbl.Content = "December";
                    }
                    //-------------
                    //==========================load login user image and name====================
                    this.login_user_image.Source = frm.image_img.Source;
                    this.login_user_name_lbl.Content = frm.user_combo.Text;
                    //===========================================================================
                }
                //-----------------

                //-----------------------------------
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        void time_update(object sender,EventArgs e) 
        {
            this.time_lbl.Content = System.DateTime.Now.ToString("HH:mm:ss");
        }

        private void minimize_butt_Click(object sender, RoutedEventArgs e)
        {
          this.WindowState = WindowState.Minimized;
        
        }

        private void close_butt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBoxResult r;
                r = System.Windows.MessageBox.Show("Do you want to exit?", "alert!", MessageBoxButton.OKCancel);
                //--------------------
                if (r == MessageBoxResult.OK)
                {
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void main_window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            //System.Windows.MessageBox.Show("Resized!");
            Canvas.SetLeft(this.close_butt, this.top_panel.ActualWidth - 30);
            Canvas.SetLeft(this.minimize_butt,  this.top_panel.ActualWidth-58);
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            wpf_diary_app.users_window frm = new users_window();
            frm.Show();
        }

        private void about_us_butt_Click(object sender, RoutedEventArgs e)
        {
            wpf_diary_app.about_us frm = new about_us();
            frm.Topmost = true;
            frm.ShowDialog();
        }

        private void add_memo_butt_Click(object sender, RoutedEventArgs e)
        {
            wpf_diary_app.memo.add_memo frm = new memo.add_memo();
            frm.Show();
        }

        private void search_butt_Click(object sender, RoutedEventArgs e)
        {
            wpf_diary_app.memo.search_memo frm = new memo.search_memo();
            frm.Show();
        }

        private void main_window_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                //--------------------
                if (e.Key == Key.F2)
                {
                    add_memo_butt_Click(sender, e);
                }
                //-------------------
                if (e.Key == Key.F3)
                {
                    search_butt_Click(sender, e);
                }
                //-------------------
                if (e.Key == Key.F4)
                {
                    this.settings_main_menu.IsSubmenuOpen = true;
                }
                //-------------------
                if (e.Key == Key.F5)
                {
                    this.tools_main_menu.IsSubmenuOpen = true;
                }
                //-------------------
                if (e.Key == Key.F6)
                {
                    this.about_main_menu.IsSubmenuOpen = true;
                }
                //-------------------
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
           
        }
    }
}
