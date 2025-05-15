using System.Windows;
using IdeaManager.UI.Views;

namespace IdeaManager.UI
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new DashboardView());
        }
    }
}
