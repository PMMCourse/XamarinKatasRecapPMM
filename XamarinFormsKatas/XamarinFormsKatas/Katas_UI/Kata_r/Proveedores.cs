using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsKatas.Katas_UI.Kata_r
{
    public class Proveedores
    {
        public string nombre { get; set; }
        public string producto { get; set; }
        public Proveedores(string Nombre, string Producto)
        {
            nombre = Nombre;
            producto = Producto;
        }
        public Proveedores()
        {

        }
        public void ToString()
        {
            return $"nombre: {nombre}, producto que provee: {producto}";
        }
    }
}
