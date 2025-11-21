using PalayHarvest.Domain.Entities;
using PalayHarvest.Framework.Data;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PalayHarvest.Framework.Repositories
{
    public class FarmerRepository : IFarmerRepository
    {
        private readonly AppDbContext _context;

        public FarmerRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Farmer> GetAll()
            => _context.Farmers.ToList();

        public void Add(Farmer farmer)
        {
            _context.Farmers.Add(farmer);
            _context.SaveChanges();
        }

        public void Update(Farmer farmer)
        {
            _context.Farmers.Update(farmer);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var farmer = _context.Farmers.Find(id);
            if (farmer != null)
            {
                _context.Farmers.Remove(farmer);
                _context.SaveChanges();
            }
        }
    }
}
