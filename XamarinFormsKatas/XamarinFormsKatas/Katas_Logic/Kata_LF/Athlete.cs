using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsKatas.Katas_Logic.Kata_LF
{
    public class Athlete
    {
        public int Points { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Sport { get; set; }

        public Athlete(int points, int age, string name, string sport)
        {
            this.Points = points;
            this.Age = age;
            this.Name = name;
            this.Sport = sport;
        }
        public Athlete()
        {

        }
    }
}
