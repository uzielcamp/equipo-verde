using Proyecto_Final.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
   public class DataContext:DbContext
    {
        public DbSet<Adviser> Advisers { get; set; }
        public DbSet<Coach> Coaches { get; set; }
        public DbSet<Company> Comapanies { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet <Coordinator> Coordinators { get; set; }
        public DbSet<Major> Majors { get; set; }
        public DbSet <Student> Students { get; set; }
        public object Companies { get; internal set; }

        public DataContext() : base("name=miConexion")
        {

        }

    }
    
    
}
