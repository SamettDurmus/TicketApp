using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace GorselProjeBilet
{
    class kayitCONTEXT : DbContext
    {
        public kayitCONTEXT() : base()
        {

        }
        public DbSet<veriler> yolcuverileri { get; set; }
    }
}
