using bosilegrad_art_server_dotnet.Application.Common.Mappings;
using bosilegrad_art_server_dotnet.Domain.Entities;

namespace bosilegrad_art_server_dotnet.Application.TodoItems.Queries.GetTodoItemsWithPagination;

public class TodoItemBriefDto : IMapFrom<TodoItem>
{
    public int Id { get; set; }

    public int ListId { get; set; }

    public string? Title { get; set; }

    public bool Done { get; set; }
}
