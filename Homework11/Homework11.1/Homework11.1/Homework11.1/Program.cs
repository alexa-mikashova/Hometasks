using Homework11._1;
using System.Collections.Generic;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        var logs = new List<LogEntry>
       {
          new LogEntry { Timestamp = DateTime.Now.AddMinutes(-1), Level = LogLevel.Info, Message = "Первый лог" },
          new LogEntry { Timestamp = DateTime.Now.AddMinutes(-2), Level = LogLevel.Warning, Message = "Второй лог" },
          new LogEntry { Timestamp = DateTime.Now.AddMinutes(-3), Level = LogLevel.Error, Message = "Третий лог" },
          new LogEntry { Timestamp = DateTime.Now.AddMinutes(-4), Level = LogLevel.Info, Message = "Четвертый лог" },
          new LogEntry { Timestamp = DateTime.Now.AddMinutes(-5), Level = LogLevel.Error, Message = "Пятый лог" },
          new LogEntry { Timestamp = DateTime.Now.AddMinutes(-6), Level = LogLevel.Error, Message = "Шестой лог" },
          new LogEntry { Timestamp = DateTime.Now.AddMinutes(-7), Level = LogLevel.Error, Message = "Первый лог-тест" }
       };

        var logProcessor = new LogProcessor();
        var infoLogs = logProcessor.FilterByLevel(logs, LogLevel.Warning);
        foreach (var log in infoLogs)
        {
            Console.WriteLine($"Фильтрация логов: {log.Message}");
        }

        Console.WriteLine();
        var errorCount = logProcessor.CountErrors(logs);
        Console.WriteLine($"логов с уровнем Error: {errorCount}");
        var recentLogs = logProcessor.FindRecentLogs(logs, DateTime.Now.AddMinutes(-3));
        foreach (var log in recentLogs)
        {
            Console.WriteLine($"Логи, созданные после определённой даты {DateTime.Now.AddMinutes(-3)}: {log.Message}");
        }

        Console.WriteLine();
        var groupedLogs = logProcessor.GroupByLevel(logs);
        foreach (var group in groupedLogs)
        {
            Console.WriteLine($"Лог {group.Key} - {group.Value} шт.");
        }

        Console.WriteLine();
        var topLogs = logProcessor.FindTopLogs(logs, "Первый");
        Console.WriteLine($"Количество отфильтрованных логов = {topLogs}");
        Console.WriteLine();
        logProcessor.ErrorOccurred += LogErrorOccurred;
        logProcessor.CheckErrors(logs);
    }

    private static void LogErrorOccurred(LogEntry log)
    {
        Console.WriteLine($"Ошибка: {log.Message}");
    }
}