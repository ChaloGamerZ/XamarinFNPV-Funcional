using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite.Net.Attributes;
using System.Runtime.CompilerServices;
using XLabs.Forms.Controls;



//xmlns: controls = "clr-namespace:XLabs.Forms.Controls;assembly=XLabs.Forms"

namespace XamarinFNPV
{
    public class Encuesta
    {
        
        public DateTime FechaEncuesta { get; set; }
        public string NombreBrigadista { get; set; }
        public  string NombreBrigada { get; set; }

        public RadioButton CBpreg1 { get; set; }
        public RadioButton CBpreg2 { get; set; }
        public RadioButton CBpreg3 { get; set; }
        public RadioButton CBpreg4 { get; set; }
        public RadioButton CBpreg5 { get; set; }
        public RadioButton CBpreg6 { get; set; }
        public string ComenObs { get; set; }





        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4} {5}  {6} {7} {8} {9}", FechaEncuesta, NombreBrigadista, NombreBrigada, CBpreg1, CBpreg2, CBpreg3, CBpreg4, CBpreg5, CBpreg6, ComenObs);
        }
    }

}
