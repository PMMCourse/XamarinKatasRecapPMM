﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_g
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataG : ContentPage
	{
		public KataG()
		{
			InitializeComponent();

			RotateButton.Clicked += async (sender, e) =>
			{
				await RotateButton.RotateTo(360, 500);
				RotateButton.Rotation = 0;
			};

		}
	}
}