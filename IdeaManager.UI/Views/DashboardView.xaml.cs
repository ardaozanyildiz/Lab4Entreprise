using IdeaManager.Core.Interfaces;
using IdeaManager.UI.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using System.Windows.Controls;

namespace IdeaManager.UI.Views
{
    public partial class DashboardView : Page
    {
        private readonly IUnitOfWork _unitOfWork;
        public DashboardView(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
        }

        private void OnSubmitIdeaClick(object sender, RoutedEventArgs e)
        {
            var ideaService = new IdeaService(_unitOfWork);
            var viewModel = new IdeaFormViewModel(ideaService);
            MainFrame.Navigate(new IdeaFormView(viewModel));
        }

        private void OnViewListClick(object sender, RoutedEventArgs e)
        {
            var ideaService = new IdeaService(_unitOfWork);
            var viewModel = new IdeaListViewModel(ideaService);
            MainFrame.Navigate(new IdeaListView(viewModel));
        }

       
    }
}
