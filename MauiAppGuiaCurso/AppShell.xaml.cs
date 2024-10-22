namespace MauiAppGuiaCurso
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Registro das rotas adicionais, se necessário
            Routing.RegisterRoute(nameof(AnoPrimeiroPage), typeof(AnoPrimeiroPage));
            Routing.RegisterRoute(nameof(AnoSegundoPage), typeof(AnoSegundoPage));
            Routing.RegisterRoute(nameof(AnoTerceiroPage), typeof(AnoTerceiroPage));
        }
    }

}

