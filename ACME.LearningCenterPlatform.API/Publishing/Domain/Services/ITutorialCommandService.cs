using ACME.LearningCenterPlatform.API.Publishing.Domain.Model.Aggregates;
using ACME.LearningCenterPlatform.API.Publishing.Domain.Model.Commands;
using ACME.LearningCenterPlatform.API.Publishing.Domain.Model.Entities;

namespace ACME.LearningCenterPlatform.API.Publishing.Domain.Services;

public interface ITutorialCommandService
{
    Task<Tutorial?> Handle(CreateTutorialCommand command);
    Task<Tutorial?> Handle(AddVideoAssetToTutorialCommand command);
}