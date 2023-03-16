
namespace NautilusSMS.Views;

public partial class Contacts : ContentPage
{
    public static object Default { get; internal set; }

    public Contacts()
	{
		InitializeComponent();
	}
    
    private void Contactos_Load(object sender, EventArgs e)
    {
        List<Contact> contacts = new List<Contact>()
            {
                new Contact() {Name="John Doe", Email="johnDoe@gmail.com", Imagen="icj.png"},
                new Contact() {Name="Jane Doe", Email="janeDoe@gmail.com", Imagen="icj.png"},
                new Contact() {Name="Teddy Doe", Email="teddyDoe@gmail.com", Imagen="ict.png"},
                new Contact() {Name="Richard Doe", Email="richardDoe@gmail.com", Imagen="icr.png"},
                new Contact() {Name="Marilyn Doe", Email="marilynDoe@gmail.com", Imagen="icm.png"},
                new Contact() {Name="August Doe", Email="augustDoe@gmail.com", Imagen="ica.png"},
                new Contact() {Name="Silvia Doe", Email="silviaDoe@gmail.com", Imagen="ics.png"},
                new Contact() {Name="Caroline Doe", Email="carolineDoe@gmail.com", Imagen="icc.png"},
                new Contact() {Name="Luis Raúl Victorero", Email="luisraul@gmail.com", Imagen="icl.png"},
                new Contact() {Name="Rene Facio", Email="renefmeana@gmail.com", Imagen="icr.png"},
            };

        listContactos.ItemsSource = contacts.OrderBy(x => x.Name);

        //foreach (Contact contact in contacts)
        //{
        //    var imagen = "ic" + contact.Name.Substring(0, 1).ToLower() + ".png";
        //    //ImageSource image = ImageSource.FromResource("NautilusSMS.Resources.Mipmap.imagen");

        //}
    }

    public class Contact
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Imagen { get; set; }
    }
    
    private void listContactos_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        listContactos.SelectedItem=null;
    }
}
