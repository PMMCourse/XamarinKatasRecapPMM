using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsKatas.Katas_UI.Kata_t
{
    public class Athlete
    {
        public int Puntuation { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Sport { get; set; }

        public Athlete(int puntuation, int age, string name, string sport)
        {
            Puntuation = puntuation;
            Age = age;
            Name = name;
            Sport = sport;
        }

        public string Tostring
        {
            get
            {
                return $"Puntuacion: {Puntuation}, Edad: {Age}, Nombre: {Name}, Deporte: {Sport}";
            }
        }
    }
}
