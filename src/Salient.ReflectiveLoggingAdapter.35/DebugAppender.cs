using System;
using System.Text;

namespace Salient.ReflectiveLoggingAdapter
{
    ///<summary>
    ///</summary>
    public class DebugAppender : AbstractAppender
    {
        ///<summary>
        ///</summary>
        ///<param name="logName"></param>
        ///<param name="logLevel"></param>
        ///<param name="showLevel"></param>
        ///<param name="showDateTime"></param>
        ///<param name="showLogName"></param>
        ///<param name="dateTimeFormat"></param>
        public DebugAppender(string logName, LogLevel logLevel, bool showLevel, bool showDateTime, bool showLogName,
                             string dateTimeFormat)
            : base(logName, logLevel, showLevel, showDateTime, showLogName, dateTimeFormat)
        {
        }

        protected override void WriteInternal(LogLevel level, object message, Exception exception)
        {
            var sb = new StringBuilder();
            FormatOutput(sb, level, message, exception);
            System.Diagnostics.Debug.WriteLine(sb.ToString());

        }
    }


    ///<summary>
    ///</summary>
    public class SimpleDebugAppender : AbstractAppender
    {
        ///<summary>
        ///</summary>
        ///<param name="logName"></param>
        ///<param name="logLevel"></param>
        ///<param name="showLevel"></param>
        ///<param name="showDateTime"></param>
        ///<param name="showLogName"></param>
        ///<param name="dateTimeFormat"></param>
        public SimpleDebugAppender(string logName, LogLevel logLevel, bool showLevel, bool showDateTime, bool showLogName, string dateTimeFormat)
            : base(logName, logLevel, showLevel, showDateTime, showLogName, dateTimeFormat)
        {
        }

        protected override void WriteInternal(LogLevel level, object message, Exception exception)
        {
            var sb = new StringBuilder();
            FormatOutput(sb, level, message, exception);
            System.Diagnostics.Debug.WriteLine(sb.ToString());
        }
    }

#if !SILVERLIGHT


    ///<summary>
    ///</summary>
    public class SimpleTraceAppender : AbstractAppender
    {
        ///<summary>
        ///</summary>
        ///<param name="logName"></param>
        ///<param name="logLevel"></param>
        ///<param name="showLevel"></param>
        ///<param name="showDateTime"></param>
        ///<param name="showLogName"></param>
        ///<param name="dateTimeFormat"></param>
        public SimpleTraceAppender(string logName, LogLevel logLevel, bool showLevel, bool showDateTime, bool showLogName, string dateTimeFormat)
            : base(logName, logLevel, showLevel, showDateTime, showLogName, dateTimeFormat)
        {
        }

        protected override void WriteInternal(LogLevel level, object message, Exception exception)
        {
            var sb = new StringBuilder();
            FormatOutput(sb, level, message, exception);
            System.Diagnostics.Trace.WriteLine(sb.ToString());
        }
    }
#endif
}