using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiCollectionViewLayout.DataModels
{
    public class Scale
    {
        public string Label { get; set; }
        public List<MyValue> ValueList { get; set; }



        public Scale()
        {
            ValueList = new List<MyValue>();
        }
    }
}
