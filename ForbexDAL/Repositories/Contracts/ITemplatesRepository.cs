using ForbexDAL.Data;
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
    Task<Template> GetTemplateByName(string templateName);

    /// <summary>
    /// Получения названия всех шаблонов писем
    /// </summary>
    /// <returns>Список имен шаблонов писем</returns>
    Task<IEnumerable<string>> GetAllTemplateNames();

    /// <summary>
    /// Добавление нового шаблона письма в хранилище
    /// </summary>
    /// <param name="template">Новый шаблон письма</param>
    Task AddTemplate(Template template);

    /// <summary>
    /// Обновление шаблона письма в хранилище
    /// </summary>
    /// <param name="template">Отредактированный шаблон письма</param>
    Task UpdateTemplate(Template template);
}