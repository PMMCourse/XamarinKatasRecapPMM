using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_m
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataM : ContentPage
	{
		private static int _lbNumber = 0;
		public KataM ()
		{
			InitializeComponent ();

			Binding();
		}

		void Binding()
		{
			btnLabelCreator.Clicked += (sender, e) =>
			{
				Label lb = new Label();
				lb.Text = "Label numero " + _lbNumber;
				_lbNumber ++;
				mainStack.Children.Add(lb);
			};
		}
	}
}