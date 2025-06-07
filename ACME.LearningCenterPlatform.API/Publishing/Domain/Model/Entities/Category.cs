using ACME.LearningCenterPlatform.API.Publishing.Domain.Model.Commands;

namespace ACME.LearningCenterPlatform.API.Publishing.Domain.Model.Entities;

/// <summary>
/// Represents a category for organizing content in the learning platform
/// </summary>
/// <param name="name">
/// The name of the category
/// </param>
public class Category(string name)
{
    public int Id { get; set; }
    public string Name { get; set; }

    /// <summary>
    /// Initializes a new instance of Category
    /// </summary>
    public Category() : this(string.Empty) {}

    public Category(CreateCategoryCommand command) : this(command.Name)
    { }
}