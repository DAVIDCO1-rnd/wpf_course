using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_WPF.MVVM.Model
{
    public class CustomersModel
    {
        private string full_name;

        public CustomersModel(string user_full_name) 
        {
            full_name = user_full_name;
        }
        public string Full_Name 
        {
            get {return full_name; }
            set { full_name=value; }
        }
    }
}
