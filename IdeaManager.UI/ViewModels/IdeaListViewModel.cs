using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using IdeaManager.Core.Entities;


namespace IdeaManager.UI.ViewModels
{
    public class IdeaListViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Idea> Ideas { get; set; }

        public IdeaListViewModel()
        {
            // Liste d'exemple je vais le remplacer plus tard par un service ou une base de données que la mme a offer
            Ideas = new ObservableCollection<Idea>
            {
                new Idea { Title = "Améliorer l'interface", Description = "Ajouter des animations modernes" },
                new Idea { Title = "Créer une FAQ", Description = "Répondre aux questions courantes" },
                new Idea { Title = "Ajouter un mode sombre", Description = "Meilleure lisibilité la nuit" }
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
