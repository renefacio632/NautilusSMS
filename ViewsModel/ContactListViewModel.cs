using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using NautilusSMS.Models;

namespace NautilusSMS.ViewsModel
{
    public class ContactListViewModel
    {
        public List<ContactGroup> Contacts { get; set; } = new List<ContactGroup>();
        public ContactListViewModel()
        {
            

        }
        public bool IsNumeric(string value)
        {
            return Regex.IsMatch(value, @"\d");
        }
    }
    
}
