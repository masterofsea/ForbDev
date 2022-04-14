using ForbexDAL.Data;
using ForbexDAL.Repositories.Contracts;

namespace ForbexDAL.Repositories.Implementations;

public class MockCorrespondenceRepository : ICorrespondenceRepository
{
    private List<Correspondence> Correspondences { get; }
    public MockCorrespondenceRepository()
    {
        Correspondences = new List<Correspondence>();
        var rnd = new Random();
        for (var i = 0; i < 10000; ++i)
        {
            Correspondences.Add(new Correspondence()
            {
                Receiver = new Lessee()
                {
                    Name = rnd.Next().ToString()
                },
                ReceivingAddress = new Address()
                {
                    FullAddress = rnd.Next().ToString()
                },
                IsPaid = i % 5 == 0,
                ReceivingDate = DateTime.Now,
                SenderName = "TestUser"
            });
        }
    }
    public IEnumerable<Correspondence> GetAllCorrespondence()
    {
        return Correspondences;
    }

    public Task AddCorrespondence(Correspondence correspondence)
    {
        return Task.Run(() => Correspondences.Add(correspondence));
    }

    public Task UpdateCorrespondence(Correspondence correspondence)
    {
        return Task.Run(() => Correspondences.Add(correspondence));
    }
}