using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_WPF.MVVM.ViewModel
{
    class CutomersViewModel
    {
        private List<Adv_WPF.MVVM.Model.CustomersModel> customers_name=new List<Model.CustomersModel>();
    

        public CutomersViewModel() 
        {
            customers_name.Add(new Model.CustomersModel("Sara Miller"));
            customers_name.Add(new Model.CustomersModel("John Lee"));
            customers_name.Add(new Model.CustomersModel("Alex Jackson"));
            customers_name.Add(new Model.CustomersModel("Sam White"));
            customers_name.Add(new Model.CustomersModel("Bruce Lee"));

        }
    public List<Adv_WPF.MVVM.Model.CustomersModel> Customers_Name 
        {
            get {return customers_name; }
            set { customers_name=value; }
        }
    }

}
