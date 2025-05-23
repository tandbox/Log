namespace CodeJunkie.Log;

using System;

/// <summary>
/// Optional interface providing log-message formatting to <see cref="Log"/>.
/// </summary>
public interface ILogFormatter {
  /// <summary>
  /// Formats a log message.
  /// </summary>
  /// <param name="logName">The name of the logger.</param>
  /// <param name="level">The log level.</param>
  /// <param name="message">The log message.</param>
  string FormatMessage(string logName, Level level, string message);

  /// <summary>
  /// Formats a log message.
  /// </summary>
  /// <param name="logName">The name of the logger.</param>
  /// <param name="level">The log level.</param>
  /// <param name="message">The log message.</param>
  /// <param name="exception">The exception to log.</param>
  string FormatMessage(string logName, Level level, string message, Exception exception);
}
