using CommunityToolkit.Maui.Markup;
using DocumentFormat.OpenXml.Drawing;
using NautilusSMS.Settings;

namespace NautilusSMS.Views;

public partial class Settings : ContentPage
{
	public Settings()
	{
		InitializeComponent();
        
    }
    
    private async void OnPreferencias(object sender, EventArgs e)
    {
        await PreferenciasBtn.Navigation.PushAsync(new PreferenciasPage());
    }

    private async void OnTelefono(object sender, EventArgs e)
    {
        await TelfBtn.Navigation.PushAsync(new DatosTellfPage());
    }

    private async void OnEmergente(object sender, EventArgs e)
    {
        await BorraEmergenteBtn.Navigation.PushAsync(new BorraEmergentePage());
    }

    private async void OnPrivados(object sender, EventArgs e)
    {
        await PrivadosBtn.Navigation.PushAsync(new PrivadosPage());
    }
}