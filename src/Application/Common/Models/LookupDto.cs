using bosilegrad_art_server_dotnet.Application.Common.Mappings;
using bosilegrad_art_server_dotnet.Domain.Entities;

namespace bosilegrad_art_server_dotnet.Application.Common.Models;

// Note: This is currently just used to demonstrate applying multiple IMapFrom attributes.
public class LookupDto : IMapFrom<TodoList>, IMapFrom<TodoItem>
{
    public int Id { get; set; }

    public string? Title { get; set; }
}
