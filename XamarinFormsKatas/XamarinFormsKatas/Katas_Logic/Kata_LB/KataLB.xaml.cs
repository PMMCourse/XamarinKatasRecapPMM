using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_Logic.Kata_LB
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataLB : ContentPage
	{
		/*private KataLB DataContext;*/

		public KataLB ()
		{
			InitializeComponent ();
			/*
			DataContext = new KataLB();
			using (StreamReader r = new StreamReader(@"D:\Users\Javier\Desktop\ProyectosGit\XamarinKatasRecapPMM\XamarinFormsKatas\XamarinFormsKatas\Katas_Logic\Kata_LB\json.json"))
            {
                string json = r.ReadToEnd();
                List<News> Lista = JsonConvert.DeserializeObject<List<News>>(json);


			}
			*/
		}

	}
}