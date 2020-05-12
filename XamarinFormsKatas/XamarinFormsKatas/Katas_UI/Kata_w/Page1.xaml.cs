using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_w
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1(Switch sentry, Switch slabel, Switch sbutton, Switch sactivityIndicator)
        {
            InitializeComponent();

            if (slabel.IsToggled == true)
            {
                STL1.Children.Add(new Label() { Text = "Label" });
            }

            if (sbutton.IsToggled == true)
            {
                STL1.Children.Add(new Button() { Text = "Button" });
            }

            if (sentry.IsToggled == true)
            {
                STL1.Children.Add(new Entry() { Placeholder = "Entry" });
            }

            if (sactivityIndicator.IsToggled == true)
            {
                STL1.Children.Add(new ActivityIndicator() { IsRunning = true });
            }
        }
    }
}