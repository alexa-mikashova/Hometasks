using System;
using System.Collections.Generic;
using System.Linq;
namespace Homework11._1
{
    public class LogProcessor
    {
        public delegate void ErrorOccurredHandler(LogEntry log);
        public event ErrorOccurredHandler ErrorOccurred;
        public List<LogEntry> FilterByLevel(List<LogEntry> logs, LogLevel level)
        {
            return logs.Where(log => log.Level == level).ToList();
        }

        public int CountErrors(List<LogEntry> logs)
        {
            return logs.Count(log => log.Level == LogLevel.Error);
        }

        public List<LogEntry> FindRecentLogs(List<LogEntry> logs, DateTime since)
        {
            return logs.Where(log => log.Timestamp > since).ToList();
        }

        public Dictionary<LogLevel, int> GroupByLevel(List<LogEntry> logs)
        {
            return logs.GroupBy(log => log.Level).ToDictionary(group => group.Key, group => group.Count());
        }

        public int FindTopLogs(List<LogEntry> logs, string keyword)
        {
            var logslogsList = logs.Where(log => log.Message.Contains(keyword)).OrderByDescending(log => log.Timestamp).ToList();
            return logslogsList.Count;
        }

        public void CheckErrors(List<LogEntry> logs)
        {
            var errors = logs.Where(log => log.Level == LogLevel.Error);
            foreach (var error in errors)
            {
                ErrorOccurred?.Invoke(error);
            }
        }
    }
}
