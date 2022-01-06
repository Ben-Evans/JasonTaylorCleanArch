using JasonTaylorCleanArch.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace JasonTaylorCleanArch.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<TodoList> TodoLists { get; }

        DbSet<TodoItem> TodoItems { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}