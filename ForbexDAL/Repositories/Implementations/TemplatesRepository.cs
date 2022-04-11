using ForbexDAL.Data;
using ForbexDAL.DbContexts;
using ForbexDAL.Repositories.Contracts;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace ForbexDAL.Repositories.Implementations;

[UsedImplicitly]
public class TemplatesRepository : ITemplatesRepository
{
    private ForbexDbContext Context { get; }

    public TemplatesRepository(ForbexDbContext context)
    {
        Context = context;
    }
    
    public async Task<Template> GetTemplateByName(string templateName)
    {
        //TODO правильное сравнение строк организовать
        return await Context.Templates.FirstAsync(i => i.Name == templateName);
    }

    public async Task<IEnumerable<string>> GetAllTemplateNames()
    {
        return await Context.Templates.Select(i => i.Name).ToListAsync();
    }
}