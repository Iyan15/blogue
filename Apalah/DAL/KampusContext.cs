using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Apalah.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Apalah.DAL
{
    public class KampusContext : DbContext
    {
        public DbSet<Mahasiswa> Mahasiswas { get; set; }
        public DbSet<Jurusan> Jurusans { get; set; }
        public DbSet<Post> Posts { get; set; } 
    }
}