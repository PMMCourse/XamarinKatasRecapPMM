using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_l
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataL : ContentPage
	{
		public KataL ()
		{
			InitializeComponent ();
		}
        public void swipeControlLeft(object sender, EventArgs e)
        {
            LabelPrincipal.Text = "swipe a la izquierda";
        }
        public void swipeControlRight(object sender, EventArgs e)
        {
            LabelPrincipal.Text = "swipe a la derecha";
        }
        public void tapControl(object sender, EventArgs e)
        {
            LabelPrincipal.Text = "tap";
        }
        public void pinchControl(object sender, EventArgs e)
        {
            LabelPrincipal.Text = "pinch";
        }
    }
}