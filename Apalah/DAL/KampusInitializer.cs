using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Apalah.Models;

namespace Apalah.DAL
{
    public class KampusInitializer : System.Data.Entity. CreateDatabaseIfNotExists<KampusContext>
    {
        //protected override void Seed(KampusContext context)
        //{
        //    var mahasiswa = new List<Mahasiswa>
        //    {
        //        new Mahasiswa {Nama = "John Doe"},
        //        new Mahasiswa {Nama = "Danang"}
        //    };

        //    mahasiswa.ForEach(s => context.Mahasiswas.Add(s));
        //    context.SaveChanges();

        //    var jurusan = new List<Jurusan>
        //    {
        //        new Jurusan {Nama = "MI"},
        //        new Jurusan {Nama = "TI"}
        //    };

        //    jurusan.ForEach(s => context.Jurusans.Add(s));
        //    context.SaveChanges();
        //}
    }
}