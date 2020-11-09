using System;
using SQLite.Net;
using Xamarin.Forms;
using System.IO;
using XamarinFNPV;
using System.Linq;
using System.Collections.Generic;
using SQLite.Net.Interop;
using System.IO;

namespace XamarinFNPV
{
    class DataAccess : IDisposable

    {
        private SQLiteConnection connection;


        public DataAccess()
        {
            //var configu = DependencyService.Get<IConfig>();
            //connection = new SQLiteConnection(configu.Plataforma, Path.Combine(configu.DirectorioBD, "Encuesta.db3"));
            //    connection.CreateTable<Encuesta>();
            





        }

        public void InserEncuesta(Encuesta encuesta)
        {
            connection.Insert(encuesta);
        }

        public void UpdateEncuesta(Encuesta encuesta)
        {
            connection.Update(encuesta);
        }
        public void DeleteEncuesta(Encuesta encuesta)
        {
            connection.Delete(encuesta);
        }
        //public List<Encuesta> getEncuesta()
        //{

        //  //  return connection.Table<Encuesta>().OrderBy(c => c.NombreBrigada).ToList();

        //}

        public void Dispose()
        {
            connection.Dispose();
        }

    }
}
