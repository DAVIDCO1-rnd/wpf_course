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

namespace wpf_diary_app.memo
{
    /// <summary>
    /// Interaction logic for search_memo.xaml
    /// </summary>
    public partial class search_memo : Window
    {
        public search_memo()
        {
            InitializeComponent();
        }

        private void align_left_butt_Click(object sender, RoutedEventArgs e)
        {
            EditingCommands.AlignLeft.Execute(null, this.rtc);
        }

        private void align_center_butt_Click(object sender, RoutedEventArgs e)
        {
            EditingCommands.AlignCenter.Execute(null, this.rtc);
        }

        private void align_right_butt_Click(object sender, RoutedEventArgs e)
        {
            EditingCommands.AlignRight.Execute(null, this.rtc);
        }

        private void inc_indent_butt_Click(object sender, RoutedEventArgs e)
        {
            EditingCommands.IncreaseIndentation.Execute(null, this.rtc);
        }

        private void dec_indent_butt_Click(object sender, RoutedEventArgs e)
        {
            EditingCommands.DecreaseIndentation.Execute(null, this.rtc);
        }

        private void bold_butt_Click(object sender, RoutedEventArgs e)
        {
            EditingCommands.ToggleBold.Execute(null, this.rtc);
        }

        private void italic_butt_Click(object sender, RoutedEventArgs e)
        {
            EditingCommands.ToggleItalic.Execute(null, this.rtc);
        }

        private void underline_butt_Click(object sender, RoutedEventArgs e)
        {
            EditingCommands.ToggleUnderline.Execute(null, this.rtc);
        }

        private void incr_font_size_butt_Click(object sender, RoutedEventArgs e)
        {
            EditingCommands.IncreaseFontSize.Execute(null, this.rtc);
        }

        private void dec_font_size_butt_Click(object sender, RoutedEventArgs e)
        {
            EditingCommands.DecreaseFontSize.Execute(null, this.rtc);
        }

        private void cut_butt_Click(object sender, RoutedEventArgs e)
        {
            this.rtc.Cut();

        }

        private void copy_butt_Click(object sender, RoutedEventArgs e)
        {
            this.rtc.Copy();
        }

        private void paste_butt_Click(object sender, RoutedEventArgs e)
        {
            this.rtc.Paste();
        }

        private void undo_butt_Click(object sender, RoutedEventArgs e)
        {
            this.rtc.Undo();
        }

        private void redo_butt_Click(object sender, RoutedEventArgs e)
        {
            this.rtc.Redo();
        }

        private void search_memo_wind_Loaded(object sender, RoutedEventArgs e)
        {
            //--------------------
            this.memo_listbox.Items.Clear();
            //-------------------
            long li;
           li= wpf_diary_app.Properties.Settings.Default.last_id;
            //-------------------
            string title_fn;
            title_fn = "";

            for (int i = 1; i <= li; i++)
            {
                //------to add listbox items-------
                ListBoxItem item = new ListBoxItem();
                item.Tag = i;
                //-----
                title_fn = Environment.CurrentDirectory + "\\Data\\Docs\\t_" + i.ToString() + ".dll";
                //-------------
                if (System.IO.File.Exists(title_fn)==true) 
                { 
                  item.Content= System.IO.File.ReadAllText(title_fn, Encoding.UTF8);
                  //------
                  this.memo_listbox.Items.Add(item);
                }
              
                //---------------------------------
            }
        }

