using Plod_i_Zelenchuk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plod_i_Zelenchuk.Controllers
{
    public class VeganLogic
    {

        private VeganContext _VeganDbContext = new VeganContext();

        public Vegan get(int id)
        {
            Vegan findedVegan = _VeganDbContext.vegan.Find(id);
            if (findedVegan!= null)
            {
                _VeganDbContext.Entry(findedVegan).Reference(x => x.vegantypes).Load();
            }
            return findedVegan;

        }
        public List<Vegan> GetAll()
        {
            return _VeganDbContext.vegan.Include("Breed").ToList();
        }
        public void Create(Vegan Vegan)
        {
            _VeganDbContext.vegan.Add(Vegan);
            _VeganDbContext.SaveChanges();
        }
        public void Update(int id, Vegan Vegan)
        {
            Vegan findedVegan = _VeganDbContext.vegan.Find(id);
            if (findedVegan == null) //
            {
                return;
            }
            findedVegan.Opisanie = Vegan.Opisanie;
            findedVegan.Name = Vegan.Name;
            findedVegan.Cena= Vegan.Cena;
            _VeganDbContext.SaveChanges();
        }
        public void Delete(int id)
        {
            Vegan findedVegan = _VeganDbContext.vegan.Find(id);
            _VeganDbContext.vegan.Remove(findedVegan);
            _VeganDbContext.SaveChanges();
        }

        internal Vegan Get(int id)
        {
            throw new NotImplementedException();
        }

        internal List<Vegan> GetAllVeganTypes()
        {
            throw new NotImplementedException();
        }
    }
}

