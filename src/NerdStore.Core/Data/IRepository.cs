using NerdStore.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace NerdStore.Core.Data
{
    public interface IRepository<T> : IDisposable where T : IAggregateRoot //vai implementar o IDisposable onde o T é do tipo AggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
