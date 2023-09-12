using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_WPF.MVVM.ViewModel
{
    public class AdvCustomersViewModel
    {
        private List<Adv_WPF.MVVM.Model.AdvCustomersModel> add_cu_list = new List<Model.AdvCustomersModel>();


        public AdvCustomersViewModel()
            {
            string fn;
            fn = Environment.CurrentDirectory + "\\MVVM\\Pics\\koala.jpg";
              add_cu_list.Add(new Model.AdvCustomersModel(new System.Windows.Media.Imaging.BitmapImage (new Uri(fn)), 1, "Sara", "Parker", "Female"));
            //------------------------
            fn = Environment.CurrentDirectory + "\\MVVM\\Pics\\me.png";
            add_cu_list.Add(new Model.AdvCustomersModel(new System.Windows.Media.Imaging.BitmapImage(new Uri(fn)),2, "Mike", "Peteson", "Male"));
            //-------------------------
            fn = Environment.CurrentDirectory + "\\MVVM\\Pics\\mh.png";
            add_cu_list.Add(new Model.AdvCustomersModel(new System.Windows.Media.Imaging.BitmapImage(new Uri(fn)), 3, "Jet", "Lee", "Male"));
            //add_cu_list.Add(new Model.AdvCustomersModel(4, "Philip", "Black", "Male"));
        }

        public List<Adv_WPF.MVVM.Model.AdvCustomersModel> Add_Cu_List 
        {
            get {return add_cu_list; }
            set { add_cu_list=value; }
        }

    }
}
