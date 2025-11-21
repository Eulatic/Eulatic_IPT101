using Microsoft.Extensions.DependencyInjection;
using PalayHarvest.WPF.ViewModels;
using System.Windows;

namespace PalayHarvest.WPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = App.Services.GetService<FarmerViewModel>();
        }
    }
}
