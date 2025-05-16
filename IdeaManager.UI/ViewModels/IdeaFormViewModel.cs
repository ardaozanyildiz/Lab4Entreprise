using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using IdeaManager.Core.Entities;
using IdeaManager.Services.Services;

using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.Windows;
using IdeaManager.Core.Interfaces;

public partial class IdeaFormViewModel : ObservableValidator
{
    private readonly IIdeaService _ideaService;

    public IdeaFormViewModel(IIdeaService ideaService)
    {
        _ideaService = ideaService;
    }

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Required(ErrorMessage = "Le titre est requis.")]
    private string title;

    [ObservableProperty]
    private string description;

    [RelayCommand]
    private async Task SubmitAsync()
    {
       
      
        var idea = new Idea
        {
            Title = Title,
            Description = Description
        };

        try
        {
            await _ideaService.SubmitIdeaAsync(idea);
            MessageBox.Show("Idée enregistrée avec succès !");
            Title = string.Empty;
            Description = string.Empty;
            MessageBox.Show("dfgdg");
        }
        catch (System.Exception ex)
        {
            MessageBox.Show($"Erreur lors de l'envoi : {ex.Message}");
        }
    }
}
