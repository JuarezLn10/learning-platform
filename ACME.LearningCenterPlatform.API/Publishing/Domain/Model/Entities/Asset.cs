﻿using ACME.LearningCenterPlatform.API.Publishing.Domain.Model.ValueObjects;

namespace ACME.LearningCenterPlatform.API.Publishing.Domain.Model.Entities;

/// <summary>
/// Represents a generic asset in the publishing system
/// </summary>
/// <param name="Type">
/// The type of the asset, which determines its specific behavour and properties
/// </param>
public partial class Asset(EAssetType Type) : IPublishable
{
    public int Id { get; set; }

    public AcmeAssetIdentifier AssetIdentifier { get; private set; } = new();
    public EPublishingStatus Status { get; private set; } = EPublishingStatus.Draft;
    public EAssetType Type { get; private set; } = Type;
    public virtual bool Readable => false;
    public virtual bool Viewable => false;

    public void SendToApproval()
    {
        Status = EPublishingStatus.ReadyToEdit;
    }

    public void SendToEdit()
    {
        Status = EPublishingStatus.ReadyToApproval;
    }

    public void ApproveAndLock()
    {
        Status = EPublishingStatus.ApprovedAndLocked;
    }

    public void Reject()
    {
        Status = EPublishingStatus.Draft;
    }

    public void ReturnToEdit()
    {
        Status = EPublishingStatus.Draft;
    }

    public virtual object GetContent()
    {
        return string.Empty;
    }
}