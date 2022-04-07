using JetBrains.Annotations;

namespace ForbexDAL.Data;

/// <summary>
/// Арендатор
/// </summary>
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public class Lessee
{
    /// <summary>
    /// Уникальный идентификатор арендатора
    /// </summary>
    public int Id { get; set; }
        
    /// <summary>
    /// Наименование арендатора
    /// </summary>
    public string? Name { get; set; }
        
    /// <summary>
    /// Краткое наименование арендатора
    /// </summary>
    public string? ShortName { get; set; }

    /// <summary>
    /// Email арендатора
    /// </summary>
    public string? Email { get; set; }
        
    /// <summary>
    /// Телефон арендатора
    /// </summary>
    public string? Phone { get; set; }

    /// <summary>
    /// Дополнительные контакты арендатора
    /// </summary>
    public string? AdditionalContacts { get; set; }

    /// <summary>
    /// Контактное имя арендатора
    /// </summary>
    public string? ContactName { get; set; }
    
    /// <summary>
    /// Позиция контактного лица арендатора
    /// </summary>
    public string? ContactNamePosition { get; set; }
    
    /// <summary>
    /// ИНН
    /// </summary>
    public string? Inn { get; set; }
    
    /// <summary>
    /// Банк
    /// </summary>
    public string? Bank { get; set; }
    
    /// <summary>
    /// БИК
    /// </summary>
    public string? Bic { get; set; }
    
    /// <summary>
    /// ОГРН
    /// </summary>
    public string? Ogrn { get; set; }
    
    /// <summary>
    /// КПП
    /// </summary>
    public string? Kpp { get; set; }
    
    /// <summary>
    /// Расчетный счет
    /// </summary>
    public string? CheckingAccount { get; set; }


    public static Lessee EmptyLessee { get; } = new();
}