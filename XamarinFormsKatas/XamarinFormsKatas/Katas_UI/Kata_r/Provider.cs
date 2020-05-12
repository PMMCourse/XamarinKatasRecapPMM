using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsKatas.Katas_UI.Kata_r
{
    public class Provider
    {
        public string name { get; set; }
        public string product { get; set; }


        public Provider(String name, string product)
        {
            this.name = name;
            this.product = product;
        }
        public Provider()
        {

        }
        public override string ToString()
        {
            return $"Provider: {name}, Product: {product}";

        }
    }
}