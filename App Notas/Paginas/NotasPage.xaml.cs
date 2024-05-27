using Microsoft.Maui.Controls;

namespace App_Notas.Paginas;

public partial class NotasPage : ContentPage
{
	public NotasPage()
	{
		InitializeComponent();
	}
    private void OnAgregarClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Paginas.ApuntesPage());
    }

}