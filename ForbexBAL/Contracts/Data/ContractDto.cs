using ForbexDAL.Data;

namespace ForbexBAL.Contracts.Data;

public class ContractDto
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
    public DateTime ConclusionDate { get; set; }

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
    public DateTime LeaseStartDate { get; set; }

    /// <summary>
    /// Дата завершения договора
    /// </summary>
    public DateTime LeaseEndDate { get; set; }

    /// <summary>
    /// Срок договора  в целом числе месяцев
    /// </summary>
    public int LeaseTerm { get; set; }

    /// <summary>
    /// Тип регистрации
    /// </summary>
    public RegistrationType RegistrationType { get; set; }

    public int? PartnerId { get; set; }
    /// <summary>
    /// Информация о партнере
    /// </summary>
    public Partner? Partner { get; set; }

    public int LesseeId { get; set; }

    /// <summary>
    /// Информация об арендаторе
    /// </summary>
    public Lessee Lessee { get; set; } = null!;
    
    /// <summary>
    /// Цена арендатора
    /// </summary>
    public decimal Price1 { get; set; }
    
    /// <summary>
    /// Цена партнера
    /// </summary>
    public decimal Price2 { get; set; }
        
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
    public decimal Penalty { get; set; }

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
    public MailContract? MailContract { get; set; }
    
    /// <summary>
    /// Наличие услуги хранения документов
    /// </summary>
    public bool DocumentsStorage { get; set; }
    
    public static ContractDto Map(Contract contract)
    {
        return null;
    }
}

