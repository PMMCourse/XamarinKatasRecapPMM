﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_t
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataT : ContentPage
	{
		public List<Deportista> deporList = new List<Deportista>();
		public KataT()
		{
			InitializeComponent();

			var d1 = new Deportista( 123, 19, "No binario", "Voleyball");
			var d2 = new Deportista(30, 18 ,"Hombre blanco Cis genero", "Padel");

			deporList.Add(d1);
			deporList.Add(d2);

			listview.ItemsSource = deporList;

		}
	}
}