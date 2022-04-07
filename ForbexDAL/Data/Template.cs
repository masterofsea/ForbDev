using JetBrains.Annotations;

namespace ForbexDAL.Data;

/// <summary>
/// Шаблон письма
/// </summary>
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public class Template
{
    /// <summary>
    /// Уникальный идентификатор шаблона
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// Имя шаблона
    /// </summary>
    public string Name { get; set; } = null!;
    
    /// <summary>
    /// Тело шаблона
    /// </summary>
    private string Body { get; set; } = null!;
}