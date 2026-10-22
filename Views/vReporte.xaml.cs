namespace esalazarS3.Views;

public partial class vReporte : ContentPage
{
	public vReporte(string usuario)
	{
		InitializeComponent();
		DisplayAlertAsync("HOLA"+usuario, "Bienvenido", usuario, "ok");
	}
}