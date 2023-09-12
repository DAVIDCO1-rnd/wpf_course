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

namespace Adv_WPF
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

    

        private void window_res_butt_Click(object sender, RoutedEventArgs e)
        {
            object ob;
            ob=this.TryFindResource("window_read_butt_width");
            //ob = this.Resources["butt_height"];
            if (ob!=null) 
            {
               this.window_res_lbl.Content = ob.ToString();
            }
            else 
            {
                this.window_res_lbl.Content = "Not Found the Resource!";
            }
           
        }

        private void app_res_butt_Click(object sender, RoutedEventArgs e)
        {
            object ob;
            ob =Application.Current.TryFindResource("exit_butt_width");
             //ob =Application.Current.Resources["exit_butt_width"];
            if (ob != null)
            {
                this.app_res_lbl.Content = ob.ToString();
            }
            else
            {
                this.app_res_lbl.Content = "Not Found the Resource!";
            }
        }

        private void grid_res_butt_Click(object sender, RoutedEventArgs e)
        {
            object ob;
            ob = this.first_sub_grid.TryFindResource("grid_butt_width");
            //ob = this.first_sub_grid.Resources["grid_butt_width"];
            if (ob != null)
            {
                this.grid_res_lbl.Content = ob.ToString();
            }
            else
            {
                this.grid_res_lbl.Content = "Not Found the Resource!";
            }
        }

        private void save_window_res_butt_Click(object sender, RoutedEventArgs e)
        {
            // this.Resources["window_read_butt_width"] = (Double)170;
            Double d;
            Boolean b;
             b= Double.TryParse(this.save_window_res_lbl.Text, out d);
           //--------------------------
            if (b==true) 
            {
              this.Resources["window_read_butt_width"] =d ;
            }
           
        }

        private void save_app_res_butt_Click(object sender, RoutedEventArgs e)
        {
            //Application.Current.Resources["load_butt_app_res_butt"] = (Double)170;
            Double d;
            Boolean b;
            b = Double.TryParse(this.save_app_res_lbl.Text, out d);
            //--------------------------
            if (b == true)
            {
                Application.Current.Resources["load_butt_app_res_butt"] = d;
            }
        }

        private void save_grid_res_butt_Click(object sender, RoutedEventArgs e)
        {
            // this.grid_res_loader.Resources["grid_res_load_butt_width"] = (Double)170;
            Double d;
            Boolean b;
            b = Double.TryParse(this.save_grid_res_lbl.Text, out d);
            //--------------------------
            if (b == true)
            {
                this.grid_res_loader.Resources["grid_res_load_butt_width"] = d;
            }
        }
    }
}
