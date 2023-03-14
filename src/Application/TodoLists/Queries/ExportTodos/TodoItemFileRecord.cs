using bosilegrad_art_server_dotnet.Application.Common.Mappings;
using bosilegrad_art_server_dotnet.Domain.Entities;

namespace bosilegrad_art_server_dotnet.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
