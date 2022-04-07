using JetBrains.Annotations;

namespace ForbexDAL.Data;

/// <summary>
/// Договор почтового обслуживания
/// </summary>
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public class MailContract
{
    /// <summary>
    /// Уникальный идентификатор договора почтового обслуживания
    /// </summary>
    public int Id { get; set; }
        
    /// <summary>
    /// Номер договора почтового обслуживания
    /// </summary>
    public string? MailContractNumber { get; set; }
        
    /// <summary>
    /// Дата заключения договора почтового обслуживания
    /// </summary>
    public DateTime? ConclusionDate { get; set; }

    public DateTime? LeaseBeginDate { get; set; }

    public DateTime? LeaseEndDate { get; set; }

    public int? LeaseTerm { get; set; }

    public bool? HasProxy { get; set; }
        
    public decimal? Price1 { get; set; }
        
    public decimal? Price2 { get; set; }
        
    /// <summary>
    /// Контрольная дата
    /// </summary>
    public DateTime ControlDate { get; set; }
        
    /// <summary>
    /// Ответственное лицо
    /// </summary>
    public string? Responsible { get; set; }

    public static MailContract EmptyMailContract { get; } = new();
}