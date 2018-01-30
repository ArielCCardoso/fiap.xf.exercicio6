using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Fiap.Xamarin.Exercicio6.Model;

namespace Fiap.Xamarin.Exercicio6.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginView : ContentPage
	{
		public LoginView ()
		{
			InitializeComponent ();
		}
        //async void OnSignUpButtonClicked(object sender, EventArgs e)
        //{
          //  await Navigation.PushAsync(new SignUpPage());
        //}

        async void OnEntrarButtonClicked(object sender, EventArgs e)
        {
            var user = new Login
            {
                Username = login.Text,
                Password = senha.Text
            };

            var isValid = AreCredentialsCorrect(user);
            if (isValid)
            {
                //App.IsUserLoggedIn = true;
                //Navigation.InsertPageBefore(new MainPage(), this);
                //await Navigation.PopAsync();

                //new NavigationPage(new ProfessorView());
                Navigation.InsertPageBefore(new ProfessorView(), this);
                await Navigation.PopAsync();

            }
            else
            {
                entrar.Text = "Falha no login - login ou senha incorretos";
                senha.Text = string.Empty;
            }
        }

        bool AreCredentialsCorrect(Login user)
        {
            return user.Username == "ariel" && user.Password == "1234";
        }
    }
}
