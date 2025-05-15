using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using System.Windows.Controls;

namespace IdeaManager.UI.Views
{
    public partial class DashboardView : Page
    {
        public DashboardView()
        {
            InitializeComponent();
        }

        private void OnSubmitIdeaClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new IdeaFormView());
        }

        private void OnViewListClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new IdeaListView());
        }

       
    }
}
