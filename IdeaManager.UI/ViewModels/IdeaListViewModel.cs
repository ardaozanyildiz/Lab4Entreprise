using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CommunityToolkit.Mvvm.ComponentModel;
using IdeaManager.Core.Entities;
using IdeaManager.Core.Interfaces;


namespace IdeaManager.UI.ViewModels
{
    public class IdeaListViewModel : ObservableObject
    {
        private readonly IIdeaService _ideaService;
        public ObservableCollection<Idea> Ideas { get; set; }

        public IdeaListViewModel(IIdeaService ideaService)
        {
            _ideaService = ideaService;

        }
        public async Task GetTaskAsync()
        {
            if (_ideaService == null)
            {
                return;
            }
            else
            {
                var ideas = await _ideaService.GetAllAsync();
                foreach (var idea in ideas)
                {
                    ideas.Add(idea);
                }
            }


        }
    }
}
