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
    public string SenderName { get; set; } = null!;

    /// <summary>
    /// Имя получателя
    /// </summary>
    private Lessee? _receiver;
    public Lessee Receiver
    {
        get => _receiver ?? new Lessee();
        set => _receiver = value;
    }


    /// <summary>
    /// Статут корреспонденции
    /// </summary>
    public LetterStatus Status { get; set; }

    /// <summary>
    /// Адрес получения
    /// </summary>
    public int AddressId { get; set; }
    
    private Address? _address;
    public Address ReceivingAddress
    {
        get => _address ?? new Address();
        
        set => _address = value;
    }
    
    /// <summary>
    /// Дата получения
    /// </summary>
    public DateTime ReceivingDate { get; set; }
    
    /// <summary>
    /// Платное письмо
    /// </summary>
    public bool IsPaid { get; set; }
}

/// <summary>
/// Перечисление статусов корреспонденции
/// </summary>
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public enum LetterStatus
{
    SentToReceiver,
    SentToArchive,
    WaitingForReceiver
}