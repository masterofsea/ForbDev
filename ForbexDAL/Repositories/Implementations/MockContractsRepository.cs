using ForbexDAL.Data;
using ForbexDAL.Repositories.Contracts;

namespace ForbexDAL.Repositories.Implementations;

public class MockContractsRepository : IContractsRepository
{
    private List<Contract> Contracts { get; }
    public MockContractsRepository()
    {
        Contracts = new List<Contract>();
        var rnd = new Random();
        for (var i = 0; i < 10000; ++i)
        {
            Contracts.Add(new Contract
            {
                Address = rnd.Next().ToString(),
                Id = i,
                Ifts = rnd.Next().ToString(),
                ConclusionDate = DateTime.Now - TimeSpan.FromDays(i),
                ContractNumber = rnd.Next().ToString(),
                LeaseStartDate = DateTime.UnixEpoch + TimeSpan.FromDays(i),
                LeaseEndDate = DateTime.UnixEpoch + TimeSpan.FromDays(i + 147),
                LeaseTerm = 147,
                Paid = i % 3 != 0,
                Lessee = new Lessee
                {
                    Name = $"{rnd.Next()} ИМЯ"
                },
                MailContract = i % 5 == 0 ? new MailContract
                {
                    MailContractNumber = rnd.Next().ToString()
                } : new MailContract()
            });
        }
    }
    
    public IEnumerable<Contract?> GetAllContracts()
    {
        return Contracts;
    }

    public Task<Contract?> GetContractById(int id)
    {
        var tcs = new TaskCompletionSource<Contract?>();
        var result = Contracts.FirstOrDefault(i => i.Id == id);
        tcs.SetResult(result);
        return tcs.Task;
    }

    public Task RemoveContractAsync(Contract contract)
    {
        return Task.Run(() => Contracts.Remove(contract));
    }

    public Task AddContractAsync(Contract contract)
    {
        return Task.Run(() => Contracts.Add(contract));
    }
}