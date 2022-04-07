using JetBrains.Annotations;

namespace ForbexDAL.Data;


/// <summary>
/// Договор аренды
/// </summary>
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public class Contract
{
    /// <summary>
    /// Уникальный идентификатор договора аренды
    /// </summary>
    public int Id { get; set; }
        
    /// <summary>
    /// Адрес арендуемого помещения
    /// </summary>
    public string? Address { get; set; }
        
    public ContractState ContractState { get; set; }
        
    /// <summary>
    /// Дата заключения договора аренды
    /// </summary>
    public DateTime? ConclusionDate { get; set; }

    /// <summary>
    /// ИФНС
    /// </summary>
    public string? Ifts { get; set; }
        
    /// <summary>
    /// Номер договора
    /// </summary>
    public string? ContractNumber { get; set; }

    /// <summary>
    /// Дата начала договора
    /// </summary>
    public DateTime? LeaseStartDate { get; set; }

    /// <summary>
    /// Дата завершения договора
    /// </summary>
    public DateTime? LeaseEndDate { get; set; }

    /// <summary>
    /// Срок договора  в целом числе месяцев
    /// </summary>
    public int? LeaseTerm { get; set; }

    /// <summary>
    /// Тип регистрации
    /// </summary>
    public RegistrationType RegistrationType { get; set; }

    public int? PartnerId { get; set; }
    
    /// <summary>
    /// Почтовый договор
    /// </summary>
    private Partner? _partner;
    public Partner Partner
    {
        get => _partner ?? Partner.EmptyPartner;
        set => _partner = value;
    }
    
    public int LesseeId { get; set; }

    /// <summary>
    /// Информация об арендаторе
    /// </summary>
    private Lessee? _lessee;
    public Lessee Lessee { get => _lessee ?? Lessee.EmptyLessee; set => _lessee = value; }
    
    /// <summary>
    /// Цена арендатора
    /// </summary>
    public decimal? Price1 { get; set; }
    
    /// <summary>
    /// Цена партнера
    /// </summary>
    public decimal? Price2 { get; set; }
        
    /// <summary>
    /// Форма оплаты
    /// </summary>
    public PaymentForm PaymentForm { get; set; }
    
    /// <summary>
    /// Флаг оплаты
    /// </summary>
    public bool Paid { get; set; }
        
    /// <summary>
    /// Наличие чека
    /// </summary>
    public bool Receipt { get; set; }

    /// <summary>
    /// Штраф
    /// </summary>
    public decimal? Penalty { get; set; }

    /// <summary>
    /// Наличие возвратного экземпляра
    /// </summary>
    public bool IsReturnableCopy { get; set; }

    /// <summary>
    /// Наличие ежемесячных актов
    /// </summary>
    public bool MonthlyActs { get; set; }
        
    /// <summary>
    /// Внешний ключ на почтовый договор
    /// </summary>
    public int? MailContractId { get; set; }

    
    
    /// <summary>
    /// Почтовый договор
    /// </summary>
    private MailContract? _mailContract;
    public MailContract MailContract
    {
        get => _mailContract ?? MailContract.EmptyMailContract;
        set => _mailContract = value;
    }
    
    /// <summary>
    /// Наличие услуги хранения документов
    /// </summary>
    public bool DocumentsStorage { get; set; }
}

/// <summary>
/// Перечисление типов регистрации
/// </summary>
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public enum RegistrationType
{
    New,
    Change,
    Prolongation
}

/// <summary>
/// Перечисление состояний договора
/// </summary>
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public enum ContractState
{
    Active,
    Disabled    
}
    
/// <summary>
/// Перечисление форм оплаты
/// </summary>
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public enum PaymentForm 
{
    Mixed,
    NonCash,
    Cash
}