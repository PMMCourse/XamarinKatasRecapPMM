using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using XamarinFormsKatas.Katas_UI.Kata_b;
using XamarinFormsKatas.Katas_UI.Kata_c;
using XamarinFormsKatas.Katas_UI.Kata_d;
using XamarinFormsKatas.Katas_UI.Kata_e;
using XamarinFormsKatas.Katas_UI.Kata_f;
using XamarinFormsKatas.Katas_UI.Kata_g;
using XamarinFormsKatas.Katas_UI.Kata_h;
using XamarinFormsKatas.Katas_UI.Kata_i;
using XamarinFormsKatas.Katas_UI.Kata_j;
using XamarinFormsKatas.Katas_UI.Kata_k;
using XamarinFormsKatas.Katas_UI.Kata_l;
using XamarinFormsKatas.Katas_UI.Kata_m;
using XamarinFormsKatas.Katas_UI.Kata_n;
using XamarinFormsKatas.Katas_UI.Kata_o;
using XamarinFormsKatas.Katas_UI.Kata_p;
using XamarinFormsKatas.Katas_UI.Kata_q;
using XamarinFormsKatas.Katas_UI.Kata_r;
using XamarinFormsKatas.Katas_UI.Kata_s;
using XamarinFormsKatas.Katas_UI.Kata_t;
using XamarinFormsKatas.Katas_UI.Kata_u;
using XamarinFormsKatas.Katas_UI.Kata_v;
using XamarinFormsKatas.Katas_UI.Kata_w;
using XamarinFormsKatas.Katas_UI.Kata_x;
using XamarinFormsKatas.Katas_UI.Kata_y;
using XamarinFormsKatas.Katas_UI.Kata_z;
using XamarinFormsKatas.Katas_Logic.Kata_LA;
using XamarinFormsKatas.Katas_Logic.Kata_LB;
using XamarinFormsKatas.Katas_Logic.Kata_LC;
using XamarinFormsKatas.Katas_Logic.Kata_LD;
using XamarinFormsKatas.Katas_Logic.Kata_LE;
using XamarinFormsKatas.Katas_Logic.Kata_LF;
using XamarinFormsKatas.Katas_Logic.Kata_LG;
using XamarinFormsKatas.Katas_Logic.Kata_LH;
using XamarinFormsKatas.Katas_Logic.Kata_LI;
using XamarinFormsKatas.Katas_Logic.Kata_LJ;
using XamarinFormsKatas.Katas_Logic.Kata_LK;

namespace XamarinFormsKatas.Katas.Kata1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Kata1View : ContentPage
    {
        public Kata1View()
        {
            InitializeComponent();


            B.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new KataB());
            };

            C.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_c.MasterDetailPage1());
            };

            D.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new KataD());
            };

            E.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new KataE());
            };

            F.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new KataF());
            };

            G.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new KataG());
            };

            H.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new KataH());
            };

            I.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new KataI());
            };

            J.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new KataJ());
            };

            K.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new KataK());
            };

            L.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new KataL());
            };

            M.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new KataM());
            };

            N.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new KataN());
            };

            O.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new KataO());
            };

            P.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new KataP());
            };

            Q.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new KataQ());
            };

            R.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new KataR());
            };

            S.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new KataS());
            };


            T.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new KataT());
            };

            U.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new KataU());
            };

            V.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new KataV());
            };

            W.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new KataW());
            };

            X.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new KataX());
            };

            Y.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new KataY());
            };

            Z.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new KataZ());
            };



            LB.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new KataLB());
            };

            LC.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new KataLC());
            };

            LD.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new KataLD());
            };

            LF.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new KataLF());
            };

            LE.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new LEView());
            };

            LG.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new KataLG());
            };

            LI.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Kata_LI());
            };

            I.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new KataI());
            };

            J.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new KataJ());
            };

            K.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new KataK());
            };

            L.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new KataL());
            };

        }
    }
}