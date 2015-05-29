using System;

namespace DonglesAreGreat.Core.Services.Interfaces
{
    public interface IClassLoggingService
    {
        void Debug(string message);
        void Debug(string format, params object[] args);
        void Debug(Exception exception, string format, params object[] args);
        void Info(string message);
        void Info(string format, params object[] args);
        void Info(Exception exception, string format, params object[] args);
        void Trace(string message);
        void Trace(string format, params object[] args);
        void Trace(Exception exception, string format, params object[] args);
        void Warn(string message);
        void Warn(string format, params object[] args);
        void Warn(Exception exception, string format, params object[] args);
        void Error(string message);
        void Error(string format, params object[] args);
        void Error(Exception exception, string format, params object[] args);
        void Fatal(string message);
        void Fatal(string format, params object[] args);
        void Fatal(Exception exception, string format, params object[] args);
        Type Type { get; }
        bool IsDebugEnabled { get; }
        bool IsInfoEnabled { get; }
        bool IsTraceEnabled { get; }
        bool IsWarnEnabled { get; }
        bool IsErrorEnabled { get; }
        bool IsFatalEnabled { get; }
    }
}