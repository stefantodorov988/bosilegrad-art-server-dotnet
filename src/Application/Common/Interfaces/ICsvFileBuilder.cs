using bosilegrad_art_server_dotnet.Application.TodoLists.Queries.ExportTodos;

namespace bosilegrad_art_server_dotnet.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
