using ExceptionHandler.Interfaces;
using System;
using System.Diagnostics;

namespace ExceptionHandler.Services
{
    /// <summary>
    /// A class used to log exceptions by writing a log to the computer's event logger
    /// </summary>
    public class EventLogExceptionService : IExceptionHandler
    {
        #region Private Fields

        /// <summary>
        /// The exception information
        /// </summary>
        private Exception _Exception;

        #endregion Private Fields

        #region Public Properties

        /// <summary>
        /// Expose a read only property representing the class' client defined exception information
        /// </summary>
        public Exception Exception { get => _Exception; }

        #endregion Public Properties

        #region Public Methods

        /// <summary>
        /// Handle the exception by writing a log entry to the event logger
        /// </summary>
        /// <param name="ex"> The exception information to record </param>
        public void Handle(Exception ex)
        {
            _Exception = ex;
            EventLog.WriteEntry(ex.Source, ex.Message, EventLogEntryType.Error);
        }

        #endregion Public Methods
    }
}
