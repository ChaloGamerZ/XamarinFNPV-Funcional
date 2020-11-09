using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using SQLite.Net.Interop;
using Xamarin.Forms;

[assembly:Dependency(typeof(XamarinFNPV.Droid.Config))]

namespace XamarinFNPV.Droid
{
    class Config : IConfig
    {
        private string DirectorioBDdroid;
        private ISQLitePlatform Plataformadroid;

        string IConfig.DirectorioBD
        {
            get
            {
                if (string.IsNullOrEmpty(DirectorioBDdroid))
                {
                    DirectorioBDdroid = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

                }
                return DirectorioBDdroid;
            }
        }

        ISQLitePlatform IConfig.Plataforma
        {
            get
            {
                if (Plataformadroid == null)
                {
                    Plataformadroid = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
                }
                return Plataformadroid;
            }
        }

       
    }
}