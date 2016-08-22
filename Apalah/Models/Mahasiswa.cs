using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Apalah.Models
{
    public class Mahasiswa
    {
        public int ID { get; set; }
        public string Nama { get; set; }
        public string Alamat { get; set; }
        public string Hobi { get; set; }

        public virtual Jurusan Jurusan { get; set; }
    }
}