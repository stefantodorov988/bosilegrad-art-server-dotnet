using System.Globalization;
using bosilegrad_art_server_dotnet.Application.Common.Interfaces;
using bosilegrad_art_server_dotnet.Application.TodoLists.Queries.ExportTodos;
using bosilegrad_art_server_dotnet.Infrastructure.Files.Maps;
using CsvHelper;

namespace bosilegrad_art_server_dotnet.Infrastructure.Files;

public class CsvFileBuilder : ICsvFileBuilder
{
    public byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records)
    {
        using var memoryStream = new MemoryStream();
        using (var streamWriter = new StreamWriter(memoryStream))
        {
            using var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);

            csvWriter.Context.RegisterClassMap<TodoItemRecordMap>();
            csvWriter.WriteRecords(records);
        }

        return memoryStream.ToArray();
    }
}
