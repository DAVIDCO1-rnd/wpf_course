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

namespace Adv_WPF._3rd_ctls
{
    /// <summary>
    /// Interaction logic for wpf_listview.xaml
    /// </summary>
    public partial class wpf_listview : Window
    {
        public wpf_listview()
        {
            InitializeComponent();
        }

        private void add_butt_Click(object sender, RoutedEventArgs e)
        {
            //this.main_listview.Items.Add("Edit");
            //this.main_listview.Items.Add("New");
            //this.main_listview.Items.Add("Delete");
            this.main_listview.Items.Add(this.name_tbox.Text);
            this.count_lbl.Content = this.main_listview.Items.Count.ToString();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.count_lbl.Content = this.main_listview.Items.Count.ToString();
        }

        private void del_all_butt_Click(object sender, RoutedEventArgs e)
        {
            this.main_listview.Items.Clear();
        }

        private void del_selected_butt_Click(object sender, RoutedEventArgs e)
        {
            //Int32 si;
            //si = this.main_listview.SelectedIndex;
            //this.main_listview.Items.RemoveAt(si);
            //--------------------------------
            object so;
            so = this.main_listview.SelectedItem;
            this.main_listview.Items.Remove(so);
        }

        private void add_list_butt_Click(object sender, RoutedEventArgs e)
        {
            List<string> li = new List<string>();
            //-----------------
            li.Add("Male");
            li.Add("Female");
            li.Add("Boy");
            li.Add("Girl");
            //-----------------
            this.second_lv.ItemsSource=li;
        }

        private void add_image_item_butt_Click(object sender, RoutedEventArgs e)
        {
            image_item_adder("about.png", "About");
            image_item_adder("add_memo.png", "Edit Info");
            image_item_adder("file_32.png", "Documents");
        }
        void image_item_adder(string image_name,string item_text) 
        {
            System.Windows.Controls.ListViewItem my_item = new ListViewItem();
            StackPanel stack_panel = new StackPanel();
            //----------
            Image img = new Image();
            Label caption_lbl = new Label();
            //-----------
            string fn;
            fn = Environment.CurrentDirectory + "\\3rd_ctls\\Pics_output\\"+ image_name;
            img.Source = new BitmapImage(new Uri(fn));
            img.Width = 32;
            img.Height = 32;
            //-----------------
            caption_lbl.Content = item_text;//"About"
            //-----------------
            stack_panel.Orientation = Orientation.Horizontal;
            stack_panel.Children.Add(img);
            stack_panel.Children.Add(caption_lbl);
            //-----------------
            my_item.Content = stack_panel;
            //-----------------
            this.image_lv.Items.Add(my_item);
            //-----------------

        }

        private void del_all_butt2_Click(object sender, RoutedEventArgs e)
        {
            this.image_lv.Items.Clear();
        }

        private void main_listview_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.Title = this.main_listview.SelectedIndex.ToString();
            if (this.main_listview.SelectedIndex==0) 
            {
                Adv_WPF._3rd_ctls.wpf_listview_data frm = new wpf_listview_data();
                frm.Show();
            }
            //--------------------------
            if (this.main_listview.SelectedIndex == 1)
            {
                System.Windows.MessageBox.Show("I'm second item!");
            }
        }

        private void second_lv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.Title = this.second_lv.SelectedIndex.ToString();
            if (this.second_lv.SelectedIndex == 0)
            {
                Adv_WPF._3rd_ctls.wpf_listview_data frm = new wpf_listview_data();
                frm.Show();
            }
            //--------------------------
            if (this.second_lv.SelectedIndex == 1)
            {
                System.Windows.MessageBox.Show("I'm second item!");
            }
        }

        private void image_lv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.Title = this.image_lv.SelectedIndex.ToString();
            if (this.image_lv.SelectedIndex == 0)
            {
                Adv_WPF._3rd_ctls.wpf_listview_data frm = new wpf_listview_data();
                frm.Show();
            }
            //--------------------------
            if (this.image_lv.SelectedIndex == 1)
            {
                System.Windows.MessageBox.Show("I'm second item!");
            }
        }

        private void add_items_mcolumn_butt_Click(object sender, RoutedEventArgs e)
        {
            
           
            this.mcolumn_lv.Items.Clear();
            //-----------------------------
            user_loader("me.jpg", 1, "Sara", "Parker", "14-05-2011");
            user_loader("koala_resized.jpg", 2, "Koala", "Lazy!", "14-05-2001");
            user_loader("v.jpg", 3, "Mike", "Lee!", "14-05-2012");
        }

        void user_loader(string customer_photo, Int32 customer_id, string customer_fname,
                                string customer_lname, string customer_date_of_birth) 
        {
            string fn;
            fn = Environment.CurrentDirectory + "\\3rd_ctls\\Pics_output\\" + customer_photo;
            BitmapImage user_img = new BitmapImage(new Uri(fn));
            //-----------------------------
            user_data_loader ud;
            //-----------
            ud = new user_data_loader(user_img, customer_id, customer_fname, customer_lname, customer_date_of_birth);
            //----------- 
            this.mcolumn_lv.Items.Add(ud);
            //-----------------------------

        }
        private void add_list_mcolumn_butt_Click(object sender, RoutedEventArgs e)
        {
            this.mcolumn_lv.Items.Clear();
            //--------------------------------
            List<user_data_loader> ul = new List<user_data_loader>();
           //------------------------------
            string fn;
            fn = Environment.CurrentDirectory + "\\3rd_ctls\\Pics_output\\" ;
             //-----------------------------
            ul.Add(new user_data_loader(new BitmapImage(new Uri(fn + "me.jpg")), 1, "Sara", "Jackson", "21-09-2000"));
            ul.Add(new user_data_loader(new BitmapImage(new Uri(fn + "koala_resized.jpg")), 2, "Koala", "Lazy!", "20-09-2010"));
            ul.Add(new user_data_loader(new BitmapImage(new Uri(fn + "mm.jpg")), 3, "Alex", "Jackson", "14-01-2012"));
            //-----------------------------
            this.mcolumn_lv.ItemsSource = ul;
        }
    }

    public class user_data_loader 
    {
        private Int32 id;
        private string fname, lname, date_of_birth;
        private BitmapImage user_photo;
        //------------------------------
        public user_data_loader(BitmapImage customer_photo, Int32 customer_id, string customer_fname,
                                string customer_lname, string customer_date_of_birth) 
        {
            user_photo = customer_photo;
            id = customer_id;
            fname = customer_fname;
            lname = customer_lname;
            date_of_birth = customer_date_of_birth;
        }
        //------------------------------
        public Int32 Id 
        {
            get {return id ; }
            set { id = value; }
        }
        //-------------------------
        public string Fname
        {
            get { return fname; }
            set { fname = value; }
        }
        //-------------------------
        public string Lname
        {
            get { return lname; }
            set { lname = value; }
        }
        //-------------------------
        public string Date_of_birth
        {
            get { return date_of_birth; }
            set { date_of_birth = value; }
        }
        //-------------------------
        public BitmapImage User_photo
        {
            get { return user_photo; }
            set { user_photo = value; }
        }
        //-------------------------
    }
}
