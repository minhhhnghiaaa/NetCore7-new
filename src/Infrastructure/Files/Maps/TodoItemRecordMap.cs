using System.Globalization;
using NetCore7.Application.TodoLists.Queries.ExportTodos;
using CsvHelper.Configuration;

namespace NetCore7.Infrastructure.Files.Maps;

public class TodoItemRecordMap : ClassMap<TodoItemRecord>
{
    public TodoItemRecordMap()
    {
        AutoMap(CultureInfo.InvariantCulture);

        Map(m => m.Done).Convert(c => c.Value.Done ? "Yes" : "No");
    }
}
