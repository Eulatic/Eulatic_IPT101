using PalayHarvest.Framework.Services;
using PalayHarvest.Domain.Entities;
using System.Collections.ObjectModel;
using System.Windows.Input;
using PalayHarvest.WPF.Commands;

namespace PalayHarvest.WPF.ViewModels
{
    public class FarmerViewModel : BaseViewModel
    {
        private readonly IFarmerService _farmerService;

        public ObservableCollection<Farmer> Farmers { get; set; }
            = new ObservableCollection<Farmer>();

        // Input fields
        public string Name { get; set; }
        public string Location { get; set; }
        public int HarvestQty { get; set; }

        // Commands
        public ICommand LoadFarmersCommand { get; }
        public ICommand AddFarmerCommand { get; }
        public ICommand UpdateFarmerCommand { get; }
        public ICommand DeleteFarmerCommand { get; }

        private Farmer _selectedFarmer;
        public Farmer SelectedFarmer
        {
            get => _selectedFarmer;
            set
            {
                _selectedFarmer = value;
                OnPropertyChanged();

                if (value != null)
                {
                    Name = value.Name;
                    Location = value.Location;
                    HarvestQty = value.HarvestQty;
                    OnPropertyChanged(nameof(Name));
                    OnPropertyChanged(nameof(Location));
                    OnPropertyChanged(nameof(HarvestQty));
                }
            }
        }

        public FarmerViewModel(IFarmerService farmerService)
        {
            _farmerService = farmerService;

            LoadFarmersCommand = new RelayCommand(LoadFarmers);
            AddFarmerCommand = new RelayCommand(AddFarmer);
            UpdateFarmerCommand = new RelayCommand(UpdateFarmer);
            DeleteFarmerCommand = new RelayCommand(DeleteFarmer);
        }

        private async void LoadFarmers()
        {
            Farmers.Clear();
            var list = await _farmerService.GetFarmersAsync();

            foreach (var f in list)
                Farmers.Add(f);
        }

        private async void AddFarmer()
        {
            await _farmerService.AddFarmerAsync(new Farmer
            {
                Name = Name,
                Location = Location,
                HarvestQty = HarvestQty
            });

            LoadFarmers();
        }

        private async void UpdateFarmer()
        {
            if (SelectedFarmer == null) return;

            SelectedFarmer.Name = Name;
            SelectedFarmer.Location = Location;
            SelectedFarmer.HarvestQty = HarvestQty;

            await _farmerService.UpdateFarmerAsync(SelectedFarmer);
            LoadFarmers();
        }

        private async void DeleteFarmer()
        {
            if (SelectedFarmer == null) return;

            await _farmerService.DeleteFarmerAsync(SelectedFarmer.Id);
            LoadFarmers();
        }
    }
}
