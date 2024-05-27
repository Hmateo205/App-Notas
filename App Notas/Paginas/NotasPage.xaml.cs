using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace App_Notas.Paginas;

public partial class NotasPage : ContentPage
{
    public ObservableCollection<Nota> Notas { get; set; } = new ObservableCollection<Nota>();

    public NotasPage()
    {
        InitializeComponent();
        NotasListView.ItemsSource = Notas;

        MessagingCenter.Subscribe<ApuntesPage, Nota>(this, "AgregarNota", (sender, nota) =>
        {
            Notas.Add(nota);
        });
    }

    private async void OnAgregarClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ApuntesPage());
    }

    private async void OnNotaTapped(object sender, ItemTappedEventArgs e)
    {
        if (e.Item != null && e.Item is Nota nota)
        {
            bool confirm = await DisplayAlert("Eliminar Nota", $"¿Desea eliminar la nota '{nota.Titulo}'?", "Sí", "No");
            if (confirm)
            {
                Notas.Remove(nota);
            }
        }
    }
}