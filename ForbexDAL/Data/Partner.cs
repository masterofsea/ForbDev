using JetBrains.Annotations;

namespace ForbexDAL.Data;

/// <summary>
/// Партнер
/// </summary>
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public class Partner
{
    /// <summary>
    /// Уникальный идентификатор партнера
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Имя партнера
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Email партнера
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// Телефон партнера
    /// </summary>
    public string? Phone { get; set; }
        
    /// <summary>
    /// Контактное имя партнера
    /// </summary>
    public string? ContactName { get; set; }

    public static Partner EmptyPartner { get; }= new();
    
    public override string ToString()
    {
        return Name;
    }
}