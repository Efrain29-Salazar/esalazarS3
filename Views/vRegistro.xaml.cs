namespace esalazarS3.Views;

public partial class vRegistro : ContentPage
{
	public vRegistro()
	{
		InitializeComponent();
	}

    private void btnGuardar_Clicked(object sender, EventArgs e)
    {
		try
		{
			string usuarioNuevo = txtUsuarioNuevo.Text;
			string contrasenaNueva = txtContraseña.Text;
			Navigation.PushAsync(new vLogin(usuarioNuevo, contrasenaNueva));
			DisplayAlertAsync("Alerta", "Usuario Guardado", "Cerrar");
		}

		catch (Exception ex)
		{
            DisplayAlertAsync("Error", ex.Message, "Cerrar");
        }

    }
}