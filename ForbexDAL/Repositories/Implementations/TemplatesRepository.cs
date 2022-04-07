using ForbexDAL.Repositories.Contracts;

namespace ForbexDAL.Repositories.Implementations;

public class TemplatesRepository : ITemplatesRepository
{
    public Task<string> GetTemplateByName(string templateName)
    {
        throw new NotImplementedException();
    }
}