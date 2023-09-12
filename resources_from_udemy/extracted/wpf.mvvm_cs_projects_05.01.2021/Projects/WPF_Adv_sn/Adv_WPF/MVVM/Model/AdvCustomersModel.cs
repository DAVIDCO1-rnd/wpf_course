using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_WPF.MVVM.Model
{
    public class AdvCustomersModel
    {
        private Int32 id;
        private string fname, lname, gender;
        private System.Windows.Media.Imaging.BitmapImage photo;

        //-------------------
        public AdvCustomersModel(System.Windows.Media.Imaging.BitmapImage user_photo, Int32 user_id,string user_fname, string user_lname, string user_gender) 
        {
            photo = user_photo;
            id = user_id;
            fname = user_fname;
            lname = user_lname;
            gender = user_gender;
        }
        //-------------------
        public Int32 Id
        {
            get { return id; }
            set { id = value; }
        }
        //-------------------
        public string Fname 
        {
            get {return fname; }
            set {fname=value; }
        }
        //-------------------
        public string Lname
        {
            get { return lname; }
            set { lname = value; }
        }
        //-------------------
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        //-------------------
        public System.Windows.Media.Imaging.BitmapImage Photo
        {
            get { return photo; }
            set { photo = value; }
        }
    }
}
