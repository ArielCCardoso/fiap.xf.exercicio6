using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Fiap.Xamarin.Exercicio6.Model;
using Fiap.Xamarin.Exercicio6.ViewModel;

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
            LoginViewModel loginVM = new LoginViewModel();

            var _login = new Login
            {
                login = login.Text,
                senha = senha.Text
            };

            //var isValid = AreCredentialsCorrect(user);
            var isValid = loginVM.ValidaLogin(_login);
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
            return user.login == "ariel" && user.senha == "1234";
        }
    }
}
