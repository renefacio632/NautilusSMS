namespace NautilusSMS.Settings;

public partial class PreferenciasPage : ContentPage
{
	public PreferenciasPage()
	{
		InitializeComponent();
	}

    private async void settingNotificacion(object sender, EventArgs e)
    {
        await SettNotif.Navigation.PushAsync(new SettingNotify());
    }

    private async void settingProteccion(object sender, EventArgs e)
    {
        await SettProtec.Navigation.PushAsync(new SettingProtect());
    }
}