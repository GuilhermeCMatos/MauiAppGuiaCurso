namespace MauiAppGuiaCurso;

public partial class AnoSegundoPage : ContentPage
{
    private async void OnDesenvolvimentoWebClicked(object sender, EventArgs e)
    {
        // Lógica de navegação para a página DesenvolvimentoWebPage
        await Shell.Current.GoToAsync("DesenvolvimentoWebPage");
    }

}