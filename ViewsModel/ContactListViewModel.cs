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
        private List<ContactModel> _contacts = new List<ContactModel>(); 
        public List<ContactGroup> contactsGroup { get; set; } = new List<ContactGroup>();
        public ContactListViewModel()
        {
            _contacts.AddRange(new List<ContactModel>());

            var groupedData = _contacts.GroupBy(f => f.Name[0]).Select(f => new ContactGroup(f.ToString(), f.ToList()));
            contactsGroup.AddRange(groupedData);
        }
        public bool IsNumeric(string value)
        {
            return Regex.IsMatch(value, @"\d");
        }
    }
    
}
