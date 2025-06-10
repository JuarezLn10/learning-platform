using System.Runtime.CompilerServices;
using ACME.LearningCenterPlatform.API.Publishing.Domain.Model.Commands;
using ACME.LearningCenterPlatform.API.Publishing.Domain.Model.Entities;

namespace ACME.LearningCenterPlatform.API.Publishing.Domain.Model.Aggregates;

public partial class Tutorial
{
    public int Id { get; }
    public string Title { get; private set; }
    public string Summary { get; private set; }
    public Category Category { get; internal set; }
    public int CategoryId { get; private set; }

    private Tutorial(string title, string summary, int categoryId)
    {
        Title = title;
        Summary = summary;
        CategoryId = categoryId;
    }
    
    public Tutorial(CreateTutorialCommand command) : this(command.Title, command.Summary, command.CategoryId)
    {}
}