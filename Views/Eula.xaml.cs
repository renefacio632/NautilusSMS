using System.Text;

namespace NautilusSMS.Views;

public partial class Eula : ContentPage
{
	public Eula()
	{
		InitializeComponent();
	}
    private async void Eula_Load(object sender, EventArgs e)
    {
        Message.Text = "";
        StringBuilder sb = new StringBuilder();

        try
        {
            //StreamReader fraw = new StreamReader("F:\\Datos\\VSProyectos MAUI\\NautilusSMS\\Raw\\eula.txt", Encoding.Default);
            using Stream fileStream = await FileSystem.Current.OpenAppPackageFileAsync("eula.txt");
            using StreamReader reader = new StreamReader(fileStream);

            String line = reader.ReadLine();
            sb.Append(line).Append("\n");
            while (line != null)
            {
                line = reader.ReadLine();
                if (line != null)
                {
                    sb.Append(line).Append("\n");
                }
            }
            Message.Text = (sb.ToString());
            reader.Close();
        }
        catch
        {
            await DisplayAlert("Alerta", "Error leyendo fichero raw", "Cancel");
        }
    }
}