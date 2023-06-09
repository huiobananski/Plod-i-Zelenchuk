using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plod_i_Zelenchuk.Models
{
    public class VeganContext:DbContext
    {
        public VeganContext() : base("VeganContext")
        {

        }
        public DbSet<Vegan> vegan { get; set; }//table vegan
        public DbSet<VeganTypes> veganstypes { get; set; }//table vegantypes
    }
}
