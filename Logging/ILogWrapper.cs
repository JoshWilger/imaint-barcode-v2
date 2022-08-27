namespace Logging
{
    public interface ILogWrapper
    {
        void LogInfo(string message);
        void LogWarn(string message);
        void LogError(string message);
        void LogDebug(string message);
        void LogTrace(string message);
    }
}
