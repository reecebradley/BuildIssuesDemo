using System;
using DonglesAreGreat.Core.Services;
using DonglesAreGreat.Core.Services.Interfaces;
using Ninject;
using Ninject.Extensions.Logging;
using Ninject.Extensions.Logging.NLog2.Infrastructure;

namespace DonglesAreGreat.Infrastructure
{
    public class ClassLoggingService : IClassLoggingService, ILogger
    {
        private readonly ILogger _logger;

        public ClassLoggingService(Type targetType)
        {
            IKernel kernel = new StandardKernel();
            var loggerFactory = kernel.Get<ILoggerFactory>();
            _logger = loggerFactory.GetLogger(targetType);
        }

        public void Debug(string message)
        {
            _logger.Debug(message);
        }

        public void Debug(string format, params object[] args)
        {
            _logger.Debug(format, args);
        }

        public void Debug(Exception exception, string format, params object[] args)
        {
            _logger.Debug(exception, format, args);
        }

        public void DebugException(string message, Exception exception)
        {
            _logger.Debug(exception, message);
        }

        public void Info(string message)
        {
            _logger.Info(message);
        }

        public void Info(string format, params object[] args)
        {
            _logger.Info(format, args);
        }

        public void Info(Exception exception, string format, params object[] args)
        {
            _logger.Info(exception, format, args);
        }

        public void InfoException(string message, Exception exception)
        {
            _logger.Info(exception, message);
        }

        public void Trace(string message)
        {
            _logger.Trace(message);
        }

        public void Trace(string format, params object[] args)
        {
            _logger.Trace(format, args);
        }

        public void Trace(Exception exception, string format, params object[] args)
        {
            _logger.Trace(exception, format, args);
        }

        public void TraceException(string message, Exception exception)
        {
            _logger.Trace(exception, message);
        }

        public void Warn(string message)
        {
            _logger.Warn(message);
        }

        public void Warn(string format, params object[] args)
        {
            _logger.Warn(format, args);
        }

        public void Warn(Exception exception, string format, params object[] args)
        {
            _logger.Warn(exception, format, args);
        }

        public void WarnException(string message, Exception exception)
        {
            _logger.Warn(exception, message);
        }

        public void Error(string message)
        {
            _logger.Error(message);
        }

        public void Error(string format, params object[] args)
        {
            _logger.Error(format, args);
        }

        public void Error(Exception exception, string format, params object[] args)
        {
            _logger.Error(exception, format, args);
        }

        public void ErrorException(string message, Exception exception)
        {
            _logger.Error(exception, message);
        }

        public void Fatal(string message)
        {
            _logger.Fatal(message);
        }

        public void Fatal(string format, params object[] args)
        {
            _logger.Fatal(format, args);
        }

        public void Fatal(Exception exception, string format, params object[] args)
        {
            _logger.Fatal(exception, format, args);
        }

        public void FatalException(string message, Exception exception)
        {
            _logger.Fatal(exception, message);
        }


        public Type Type { get { return _logger.Type; }}
        public string Name { get; private set; }
        public bool IsDebugEnabled { get { return _logger.IsDebugEnabled; } }
        public bool IsInfoEnabled { get { return _logger.IsInfoEnabled; } }
        public bool IsTraceEnabled { get { return _logger.IsTraceEnabled; } }
        public bool IsWarnEnabled { get { return _logger.IsWarnEnabled; } }
        public bool IsErrorEnabled { get { return _logger.IsErrorEnabled; } }
        public bool IsFatalEnabled { get { return _logger.IsFatalEnabled; } }
    }
}