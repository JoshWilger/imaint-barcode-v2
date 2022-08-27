namespace Logging
{
    public interface ILogWrapper
    {
        void LogDebug(string message);

        void LogError(string message);

        void LogInfo(string message);

        void LogTrace(string message);

        void LogWarn(string message);
    }
}
