using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_a
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataA : ContentPage
	{
		public KataA()
		{
			InitializeComponent();
			Binding();
		}

		void Binding()
		{
			btnB.Clicked += (sender, e) =>
			{
				Navigation.PushAsync(new Katas_UI.Kata_b.KataB());
			};

			btnC.Clicked += (sender, e) => Navigation.PushAsync(new Katas_UI.Kata_c.KataC());
			btnD.Clicked += (sender, e) => Navigation.PushAsync(new Katas_UI.Kata_d.KataD());
			btnE.Clicked += (sender, e) => Navigation.PushAsync(new Katas_UI.Kata_e.KataE());
			btnF.Clicked += (sender, e) => Navigation.PushAsync(new Katas_UI.Kata_f.KataF());
			btnG.Clicked += (sender, e) => Navigation.PushAsync(new Katas_UI.Kata_g.KataG());
			btnH.Clicked += (sender, e) => Navigation.PushAsync(new Katas_UI.Kata_h.KataH());
			btnI.Clicked += (sender, e) => Navigation.PushAsync(new Katas_UI.Kata_i.KataI());
			btnJ.Clicked += (sender, e) => Navigation.PushAsync(new Katas_UI.Kata_j.KataJ());
			btnK.Clicked += (sender, e) => Navigation.PushAsync(new Katas_UI.Kata_k.KataK());
			btnL.Clicked += (sender, e) => Navigation.PushAsync(new Katas_UI.Kata_l.KataL());
			btnM.Clicked += (sender, e) => Navigation.PushAsync(new Katas_UI.Kata_m.KataM());
			btnN.Clicked += (sender, e) => Navigation.PushAsync(new Katas_UI.Kata_n.KataN());
			btnO.Clicked += (sender, e) => Navigation.PushAsync(new Katas_UI.Kata_o.KataO());
			btnP.Clicked += (sender, e) => Navigation.PushAsync(new Katas_UI.Kata_p.KataP());
			btnQ.Clicked += (sender, e) => Navigation.PushAsync(new Katas_UI.Kata_q.KataQ());
			btnR.Clicked += (sender, e) => Navigation.PushAsync(new Katas_UI.Kata_r.KataR());
			btnS.Clicked += (sender, e) => Navigation.PushAsync(new Katas_UI.Kata_s.KataS());
			btnT.Clicked += (sender, e) => Navigation.PushAsync(new Katas_UI.Kata_t.KataT());
			btnU.Clicked += (sender, e) => Navigation.PushAsync(new Katas_UI.Kata_u.KataU());
			btnV.Clicked += (sender, e) => Navigation.PushAsync(new Katas_UI.Kata_v.KataV());
			btnW.Clicked += (sender, e) => Navigation.PushAsync(new Katas_UI.Kata_w.KataW());
			btnX.Clicked += (sender, e) => Navigation.PushAsync(new Katas_UI.Kata_x.KataX());
			btnY.Clicked += (sender, e) => Navigation.PushAsync(new Katas_UI.Kata_y.KataY());
			btnZ.Clicked += (sender, e) => Navigation.PushAsync(new Katas_UI.Kata_z.KataZ());
			btnLA.Clicked += (sender, e) => Navigation.PushAsync(new Katas_Logic.Kata_LA.KataLA());
			btnLB.Clicked += (sender, e) => Navigation.PushAsync(new Katas_Logic.Kata_LB.KataLB());
			btnLC.Clicked += (sender, e) => Navigation.PushAsync(new Katas_Logic.Kata_LC.KataLC());
			btnLD.Clicked += (sender, e) => Navigation.PushAsync(new Katas_Logic.Kata_LD.KataLD());
			btnLE.Clicked += (sender, e) => Navigation.PushAsync(new Katas_Logic.Kata_LE.KataLE());
			btnLF.Clicked += (sender, e) => Navigation.PushAsync(new Katas_Logic.Kata_LF.KataLF());
			btnLG.Clicked += (sender, e) => Navigation.PushAsync(new Katas_Logic.Kata_LG.KataLG());
			btnLH.Clicked += (sender, e) => Navigation.PushAsync(new Katas_Logic.Kata_LH.KataLH());
			btnLI.Clicked += (sender, e) => Navigation.PushAsync(new Katas_Logic.Kata_LI.Kata_LI());
			btnLJ.Clicked += (sender, e) => Navigation.PushAsync(new Katas_Logic.Kata_LJ.Kata_LJ());
			btnLK.Clicked += (sender, e) => Navigation.PushAsync(new Katas_Logic.Kata_LK.KataLK());
		}
	}
}