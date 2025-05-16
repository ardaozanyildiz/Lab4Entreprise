using System.Windows;
using IdeaManager.Core.Interfaces;
using IdeaManager.UI.Views;

namespace IdeaManager.UI
{
    public partial class MainWindow : Window
    {
        private readonly IUnitOfWork _unitOfWork;
        public MainWindow(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            InitializeComponent();
            MainFrame.Navigate(new DashboardView(_unitOfWork));
        }
    }
}
