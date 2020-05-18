using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_j
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataJ : ContentPage
	{
		public KataJ ()
		{
			InitializeComponent ();
		}

		private async void btnLogin(object sender, EventArgs e)
		{
			var error_login = false;
			var message = "";
			var coloractual = username.BackgroundColor;
			if (string.IsNullOrEmpty(username.Text))
			{
				message += "Debe introducir un nombre de usuario\n";
				username.BackgroundColor = Color.Red;
				error_login = true;
			}

			if (string.IsNullOrEmpty(password.Text))
			{
				message += "Debe introducir la password";
				password.BackgroundColor = Color.Red;
				error_login = true;
			}

			if (error_login == true)
			{
				lblError.Text = message;
				await Task.Delay(3000);
				username.BackgroundColor = coloractual;
				password.BackgroundColor = coloractual;
				lblError.Text = "";
			}
			else
			{
				username.BackgroundColor = coloractual;
				password.BackgroundColor = coloractual;
				lblError.Text = "Datos introducidos correctamente. Necesario verificar acceso.";
			}
		}
	}
}