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
    public class FarmerService : IFarmerService
    {
        private readonly IFarmerRepository _repository;

        public FarmerService(IFarmerRepository repository)
        {
            _repository = repository;
        }

        public Task<List<Farmer>> GetFarmersAsync()
            => Task.FromResult(_repository.GetAll().ToList());

        public Task AddFarmerAsync(Farmer farmer)
        {
            _repository.Add(farmer);
            return Task.CompletedTask;
        }

        public Task UpdateFarmerAsync(Farmer farmer)
        {
            _repository.Update(farmer);
            return Task.CompletedTask;
        }

        public Task DeleteFarmerAsync(int id)
        {
            _repository.Delete(id);
            return Task.CompletedTask;
        }
    }
}

