using ACME.LearningCenterPlatform.API.Publishing.Domain.Model.Commands;
using ACME.LearningCenterPlatform.API.Publishing.Domain.Model.Entities;

namespace ACME.LearningCenterPlatform.API.Publishing.Domain.Services;

public interface ICategoryCommandService
{ 
    public Task<Category?> Handle(CreateCategoryCommand command);   
}