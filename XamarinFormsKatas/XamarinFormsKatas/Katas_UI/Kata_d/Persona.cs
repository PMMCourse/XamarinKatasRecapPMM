using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsKatas.Katas_UI.Kata_d
{
    class Persona
    {
        public string nombre { get; set; }
        public int edad { get; set; }
        public string imagen { get; set; }
        public Persona(string Nombre,int Edad, string Imagen )
        {
            this.nombre = Nombre;
            this.edad = Edad;
            this.imagen=Imagen;
        }
        public string ToString()
        {
            return nombre + "  " + edad;  
        }
    }
}
