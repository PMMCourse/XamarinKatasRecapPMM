using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsKatas.Katas_UI.Kata_q
{
    public class EntryRenderer:EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry>e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.BorderThickness = new Thickness(0);
            }
        }
    }
}
