using Plod_i_Zelenchuk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plod_i_Zelenchuk.Controllers
{
    public class VeganTypesLogic
    {
        private VeganContext _VeganDbContext = new VeganContext(); // Това е БД тук!!!!
        public List<VeganTypes> GetAllVeganTypes()
        {
            return _VeganDbContext.veganstypes.ToList();
        }
        public string GetVeganTypesById(int id)
        {
            return _VeganDbContext.veganstypes.Find(id).Name;
        }

        internal void Create(object newDog)
        {
            throw new NotImplementedException();
        }
    }
}
    