using JetBrains.Annotations;

namespace ForbexDAL.Data;

/// <summary>
/// Корреспонденция
/// </summary>
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public class Correspondence
{
    /// <summary>
    /// Уникальный идентификатор корреспонденции
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// Имя отправителя
    /// </summary>
    public string? SenderName { get; set; }
    
    /// <summary>
    /// Имя получателя
    /// </summary>
    public string? ReceiverName { get; set; }
    
    /// <summary>
    /// Статут корреспонденции
    /// </summary>
    public LetterStatus Status { get; set; }
    
    /// <summary>
    /// Адрес получения
    /// </summary>
    public string? ReceivingAddress { get; set; }
}

/// <summary>
/// Перечисление статусов корреспонденции
/// </summary>
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public enum LetterStatus
{
    Sent,
    Received
}