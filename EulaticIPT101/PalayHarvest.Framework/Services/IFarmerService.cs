using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using PalayHarvest.Domain.Entities;
using PalayHarvest.Framework.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PalayHarvest.Framework.Services
{
    public interface IFarmerService
    {
        Task<List<Farmer>> GetFarmersAsync();
        Task AddFarmerAsync(Farmer farmer);
        Task UpdateFarmerAsync(Farmer farmer);
        Task DeleteFarmerAsync(int id);
    }
}
