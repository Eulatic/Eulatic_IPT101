using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using PalayHarvest.Domain.Entities;
using System.Collections.Generic;

namespace PalayHarvest.Framework.Repositories
{
    public interface IFarmerRepository
    {
        IEnumerable<Farmer> GetAll();
        void Add(Farmer farmer);
        void Update(Farmer farmer);
        void Delete(int id);
    }
}
