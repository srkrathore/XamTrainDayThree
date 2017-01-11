using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly:XamlCompilation(XamlCompilationOptions.Compile)]
namespace XamDayThree
{
	public class App : Application
	{
		static DataAccess dbUtils;
		static SecDataAccess secDbUtils;
		public App ()
		{
            // The root page of your application

            var vUser = new AppUser()
            {
                UserName = "S Ravi",
                DateOfBirth = DateTime.Now,
                TimeOfBirth = DateTime.Now,
                Gender = "Male",
                State = "Bihar",
                Qualification = "MTech",
                LoginPass = "Password"
            };
            var vUserOne = new SecAppUser()
            {
                UserName = "Mansi",
                DateOfBirth = DateTime.Now,
                TimeOfBirth = DateTime.Now,
                Gender = "FeMale",
                State = "Punjab",
                Qualification = "MTech",
                LoginPass = "Password"
            };

            var vTabEx = new TabbedPage();
            vTabEx.Children.Add(new ShowSingleObject() { Title="First User", BindingContext = vUser });
            vTabEx.Children.Add(new ShowSingleObject() { Title = "User", BindingContext = vUserOne });
            //MainPage = vTabEx;
			//MainPage = new NavigationPage( new AppUserList());
			//MainPage = new NavigationPage( new SimpleViewModel());
			//MainPage = new NavigationPage( new ClockPage());
			MainPage = new NavigationPage( new InteractiveEx());
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
		public static SecDataAccess SecDAUtil {
			get { 
				if (secDbUtils == null) {
					secDbUtils = new SecDataAccess();
				}
				return secDbUtils; 
			}
		}
	}
}

