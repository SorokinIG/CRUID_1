using System;
using CRUID_1.DAL.Entities;

namespace CRUID_1.DAL.Interfaces
{
    public interface IUnitOfWork: IDisposable
    {
        IRepository<Provider> Providers { get; }
        IRepository<OrderItem> OrderItems { get; }
        IRepository<Order> Orders { get; }
        void Save();
    }
}
