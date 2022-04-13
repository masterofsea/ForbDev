using ForbexDAL.Data;
using ForbexDAL.DbContexts;
using ForbexDAL.Repositories.Contracts;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace ForbexDAL.Repositories.Implementations;

[UsedImplicitly(ImplicitUseKindFlags.InstantiatedNoFixedConstructorSignature)]
public class EfContractsRepository : IContractsRepository
{
    private ForbexDbContext Context { get; }

    public EfContractsRepository(ForbexDbContext context)
    {
        Context = context;
    }

    public IEnumerable<Contract?> GetAllContracts()
    {
        return Context.Contracts;
    }

    public async Task<Contract> GetContractById(int id)
    {
        return await Context.Contracts.FirstAsync(i => i.Id == id);
    }

    public async Task RemoveContractAsync(Contract contract)
    {
        Context.Contracts.Remove(contract);
        await Context.SaveChangesAsync();
    }

    public async Task AddContractAsync(Contract contract)
    {
        Context.Contracts.Add(contract);
        await Context.SaveChangesAsync();
    }
}