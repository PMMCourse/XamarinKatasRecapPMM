using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsKatas.Katas_UI.Kata_c
{
    public class MasterDetailPage1MasterMenuItem
    {
        public MasterDetailPage1MasterMenuItem()
        {
            TargetType = typeof(MasterDetailPage1MasterMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}
