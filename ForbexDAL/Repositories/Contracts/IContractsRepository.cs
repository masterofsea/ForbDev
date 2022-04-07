using ForbexDAL.Data;

namespace ForbexDAL.Repositories.Contracts;

/// <summary>
/// Репозиторий договоров аренды
/// </summary>
public interface IContractsRepository
{
    /// <summary>
    /// Получение всех договоров аренды
    /// </summary>
    /// <returns></returns>
    IEnumerable<Contract?> GetAllContracts();
        
    /// <summary>
    /// Получение договора аренды по Id
    /// </summary>
    /// <param name="id">Id договора аренды</param>
    /// <returns>договор аренды</returns>
    Task<Contract?> GetContractById(int id);

    /// <summary>
    /// Удаление договора аренды по Id
    /// </summary>
    /// <param name="contract">договор аренды</param>
    Task RemoveContractAsync(Contract contract);

    /// <summary>
    /// Добавление нового договора аренды
    /// </summary>
    /// <param name="contract">Договор аренды</param>
    Task AddContractAsync(Contract contract);
}