using JasonTaylorCleanArch.Application.TodoLists.Queries.ExportTodos;

namespace JasonTaylorCleanArch.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
    }
}