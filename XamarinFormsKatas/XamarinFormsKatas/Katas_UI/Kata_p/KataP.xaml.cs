using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_p
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataP : ContentPage
	{
        public KataP()
        {

            InitializeComponent();
            activityIndicator.Clicked += async (sender, e) =>
            {
                ActivityIndicator activityIndicatorObject = new ActivityIndicator();
                STL1.Children.Add(activityIndicatorObject);
                activityIndicatorObject.IsRunning = true;
                await stop(5000, () => activityIndicatorObject.IsRunning = false);
            };

        }


        private async Task stop(int miliseconds, Action action)
        {
            await Task.Delay(miliseconds);
            action();
        }

    }


}