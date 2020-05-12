﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_w
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataW : ContentPage
	{
		public KataW()
		{
			InitializeComponent();


			NavigationButton.Clicked += (sender, e) =>
			{
				Navigation.PushAsync(new Page1(switchEntry, switchLabel, switchButton, switchAi));
			};
		}
	}
}