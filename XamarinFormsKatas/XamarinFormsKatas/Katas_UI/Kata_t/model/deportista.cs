using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsKatas.Katas_UI.Kata_t.model
{
    public class deportista
    {
        private Double puntuacion;
        public Double Puntuacion
        {
            get { return puntuacion; }
            set { puntuacion = value; }
        }
        private String nombre;
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private String deporte;
        public String Deporte
        {
            get { return deporte; }
            set { deporte = value; }
        }
        private int edad;
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
    }
}
