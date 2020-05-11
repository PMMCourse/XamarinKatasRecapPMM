using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsKatas.Katas_UI.Kata_r
{
    public class Cliente
    {
        public string nombre { get; set; }
        public string dni { get; set; }

        public Cliente(string Nombre, string Dni)
        {
            this.nombre = Nombre;
            this.dni = Dni;
        }
        public Cliente()
        {

        }
        public void ToString()
        {
            return $" nombre: {nombre}, dni: {dni}";
        }
    }
}
