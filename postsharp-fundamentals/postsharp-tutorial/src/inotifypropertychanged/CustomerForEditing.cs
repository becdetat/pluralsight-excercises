using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bi.Shared;
using PostSharp.Patterns.Model;

namespace inotifypropertychanged
{
    [NotifyPropertyChanged]
    class CustomerForEditing
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            // Interesting that this fails when doing the weaving as it calls another class, although the call is static? 
            //get { return "{0} {1}".FormatWith(FirstName, LastName); }
            get { return string.Format("{0} {1}", FirstName, LastName); }
        }
    }
}
