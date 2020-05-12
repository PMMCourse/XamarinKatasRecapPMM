using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsKatas.Katas_UI.Kata_w
{
    public class ControlViewModel:BaseViewModel
    {
        public ControlViewModel(Entry EControl, Label LControl, Button BControl, ActivityIndicator AControl)
        {
            pagina.Children.Add(EControl);
            pagina.Children.Add(LControl);
            pagina.Children.Add(BControl);
            pagina.Children.Add(AControl);
        }
    }
}
