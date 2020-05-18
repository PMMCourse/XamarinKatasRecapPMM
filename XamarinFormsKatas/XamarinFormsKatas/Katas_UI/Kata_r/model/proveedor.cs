using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsKatas.Katas_UI.Kata_r
{
    public class proveedor : persona
    {
        private String producto;
        public String Producto
        {
            get { return producto; }
            set { producto = value; }
        }
        public proveedor(string _nombre, string _producto)
        {
            Nombre = _nombre;
            Producto = _producto;
        }
        public string Datos_Lista
        {
            get
            {
                return Nombre + ", " + Producto;
            }
        }
    }
}
