using System;
using Xamarin.Forms;

namespace XamDayThree
{
	public class App : Application
	{
		static DataAccess dbUtils;
		public App ()
		{
			// The root page of your application
			MainPage = new NavigationPage( new AppUserList());
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

		public static DataAccess DAUtil {
			get { 
				if (dbUtils == null) {
					dbUtils = new DataAccess();
				}
				return dbUtils; 
			}
		}
	}
}

