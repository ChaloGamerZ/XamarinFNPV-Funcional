using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using SQLite.Net.Interop;

namespace XamarinFNPV
{
    public interface IConfig
    {
        public string DirectorioBD {get;}

        public ISQLitePlatform Plataforma { get; }
    }
}
