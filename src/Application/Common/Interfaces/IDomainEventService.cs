using JasonTaylorCleanArch.Domain.Common;

namespace JasonTaylorCleanArch.Application.Common.Interfaces
{
    public interface IDomainEventService
    {
        Task Publish(DomainEvent domainEvent);
    }
}