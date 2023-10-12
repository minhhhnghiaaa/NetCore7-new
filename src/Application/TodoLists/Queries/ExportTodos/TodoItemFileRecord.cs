using NetCore7.Application.Common.Mappings;
using NetCore7.Domain.Entities;

namespace NetCore7.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; init; }

    public bool Done { get; init; }
}
