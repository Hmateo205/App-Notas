using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace App_Notas
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
