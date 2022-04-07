namespace ForbexDAL.Repositories.Contracts;

/// <summary>
/// Репозиторий получения шаблонов для писем
/// </summary>
public interface ITemplatesRepository
{
    /// <summary>
    /// Метод получения шаблона письма по имени
    /// </summary>
    /// <param name="templateName">Имя шаблона</param>
    /// <returns>Шаблон письма</returns>
    Task<string> GetTemplateByName(string templateName);
}