namespace App_Notas.Paginas;

public partial class ApuntesPage : ContentPage
{
    public ApuntesPage()
    {
        InitializeComponent();
    }

    private async void OnGuardarClicked(object sender, EventArgs e)
    {
        var titulo = TituloEntry.Text;
        var descripcion = DescripcionEditor.Text;

        // Validar que los campos no estén vacíos
        if (string.IsNullOrWhiteSpace(titulo) || string.IsNullOrWhiteSpace(descripcion))
        {
            await DisplayAlert("Error", "Por favor, complete todos los campos.", "OK");
            return;
        }

        // Crear la nota y pasarla de regreso a NotasPage
        var nuevaNota = new Nota { Titulo = titulo, Descripcion = descripcion };
        MessagingCenter.Send(this, "AgregarNota", nuevaNota);

        // Volver a la página de Notas
        await Navigation.PopAsync();
    }
}

public class Nota
{
    public string Titulo { get; set; }
    public string Descripcion { get; set; }
}