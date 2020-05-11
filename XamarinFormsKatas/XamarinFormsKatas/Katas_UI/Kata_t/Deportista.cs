using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsKatas.Katas_UI.Kata_t
{
    public class Deportista
    {
        public int puntuacion { get; set; }
        public string nombre { get; set; }
        public string  deporte { get; set; }
        public int edad { get; set; }
        public Deportista(int Puntuacion, string Nombre, string Deporte, int Edad)
        {
            puntuacion = Puntuacion;
            nombre = Nombre;
            deporte = Deporte;
            edad = Edad;
        }
        public Deportista()
        {

        }
        public void ToString()
        {
            return $"puntuacion: {puntuacion}, nombre: {nombre}, deporte: {deporte}, edad: {edad}";
        }
    }
}
