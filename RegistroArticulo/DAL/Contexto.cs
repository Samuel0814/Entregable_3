using RegistroArticulo.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace RegistroArticulo.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Articulos> Articulo { get; set; }
        public Contexto() : base("ConStr")
        { }
    }
}
