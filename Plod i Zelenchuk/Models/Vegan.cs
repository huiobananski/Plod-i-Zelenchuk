using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plod_i_Zelenchuk.Models
{
    public class Vegan
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Opisanie { get; set; }
        public int Cena { get; set; }

        //vrazka kam tab Vegan M:1
        public int VeganTypeId { get; set; }//FK
        public VeganTypes vegantypes { get; set; }//tablica s koqto se osashtestvqva vrazkata

    }
}
