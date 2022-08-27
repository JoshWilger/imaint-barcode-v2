using NLog;
using System;

namespace Logging
{
    public class LogWrapper : ILogWrapper
    {
        private static readonly ILogger _logger = LogManager.GetCurrentClassLogger();

        public LogWrapper(string config = null)
        {
            if (string.IsNullOrWhiteSpace(config))
            {
                // No config passed in, use the default configuration
                LogManager.LoadConfiguration(string.Concat(AppContext.BaseDirectory, "nlog.default.config"));
            }
            else
            {
                LogManager.LoadConfiguration(config);
            }
        }

        public void LogDebug(string message) => _logger.Debug(message);

        public void LogError(string message) => _logger.Error(message);

        public void LogInfo(string message) => _logger.Info(message);

        public void LogWarn(string message) => _logger.Warn(message);

        public void LogTrace(string message) => _logger.Trace(message);
    }
}
