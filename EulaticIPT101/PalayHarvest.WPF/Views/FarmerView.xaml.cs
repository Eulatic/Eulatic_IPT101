using PalayHarvest.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PalayHarvest.WPF.Views
{
    /// <summary>
    /// Interaction logic for FarmerView.xaml
    /// </summary>
    public partial class FarmerView : Window
    {
        public FarmerView()
        {
        }

        public FarmerView(FarmerViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }


}
