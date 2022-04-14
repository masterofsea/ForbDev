using ForbexDAL.Data;

namespace ForbexDAL.Repositories.Contracts;

/// <summary>
/// Репозиторий 
/// </summary>
public interface ICorrespondenceRepository
{
    /// <summary>
    /// Получение всей корреспонденции
    /// </summary>
    /// <returns></returns>
    public IEnumerable<Correspondence> GetAllCorrespondence();

    /// <summary>
    /// Добавление новой корреспонденции
    /// </summary>
    /// <param name="correspondence">Новая корреспонденция</param>
    public Task AddCorrespondence(Correspondence correspondence);

    /// <summary>
    /// Обновление корреспонденции
    /// </summary>
    /// <param name="correspondence">Обновленная корреспонденция</param>
    public Task UpdateCorrespondence(Correspondence correspondence);
}