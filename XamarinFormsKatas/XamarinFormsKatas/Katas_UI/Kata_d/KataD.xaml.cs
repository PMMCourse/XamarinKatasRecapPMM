using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_d
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataD : ContentPage
	{
        public KataD()
        {
            InitializeComponent();

            insertOnList();
        }
        private void insertOnList()
        {
            Person pepe = new Person("Pepe", 20);
            Person carlos = new Person("Carlos", 23);


            List<Person> listOfPersons = new List<Person>();
            listOfPersons.Add(pepe);
            listOfPersons.Add(carlos);


            list.ItemsSource = listOfPersons;
        }
    }
}