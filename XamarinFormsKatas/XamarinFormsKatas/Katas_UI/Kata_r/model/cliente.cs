using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsKatas.Katas_UI.Kata_r
{
    class cliente : persona
    {
        private String dni;
        public String Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public cliente(string _nombre, string _dni)
        {
            Nombre= _nombre;
            Dni = _dni;
        }
        public string Datos_Lista
        {
            get
            {
                return Nombre + ", " + Dni;
            }
        }
    }
}
