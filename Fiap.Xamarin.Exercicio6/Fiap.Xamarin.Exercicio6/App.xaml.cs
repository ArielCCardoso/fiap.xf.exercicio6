using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Fiap.Xamarin.Exercicio6.View;
using Fiap.Xamarin.Exercicio6.ViewModel;

namespace Fiap.Xamarin.Exercicio6
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            //MainPage = new Fiap.Xamarin.Exercicio6.MainPage();
            //MainPage = new NavigationPage(new ProfessorView());
            MainPage = new NavigationPage(new LoginView());

        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
