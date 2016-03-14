using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamDayThree
{
	public partial class ShowSingleObject : ContentPage
	{
		public ShowSingleObject ( AppUser aUser)
		{
			InitializeComponent ();
			BindingContext = aUser;
		}
	}
}

