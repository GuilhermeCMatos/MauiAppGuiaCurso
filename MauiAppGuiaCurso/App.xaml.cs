namespace MauiAppGuiaCurso
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Definindo AppShell como a página inicial do aplicativo
            MainPage = new AppShell();
        }
    }

}
