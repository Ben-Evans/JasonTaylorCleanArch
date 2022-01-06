using CsvHelper;
using JasonTaylorCleanArch.Application.Common.Interfaces;
using JasonTaylorCleanArch.Application.TodoLists.Queries.ExportTodos;
using JasonTaylorCleanArch.Infrastructure.Files.Maps;
using System.Globalization;

namespace JasonTaylorCleanArch.Infrastructure.Files
{
    public class CsvFileBuilder : ICsvFileBuilder
    {
        public byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records)
        {
            using var memoryStream = new MemoryStream();
            using (var streamWriter = new StreamWriter(memoryStream))
            {
                using var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);

                csvWriter.Configuration.RegisterClassMap<TodoItemRecordMap>();
                csvWriter.WriteRecords(records);
            }

            return memoryStream.ToArray();
        }
    }
}