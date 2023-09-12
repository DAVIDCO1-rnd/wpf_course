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
    /// Interaction logic for add_memo.xaml
    /// </summary>
    public partial class add_memo : Window
    {
        public add_memo()
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

        private void add_memo_wind_Loaded(object sender, RoutedEventArgs e)
        {
            this.details_gbox.IsEnabled = false;
        }

        private void new_butt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.details_gbox.IsEnabled = true;
                this.new_butt.IsEnabled = false;
                this.save_butt.IsEnabled = true;
                //------------clear controls---------------
                this.memo_title_tbox.Text = "";
                this.note_date_picker.SelectedDate = System.DateTime.Now;
                this.rtc.Document.Blocks.Clear();
                //-------------------------------------------
                //---------------add new memo id-------------
                long last_id;
                last_id = wpf_diary_app.Properties.Settings.Default.last_id + 1;
                this.memo_id_tbox.Text = last_id.ToString();
                //-------------------------------------------
                this.memo_title_tbox.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
          
        }

        private void save_butt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.details_gbox.IsEnabled = false;
                this.new_butt.IsEnabled = true;
                this.save_butt.IsEnabled = false;
                //-------------save last id in the settings file-----------------------
                //---------------add new memo id-------------
                long last_id;
                last_id = wpf_diary_app.Properties.Settings.Default.last_id + 1;
                wpf_diary_app.Properties.Settings.Default.last_id = last_id;
                wpf_diary_app.Properties.Settings.Default.Save();
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
                //--------------------
                TextRange tr = new TextRange(this.rtc.Document.ContentStart, this.rtc.Document.ContentEnd);
                System.IO.FileStream fs = new System.IO.FileStream(rtf_fn, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.ReadWrite);
                tr.Save(fs, DataFormats.Rtf);
                fs.Close();
                System.Windows.MessageBox.Show("Saved!");
                //---------------------------------------------------------------------
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
           

        }

        private void add_memo_wind_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                //--------------------
                if (e.Key == Key.F2)
                {
                    new_butt_Click(sender, e);
                }
                //-------------------
                if (e.Key == Key.F4)
                {
                    save_butt_Click(sender, e);
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
