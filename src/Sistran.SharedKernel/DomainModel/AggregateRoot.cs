using System;

namespace Sistran.SharedKernel.DomainModel
{
    [Serializable]
    public abstract class AggregateRoot
    {
        public Guid Id { get; protected set; }
    }
}
