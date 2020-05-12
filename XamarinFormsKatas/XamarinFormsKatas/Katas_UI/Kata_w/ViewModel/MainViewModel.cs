using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsKatas.Katas_UI.Kata_w
{
    public class MainViewModel:BaseViewModel
    {
        public MainViewModel()
        {

        }
        private void btn_Clicked(object sender, EventArgs e)
        {
            EControl.IsVisible = false;
            LControl.IsVisible = false;
            BControl.IsVisible = false;
            AControl.IsVisible = false;
            if (switchE.IsToggled)
            {
                EControl.IsVisible = true;
            }
            if (switchL.IsToggled)
            {
                LControl.IsVisible = true;
            }
            if (switchB.IsToggled)
            {
                BControl.IsVisible = true;
            }
            if (switchA.IsToggled)
            {
                AControl.IsVisible = true;
            }
            Navigation.PushAsync(new Katas_UI.Kata_w.controlElementos(EControl, LControl, BControl, AControl));
        }
    }
}
