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
            var view = App.ServiceProvider.GetRequiredService<IdeaFormView>();
            MainFrame.Navigate(view);
        }

        private void OnViewListClick(object sender, RoutedEventArgs e)
        {
            var view = App.ServiceProvider.GetRequiredService<IdeaListView>();
            MainFrame.Navigate(view);
        }
    }
}
