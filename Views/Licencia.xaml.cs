using System.Text;

namespace NautilusSMS.Views;

public partial class Licencia : ContentPage
{
    public Licencia()
	{
		InitializeComponent();
	}

	private async void Licencia_Load(object sender, EventArgs e)
	{
        Message.Text = "";
        StringBuilder sb = new StringBuilder();

        try
        {
            using Stream fileStream = await FileSystem.Current.OpenAppPackageFileAsync("licencia.txt");
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
            Message.Text = sb.ToString();
            reader.Close();
        }
        catch 
        {
            await DisplayAlert("Alerta", "Error leyendo fichero raw", "Cancel");
        }//End Catch
    }//End Load

}//End Class