﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ecobici
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new ecobici.MainPage();
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

        public static Page GetMainPage()
        {
            return new NavigationPage(new MainPage());
        }
    }
}
