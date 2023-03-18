using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.Maui.Controls;
using System.Xml.Linq;
using System.Net;
using System.Text.RegularExpressions;
using CommunityToolkit.Maui.Markup;
using System.Linq;
using CommunityToolkit.Maui.Converters;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;

namespace NautilusSMS.Views;

public partial class NewSMS: ContentPage
{
	public NewSMS()
	{
		InitializeComponent();
        
        SearchBar searchBar = new SearchBar {Placeholder ="Search items..."};
    }

    private async void NuevoSMS_Load(object sender, EventArgs e)
    {
        
        var contacts = await Microsoft.Maui.ApplicationModel.Communication.Contacts.GetAllAsync();

        // Crea una lista de contactos para mostrar en la página
        var contactList = new List<Contact>();
        
        // Recorre la lista de contactos y agrega la información a la lista
        foreach (var contact in contacts)
        {
            if (contact.Phones.FirstOrDefault()?.PhoneNumber != null)
            {
                var Name = contact.DisplayName;
                var Imagen = "";
                if (!IsNumeric(Name))
                    Imagen = "ic" + Name.Substring(0, 1).ToLower() + ".png";
                else Imagen = "icnull.png";
                var Phone = contact.Phones.FirstOrDefault()?.PhoneNumber;

                contactList.Add(new Contact(Imagen, Name, Phone));
            }
        }
        contactList.Sort();

        // Muestra la lista de contactos en la página
        listContactos.ItemsSource = contactList;
    }
    class Contact : IComparable<Contact>
    {
        public string Imagen { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public Contact(string imagen, string name, string phone)
        {
            Imagen = imagen;
            Name = name;
            Phone = phone;
        }

        public int CompareTo(Contact obj)
        => string.Compare(Name, obj.Name);
    }
    private void listContactos_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        var item = (Contact)e.SelectedItem;

        DisplayAlert("Contactos", "Usted selecciono el Contacto:\n" + item.Name + "\n" + item.Phone, "Ok"); // + item.Name + "\n" + item.Phone
        //listContactos.SelectedItem = null;

    }
    public bool IsNumeric(string value)
    {
        return Regex.IsMatch(value, @"\d");
    }
}