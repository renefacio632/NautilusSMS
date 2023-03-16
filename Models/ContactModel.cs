using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NautilusSMS.Models
{
    public class ContactGroup : List<ContactModel>
    {
        public string GroupTitle { get; set; }
        public ContactGroup(string groupTitle, List<ContactModel>
            contacts) : base(contacts)
        {
            GroupTitle = groupTitle;
        }
        
    }
    public class ContactModel : IComparable<ContactModel>
    {
        public string Imagen { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public ContactModel(string imagen, string name, string phone)
        {
            Imagen = imagen;
            Name = name;
            Phone = phone;
        }

        public int CompareTo(ContactModel obj)
        => string.Compare(Name, obj.Name);
    }
}
