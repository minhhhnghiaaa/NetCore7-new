using NetCore7.Application.TodoLists.Queries.ExportTodos;

namespace NetCore7.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
