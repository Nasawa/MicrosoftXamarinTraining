using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

using Xamarin.Forms;

namespace DroneLander
{
	public partial class App : Application
	{
		public static MainViewModel ViewModel { get; set; }

		public App()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new DroneLander.MainPage());
		}

		protected override void OnStart()
		{
			MobileCenter.Start("android=189a8718-d7a0-4b81-abaf-05e8bd56f90c;" +
				   "uwp={Your UWP App secret here};" +
				   "ios={Your iOS App secret here}",
				   typeof(Analytics), typeof(Crashes));
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
