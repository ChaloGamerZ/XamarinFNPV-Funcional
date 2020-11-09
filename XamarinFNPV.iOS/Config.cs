using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using SQLite.Net.Interop;
using UIKit;

using Xamarin.Forms;

[assembly: Dependency(typeof(XamarinFNPV.iOS.Config))]

namespace XamarinFNPV.iOS
{
    class Config : IConfig
    {
        private string DirectorioBDIos;
        private ISQLitePlatform PlataformaIos;


        public string DirectorioBD
        {
            get
            {
                if (string.IsNullOrEmpty(DirectorioBDIos))
                {
                    var directorio = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                    DirectorioBDIos = System.IO.Path.Combine(directorio, "..", "Library");
                }
                return DirectorioBDIos;
            }
            
        }

public ISQLitePlatform Plataforma
{
            get
            {
                if (PlataformaIos == null)
                {
                    PlataformaIos = new SQLite.Net.Platform.XamarinIOS.SQLitePlatformIOS();
                }
                return PlataformaIos;
            }
        }
            
    }
}