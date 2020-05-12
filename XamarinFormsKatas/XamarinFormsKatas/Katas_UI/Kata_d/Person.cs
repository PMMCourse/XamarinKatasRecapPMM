using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsKatas.Katas_UI.Kata_d
{
    public class Person
    {
        public string name { get; set; }
        public int age { get; set; }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Person()
        {

        }
    }
}