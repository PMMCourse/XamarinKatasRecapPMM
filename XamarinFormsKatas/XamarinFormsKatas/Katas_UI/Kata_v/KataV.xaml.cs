using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_v
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataV : ContentPage
	{
		public KataV ()
		{
			InitializeComponent ();
			TextoLargo.Text = " Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut a gravida massa. Nulla a purus congue, fermentum risus eget, viverra lorem. Ut et risus laoreet dui aliquet sagittis a non lorem. Aliquam id erat vitae libero placerat iaculis et vel turpis. Mauris dignissim malesuada nulla in sollicitudin. Donec sagittis ut sapien ut luctus. Cras interdum tortor non nibh aliquet, a bibendum nibh pretium. Vivamus tellus risus, feugiat a quam eget, elementum scelerisque nunc. Integer mattis suscipit lectus nec faucibus. Duis pharetra, mauris sed interdum scelerisque, urna enim semper metus, a viverra nulla magna a nunc. Mauris dapibus magna sed semper dignissim. In eget metus vitae risus porttitor faucibus in vel nisl.";
		}
	}
}