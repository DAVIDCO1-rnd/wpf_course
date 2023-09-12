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

namespace Adv_WPF.file_folder
{
    /// <summary>
    /// Interaction logic for io_file_folder.xaml
    /// </summary>
    public partial class io_file_folder : Window
    {
        public io_file_folder()
        {
            InitializeComponent();
        }

        private void file_exists_Click(object sender, RoutedEventArgs e)
        {
            bool b;
            b = System.IO.File.Exists(this.file_tbox.Text);
            //--------------
            if (b==true) 
            {
              System.Windows.MessageBox.Show("I found your file!" );
            }
            else 
            {
                System.Windows.MessageBox.Show("I can't find your file!");
            }
            //-------------
           
        }

        private void app_pah_butt_Click(object sender, RoutedEventArgs e)
        {
            this.file_tbox.Text = Environment.CurrentDirectory+ "\\file_folder\\Pics\\Koala.jpg";
        }

        private void delete_file_butt_Click(object sender, RoutedEventArgs e)
        {
            bool b;

            try
            {
                //System.IO.File.Delete("E:\\tuts\\Koala.jpg");
                //-------------------------------------------
                
                b = System.IO.File.Exists(this.file_tbox.Text);
                //--------------
                if (b == true)
                {
                    System.IO.File.Delete(this.file_tbox.Text);
                }
                else
                {
                    System.Windows.MessageBox.Show("I can't find your file to delete!");
                }
                //-------------
                //-------------------------------------------
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);

            }
              
        }

        private void browse_butt_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog ofd = new Microsoft.Win32.OpenFileDialog();
            ofd.ShowDialog();
            //----------------
            this.file_tbox.Text = ofd.FileName;

        }

        private void copy_file_butt_Click(object sender, RoutedEventArgs e)
        {
            // System.IO.File.Copy("C:\\tuts\\Koala.jpg", "E:\\tuts\\new_koala.jpg",true );

            bool b;
            b = System.IO.File.Exists(this.target_file_tbox.Text);
            //-----------------------
            if (b==false) //file not exists in the target
            {
                System.IO.File.Copy(this.file_tbox.Text, this.target_file_tbox.Text );
            }
            //-----------------------
            else //file exist in the target
            {
                MessageBoxResult r;
                r = System.Windows.MessageBox.Show("The file exists in the target! Do you want to replace it?", "Alert", MessageBoxButton.YesNo);
                //----------------
                if (r==MessageBoxResult.Yes)
                {
                    System.IO.File.Copy(this.file_tbox.Text, this.target_file_tbox.Text, true);
                }
            }
            //-----------------------
        }

        private void target_browse_butt_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog ofd = new Microsoft.Win32.SaveFileDialog();
            ofd.ShowDialog();
            //----------------
            this.target_file_tbox.Text = ofd.FileName;
        }

        private void move_file_butt_Click(object sender, RoutedEventArgs e)
        {
            //System.IO.File.Move("C:\\tuts\\Koala.jpg", "E:\\tuts\\new_koala.jpg");
            
            bool b;
            b = System.IO.File.Exists(this.target_file_tbox.Text);
            //-----------------------
            if (b == false) //file not exists in the target
            {
                System.IO.File.Move(this.file_tbox.Text, this.target_file_tbox.Text);
            }
            //-----------------------
            else //file exist in the target
            {
                MessageBoxResult r;
                r = System.Windows.MessageBox.Show("The file exists in the target! Do you want to replace it?", "Alert", MessageBoxButton.YesNo);
                //----------------
                if (r == MessageBoxResult.Yes)
                {
                    System.IO.File.Delete(this.target_file_tbox.Text);
                    System.IO.File.Move(this.file_tbox.Text, this.target_file_tbox.Text);
                }
            }
            //-----------------------
        }

       

        private void folder_exists_butt_Click(object sender, RoutedEventArgs e)
        {
            bool r;
            // r=System.IO.Directory.Exists("C:\\tuts");
            r = System.IO.Directory.Exists(this.source_folder_tbox.Text );
            if (r==true ) // folder exists
            {
                System.Windows.MessageBox.Show("I found your folder!");
            }
            else //folder not found
            {
                System.Windows.MessageBox.Show("I can't find your folder!");
            }
        }

     

        private void app_folder_butt_Click(object sender, RoutedEventArgs e)
        {
            this.source_folder_tbox.Text = Environment.CurrentDirectory  ;
        }

        private void create_folder_butt_Click (object sender, RoutedEventArgs e)
        {
            System.IO.DirectoryInfo r;
            r=System.IO.Directory.CreateDirectory("E:\\tuts\\Hi");
            bool b;
            b= r.Exists;
            if (b==true) 
            {
                System.Windows.MessageBox.Show("The folder is created!");
            }
            else 
            {
                System.Windows.MessageBox.Show("Can't create the folder!");
            }
            //--------------------------------
            this.Title = r.FullName;
            this.Title = r.Name;
            this.Title = r.CreationTime.ToString();
            this.Title = r.Root.ToString();
           
            //--------------------------------
            //for (int i = 1; i <= 10000; i++)
            //{
            //    System.IO.Directory.CreateDirectory("E:\\tuts\\Hi\\"+i.ToString());
            //}
        }

        private void delete_folder_butt_Click(object sender, RoutedEventArgs e)
        {
            //-----------------------------------
            bool r;
            // r=System.IO.Directory.Exists("C:\\tuts");
            r = System.IO.Directory.Exists(this.source_folder_tbox.Text);
            //------------------------------
            if (r == true) // folder exists
            {
                System.IO.Directory.Delete(this.source_folder_tbox.Text, true);
                System.Windows.MessageBox.Show("Your folder is deleted!");
            }
            else //folder not found
            {
                System.Windows.MessageBox.Show("I can't find your folder!");
            }
            //-----------------------------------
           
        }

        private void move_folder_butt_Click(object sender, RoutedEventArgs e)
        {

            
            //------------Notes-----------------------
            //1-source and target folders should be in the same drive
            //2- The source folder should be exists
            //3- Source and destination folder must be different
            //----------------------------------------
            string target_folder;
            target_folder = "E:\\tuts\\Test\\Bad_Koala";
            //------------------
            if (this.source_folder_tbox.Text== target_folder) 
            {
                System.Windows.MessageBox.Show("The source and the target folder should be different!");
                return;
            }
            //----------------------------------------
            bool r;
            
            //r = System.IO.Directory.Exists("E:\\tuts\\Koala");
            r = System.IO.Directory.Exists(this.source_folder_tbox.Text );
            if (r == true) // folder exists
            {
                System.IO.Directory.Move(this.source_folder_tbox.Text, target_folder);
                //System.Windows.MessageBox.Show("I found your folder!");
            }
            else //folder not found
            {
                System.Windows.MessageBox.Show("I can't find your folder!");
            }

             
            
        }

    }
}
