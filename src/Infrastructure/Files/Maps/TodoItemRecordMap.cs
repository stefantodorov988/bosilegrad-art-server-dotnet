using System.Globalization;
using bosilegrad_art_server_dotnet.Application.TodoLists.Queries.ExportTodos;
using CsvHelper.Configuration;

namespace bosilegrad_art_server_dotnet.Infrastructure.Files.Maps;

public class TodoItemRecordMap : ClassMap<TodoItemRecord>
{
    public TodoItemRecordMap()
    {
        AutoMap(CultureInfo.InvariantCulture);

        Map(m => m.Done).Convert(c => c.Value.Done ? "Yes" : "No");
    }
}
