using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_k
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataK : ContentPage
	{
        Random RandomNumber = new Random();
        List<int> RandomList = new List<int>();

        public KataK()
        {
            InitializeComponent();
            LoadData();

            List.RefreshCommand = new Command(() => {
                List.IsRefreshing = true;
                LoadData();
            });
        }

        void LoadData()
        {
            List.ItemsSource = null;
            RandomList.Add(RandomNumber.Next());
            List.ItemsSource = RandomList;
            List.IsRefreshing = false;
        }
    }
}