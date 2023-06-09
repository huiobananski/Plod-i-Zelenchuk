using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plod_i_Zelenchuk.Models
{
    public class VeganTypes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //1:M
        public ICollection<Vegan> Vegan { get; set; }
    }
}
