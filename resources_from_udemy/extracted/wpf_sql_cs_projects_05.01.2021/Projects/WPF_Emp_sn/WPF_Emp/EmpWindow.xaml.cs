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

namespace WPF_Emp
{
    /// <summary>
    /// Interaction logic for EmpWindow.xaml
    /// </summary>
    public partial class EmpWindow : Window
    {
        public EmpWindow()
        {
            InitializeComponent();
        }

        WPF_Emp.MainDs.EmpDs EmpDs;
        WPF_Emp.MainDs.EmpDsTableAdapters.Emp_InfoTableAdapter Emp_InfoTableAdapter;
        System.Windows.Data.CollectionViewSource emp_InfoViewSource;
        private void Emp_Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                //----------------Load the data--------------------
                EmpDs = (WPF_Emp.MainDs.EmpDs)this.FindResource("empDs");
                //================
                Emp_InfoTableAdapter = new MainDs.EmpDsTableAdapters.Emp_InfoTableAdapter();
                //----------------
                Emp_InfoTableAdapter.Fill(EmpDs.Emp_Info);
                //--------------------------------------------------
                emp_InfoViewSource = (System.Windows.Data.CollectionViewSource)this.FindResource("emp_InfoViewSource");
                //-------------------------------
                emp_InfoViewSource.View.MoveCurrentToLast();
                //---------------------------------------------------
                //-----------move dg current record-------------------
                this.emp_InfoDataGrid.ScrollIntoView(emp_InfoViewSource.View.CurrentItem);
                //----------------------------------------------------
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Error! " + ex.Message);
            }
       
            //-------------------disable save_cancel butts--------
            this.save_butt.IsEnabled = false;
            this.cancel_butt.IsEnabled = false;
            //----------------------------------------------------
            this.items_gbox.IsEnabled = false;
            this.emp_InfoDataGrid.IsEnabled = true;
            //----------------------------------------------------
        }

        private void new_butt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                new_edit_del_butts();
                //---------------------
                ////WPF_Emp.MainDs.EmpDs EmpDs = (WPF_Emp.MainDs.EmpDs)this.FindResource("empDs");
                System.Data.DataRow dr;
                dr = EmpDs.Emp_Info.NewEmp_InfoRow();
                EmpDs.Emp_Info.Rows.Add(dr);
                //---------------------
                //----------------clear items on window--------------
                ////System.Windows.Data.CollectionViewSource emp_InfoViewSource = (System.Windows.Data.CollectionViewSource)this.FindResource("emp_InfoViewSource");
                emp_InfoViewSource.View.MoveCurrentToLast();
                //---------------------------------------------------
                //-----------move dg current record-------------------
                this.emp_InfoDataGrid.ScrollIntoView(emp_InfoViewSource.View.CurrentItem);
                //---------------------------------------------------
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Error! " + ex.Message);
            }
          
        }

        private void edit_butt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //--------------------
                ////WPF_Emp.MainDs.EmpDs EmpDs = (WPF_Emp.MainDs.EmpDs)this.FindResource("empDs");
                Int32 rc;
                rc = EmpDs.Emp_Info.Rows.Count;
                if (rc == 0)
                {
                    System.Windows.MessageBox.Show("There is nothing to edit!");
                    return;
                }
                //-------------------
                new_edit_del_butts();
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Error! " + ex.Message);
            }
           

        }

        private void del_butt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //--------------------
                ////WPF_Emp.MainDs.EmpDs EmpDs = (WPF_Emp.MainDs.EmpDs)this.FindResource("empDs");
                Int32 rc;
                rc = EmpDs.Emp_Info.Rows.Count;
                if (rc == 0)
                {
                    System.Windows.MessageBox.Show("There is nothing to delete!");
                    return;
                }
                //-------------------
                is_del_butt_clicked = true;
                new_edit_del_butts();
                //-------------------
                ////System.Windows.Data.CollectionViewSource emp_InfoViewSource = (System.Windows.Data.CollectionViewSource)this.FindResource("emp_InfoViewSource");
                System.Data.DataRowView drv;
                drv = (System.Data.DataRowView)emp_InfoViewSource.View.CurrentItem;
                //-------------------
                drv.Delete();
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Error! " + ex.Message);
            }
           
        }

        Boolean is_del_butt_clicked = false;
        void new_edit_del_butts() 
        {
            //--------------------------------
            this.new_butt.IsEnabled = false;
            this.edit_butt.IsEnabled = false;
            this.del_butt.IsEnabled = false;
            //--------------------------------
            this.save_butt.IsEnabled = true;
            this.cancel_butt.IsEnabled = true;
            //--------------------------------
            //----------------------------------------------------
            if (is_del_butt_clicked==true ) 
            {
                this.items_gbox.IsEnabled = false;
                is_del_butt_clicked = false;
            }
            else 
            {
                this.items_gbox.IsEnabled = true;
            }
            //--------------------------------
            this.emp_InfoDataGrid.IsEnabled = false;
            //----------------------------------------------------
        }

        void save_cancel_butts()
        {
            //--------------------------------
            this.new_butt.IsEnabled = true;
            this.edit_butt.IsEnabled = true;
            this.del_butt.IsEnabled = true;
            //--------------------------------
            this.save_butt.IsEnabled = false;
            this.cancel_butt.IsEnabled = false;
            //--------------------------------
            //----------------------------------------------------
            this.items_gbox.IsEnabled = false;
            this.emp_InfoDataGrid.IsEnabled = true;
            //----------------------------------------------------
        }
        private void save_butt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                save_cancel_butts();
                //------save changes in SQL Db-----

                ////WPF_Emp.MainDs.EmpDsTableAdapters.Emp_InfoTableAdapter Emp_InfoTableAdapter = new MainDs.EmpDsTableAdapters.Emp_InfoTableAdapter();
                //------------
                ////WPF_Emp.MainDs.EmpDs EmpDs = (WPF_Emp.MainDs.EmpDs)this.FindResource("empDs");
                Int32 rv;
                rv = Emp_InfoTableAdapter.Update(EmpDs.Emp_Info);
                //---------------------------------
                if (rv > 0)
                {
                    System.Windows.MessageBox.Show("Saved! Count:" + rv.ToString());
                }
                else
                {
                    System.Windows.MessageBox.Show("Can't save! Try again!");
                }
                //---------------------------------
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Error! " + ex.Message);
            }
           
        }

        private void cancel_butt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                save_cancel_butts();
                //------------------
                ////WPF_Emp.MainDs.EmpDs EmpDs = (WPF_Emp.MainDs.EmpDs)this.FindResource("empDs");
                EmpDs.Emp_Info.RejectChanges();
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Error! " + ex.Message);
            }
        
        }

       
    }
}