        private void memo_listbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //------------------------------
            if (this.memo_listbox.SelectedIndex==-1)
            {
                return;
            }
            //------------------------------
            ListBoxItem li = new ListBoxItem();
            Int32 si;
            si = this.memo_listbox.SelectedIndex;
            li = (ListBoxItem)this.memo_listbox.Items[si];
            //-------------------------
            this.memo_title_tbox.Text = li.Content.ToString();
            this.memo_id_tbox.Text = li.Tag.ToString();
            //-------------------------
            string date_fn;
            date_fn = Environment.CurrentDirectory + "\\Data\\Docs\\d_" + li.Tag.ToString() + ".dll";
            //-------------
            if (System.IO.File.Exists(date_fn) == true)
            {
               this.note_date_picker.Text = System.IO.File.ReadAllText(date_fn, Encoding.UTF8);
            }
            //---------------------------------
            string rtf_fn;
            rtf_fn = Environment.CurrentDirectory + "\\Data\\Docs\\r_" + li.Tag.ToString() + ".mp3";
            //--------------------
            TextRange tr = new TextRange(this.rtc.Document.ContentStart, this.rtc.Document.ContentEnd);
            System.IO.FileStream fs = new System.IO.FileStream(rtf_fn, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.ReadWrite);
            tr.Load(fs, DataFormats.Rtf);
            fs.Close();
            //-----------------------------------------
            //---------------------------------
        }

        private void search_butt_Click(object sender, RoutedEventArgs e)
        {
            //-------------------------------------
            this.memo_listbox.SelectedIndex = -1;
            //-----------------
            this.memo_id_tbox.Text = "";
            this.memo_title_tbox.Text = "";
            this.note_date_picker.Text = "";
            this.rtc.Document.Blocks.Clear();
            //-------------------------------------
            ListBoxItem li = new ListBoxItem();
           //-----------------------------
            for (int i = 0; i < this.memo_listbox.Items.Count; i++)
            {
                li = (ListBoxItem)this.memo_listbox.Items[i];
                //----------------clear backcolor--------
                li.Background = System.Windows.Media.Brushes.White;
                //---------------------------------------
                //------------------
                //------------find exact mach-------------
                if (this.similar_chbox.IsChecked==false)
                {
                    if (li.Content.ToString() == this.search_title_tbox.Text)
                    {
                        li.Background = System.Windows.Media.Brushes.Yellow;
                    }
                }
                //------------------------------------------
                if (this.similar_chbox.IsChecked == true)
                {
                    if (li.Content.ToString().Contains(this.search_title_tbox.Text)==true)
                    {
                        li.Background = System.Windows.Media.Brushes.Yellow;
                    }
                }
                //-----------------------------------------
            }
            //-------------------------------
        }

        private void update_butt_Click(object sender, RoutedEventArgs e)
        {
            //---------------add new memo id-------------
            long last_id;
            long.TryParse(this.memo_id_tbox.Text, out last_id);
            //-------------------------------------------
            if (last_id==0 || this.memo_listbox.SelectedIndex==-1)
            {
                System.Windows.MessageBox.Show("The memo id is not valid!");
                return;
            }
            //-------------------------------------------
            //-------------------------Save data in text file----------------------
            string title_fn;
            string date_fn;
            string rtf_fn;
            //-----------------
            title_fn = Environment.CurrentDirectory + "\\Data\\Docs\\t_" + last_id.ToString() + ".dll";
            date_fn = Environment.CurrentDirectory + "\\Data\\Docs\\d_" + last_id.ToString() + ".dll";
            rtf_fn = Environment.CurrentDirectory + "\\Data\\Docs\\r_" + last_id.ToString() + ".mp3";
            //-----------------
            System.IO.File.WriteAllText(title_fn, this.memo_title_tbox.Text, Encoding.UTF8);
            System.IO.File.WriteAllText(date_fn, this.note_date_picker.Text, Encoding.UTF8);
            //-------to delete invalid chars in update-------------
            if (System.IO.File.Exists(rtf_fn) ==true) 
            {
                System.IO.File.Delete(rtf_fn);
            }
            //------------------------------------------------------
            TextRange tr = new TextRange(this.rtc.Document.ContentStart, this.rtc.Document.ContentEnd);
            System.IO.FileStream fs = new System.IO.FileStream(rtf_fn, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.ReadWrite);
            tr.Save(fs, DataFormats.Rtf);
            fs.Close();
            //--------refresh memo details------------
            search_memo_wind_Loaded(sender, e);
            //----------------------------------------
            System.Windows.MessageBox.Show("Saved!");
            //---------------------------------------------------------------------
        }
    }
}
