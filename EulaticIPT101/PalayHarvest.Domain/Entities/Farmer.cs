using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalayHarvest.Domain.Entities
{
    public class Farmer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int HarvestQty { get; set; }   // MUST MATCH ViewModel
    }
}
