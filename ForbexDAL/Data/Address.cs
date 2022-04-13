using JetBrains.Annotations;

namespace ForbexDAL.Data;

/// <summary>
/// Юридический адрес арендуемого помещения
/// </summary>
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public class Address
{
    /// <summary>
    /// Уникальный идентификатор юридического адреса
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// Полный юридический адрес
    /// </summary>
    public string FullAddress { get; set; }
    
    /// <summary>
    /// Номер закрепленного за адресом ИФНС
    /// </summary>
    public string Ifts { get; set; }


    public override string ToString()
    {
        return FullAddress;
    }
}