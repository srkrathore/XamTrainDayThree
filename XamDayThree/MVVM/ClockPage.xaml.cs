﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.ComponentModel;

namespace XamDayThree
{
	public partial class ClockPage : ContentPage
	{
		public ClockPage ()
		{
			
			InitializeComponent ();
			var vClkViewModel = new ClockViewModel ();
			lblTime.BindingContext = vClkViewModel; 
		}
	}

	public class ClockViewModel : INotifyPropertyChanged
	{
		DateTime dateTime;

		public event PropertyChangedEventHandler PropertyChanged;

		public ClockViewModel()
		{
			this.DateTime = DateTime.Now;

			Device.StartTimer(TimeSpan.FromSeconds(1), () =>
				{
					this.DateTime = DateTime.Now;
					return true;
				});
		}

		public DateTime DateTime
		{
			set
			{
				if (dateTime != value)
				{
					dateTime = value;

					if (PropertyChanged != null)
					{
						PropertyChanged(this,
							new PropertyChangedEventArgs("DateTime"));
					}
				}
			}
			get
			{
				return dateTime;
			}
		}
	}
}

