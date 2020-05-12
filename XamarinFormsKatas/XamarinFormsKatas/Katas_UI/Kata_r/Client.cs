using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsKatas.Katas_UI.Kata_r
{
    public class Client
    {
        public string name { get; set; }
        public string dni { get; set; }


        public Client(string name, string dni)
        {
            this.name = name;
            this.dni = dni;
        }
        public Client()
        {

        }
        public override string ToString()
        {
            return $"Client: {name}, Dni: {dni} ";
        }
    }
}
