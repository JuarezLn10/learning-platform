using System.ComponentModel.DataAnnotations.Schema;

namespace ACME.LearningCenterPlatform.API.Publishing.Domain.Model.Entities;

public partial class Asset
{
    [Column("CreatedAt")] public DateTimeOffset? CreatedDate { get; set; }
    [Column("UpdatedAt")] public DateTimeOffset? UpdatedDate { get; set; }
}