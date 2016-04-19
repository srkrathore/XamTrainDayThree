using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace XamDayThree
{
	public partial class SecTableList : ContentPage
	{
		public SecTableList ()
		{
			InitializeComponent ();
			var vListSource = App.SecDAUtil.GetAllImages();
			lstUsers.ItemsSource = vListSource;
		}
	}
}

