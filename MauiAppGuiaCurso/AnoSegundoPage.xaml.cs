namespace MauiAppGuiaCurso;

public partial class AnoSegundoPage : ContentPage
{
    private async void OnDesenvolvimentoWebClicked(object sender, EventArgs e)
    {
        // L�gica de navega��o para a p�gina DesenvolvimentoWebPage
        await Shell.Current.GoToAsync("DesenvolvimentoWebPage");
    }

}