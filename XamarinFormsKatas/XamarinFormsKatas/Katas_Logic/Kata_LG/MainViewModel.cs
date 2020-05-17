using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamarinFormsKatas.Katas_Logic.Kata_LA;

namespace XamarinFormsKatas.Katas_Logic.Kata_LG
{
    public class MainViewModel : BaseViewModel
    {

        private Entry eControl;
        private Label lControl;
        private Button bControl;
        private ActivityIndicator aControl;

        public MainViewModel()
        {

        }

        public MainViewModel(Entry EControl, Label LControl, Button BControl, ActivityIndicator AControl)
        {
            this.eControl = EControl;
            this.lControl = LControl;
            this.bControl = BControl;
            this.aControl = AControl;
        }

        private void clickBoton(object sender, EventArgs e)
        {
            eControl.IsVisible = false;
            lControl.IsVisible = false;
            bControl.IsVisible = false;
            aControl.IsVisible = false;
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
        }
    }
}
