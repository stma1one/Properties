using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Cookie
    {
        private string flavor;
        //private int _raising;
        //auto Property - רק אם הקריאה וההשמה של ערכים ללא בדיקות/שינוי
        public int Raising { get; set; }

        //accessor - משתנה גישה
        //Property
        //מאחזר -= get
        //קובע set
        public string Flavor { get { return flavor; } set { if (value != "Chocolate") flavor = "Vanilla"; else flavor = value; }

            //  public string GetFlavor() { return flavor; }
            // public void SetFlavor(string flavor)
            // { this.flavor = flavor; }

        }
    }
}
