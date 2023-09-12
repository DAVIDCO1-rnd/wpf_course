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

namespace pro_wpf_tutorials.Styles
{
    /// <summary>
    /// Interaction logic for wpf_styles.xaml
    /// </summary>
    public partial class wpf_styles : Window
    {
        public wpf_styles()
        {
            InitializeComponent();
        }

        private void butt1_Click(object sender, RoutedEventArgs e)
        {
            Setter s=new Setter(Button.FontStyleProperty, FontStyles.Italic )  ;
            //s.TargetName = "butt1";
            //s.Property = Button.FontStyleProperty ;
            //s.Value = FontStyles.Italic;
            
            this.butt1.Style.Setters.Add(s);
        }
    }
}
