using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsKatas.Katas_Logic.Kata_LI
{
    public class Telefono: ITelefono
    {
        public void HacerLLamada(string numero)
        {
            var url = Android.Net.Uri.Parse("telefono: " + numero);
            Intent intent = new Intent(intent.ActionCall, url);
            Forms.Context.StartActivity(intent);
        }
    }
}
