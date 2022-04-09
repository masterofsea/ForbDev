using ForbexDAL.Data;
using ForbexDAL.Repositories.Contracts;
using JetBrains.Annotations;

namespace ForbexDAL.Repositories.Implementations;

[UsedImplicitly]
public class FileSystemTemplateRepository : ITemplatesRepository
{
    public Task<Template> GetTemplateByName(string templateName)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<string>> GetAllTemplateNames()
    {
        throw new NotImplementedException();
    }
}