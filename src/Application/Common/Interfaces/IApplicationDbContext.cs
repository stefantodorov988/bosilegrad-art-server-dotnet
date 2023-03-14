using bosilegrad_art_server_dotnet.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace bosilegrad_art_server_dotnet.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<TodoList> TodoLists { get; }

    DbSet<TodoItem> TodoItems { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
