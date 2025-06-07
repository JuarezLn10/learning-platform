namespace ACME.LearningCenterPlatform.API.Publishing.Domain.Model.ValueObjects;

/// <summary>
/// Represents an identifier for an asset in the ACME Learning Center Platform.
/// </summary>
/// <param name="Identifier">
/// The unique identifier for the Asset.
/// </param>
public record AcmeAssetIdentifier(Guid Identifier)
{
    public AcmeAssetIdentifier() : this(Guid.NewGuid()) {}
}