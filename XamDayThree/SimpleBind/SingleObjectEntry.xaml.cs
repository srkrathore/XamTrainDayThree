using System;
using System.Collections.Generic;

using Xamarin.Forms;
using SQLite;
using SQLite.Net.Attributes;

namespace XamDayThree
{
	public partial class SingleObjectEntry : ContentPage
	{
		public SingleObjectEntry ()
		{
			InitializeComponent ();
		}
		public void OnSaveClicked (object sender, EventArgs args){

			var vUser = new AppUser () {
				UserName = "S Ravi",
				DateOfBirth = DateTime.Now,
				TimeOfBirth = DateTime.Now,
				Gender="Male",
				State="Bihar",
				Qualification="MTech",
				LoginPass="Password"
			};
			var vUserOne = new AppUser () {
				UserName = "Mansi",
				DateOfBirth = DateTime.Now,
				TimeOfBirth = DateTime.Now,
				Gender="FeMale",
				State="Punjab",
				Qualification="MTech",
				LoginPass="Password"
			};
			var vUserTwo = new AppUser () {
				UserName = "Gagandeep",
				DateOfBirth = DateTime.Now,
				TimeOfBirth = DateTime.Now,
				Gender="Male",
				State="Punjab",
				Qualification="MTech",
				LoginPass="Password"
			};
			var vUserThree = new AppUser () {
				UserName = "Heena",
				DateOfBirth = DateTime.Now,
				TimeOfBirth = DateTime.Now,
				Gender="FeMale",
				State="Bihar",
				Qualification="MTech",
				LoginPass="Password"
			};
			var vUserFour = new AppUser () {
				UserName = "Guninder",
				DateOfBirth = DateTime.Now,
				TimeOfBirth = DateTime.Now,
				Gender="FeMale",
				State="Punjab",
				Qualification="MTech",
				LoginPass="Password"
			};
			Navigation.PushAsync (new ShowSingleObject(vUser));
		/*	App.DAUtil.SaveUser (vUser);
			App.DAUtil.SaveUser (vUserOne);
			App.DAUtil.SaveUser (vUserTwo);
			App.DAUtil.SaveUser (vUserThree);
			App.DAUtil.SaveUser (vUserFour);
			Navigation.PushAsync (new AppUserList());*/
		}
	}

	public class AppUser
	{
		[PrimaryKey, AutoIncrement]
		public long UserId
		{ get; set; }
		[NotNull]
		public string UserName
		{ get; set; }
		public DateTime DateOfBirth
		{ get; set; }
		public DateTime TimeOfBirth
		{ get; set; }
		public string Gender
		{ get; set; }
		public string State
		{ get; set; }
		public string Qualification
		{ get; set; }
		public string LoginPass
		{ get; set; }

	}
}

