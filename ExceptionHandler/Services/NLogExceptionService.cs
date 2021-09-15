using ExceptionHandler.Interfaces;
using NLog;
using System;

namespace ExceptionHandler.Services
{
    /// <summary>
    /// Handle exceptions and log them in the database
    /// </summary>
    /// <seealso cref="NLog" />
    public class NLogExceptionService : IExceptionHandler
    {
        #region Private Fields

        /// <summary>
        /// The client defined exception information
        /// </summary>
        private Exception _Exception;

        #endregion Private Fields

        #region Public Properties

        /// <summary>
        /// Expose a read only version of the client defined exception information
        /// </summary>
        public Exception Exception => _Exception;

        #endregion Public Properties

        #region Public Methods

        /// <summary>
        /// Handle the exception by logging it in the database
        /// </summary>
        /// <param name="ex"> The exception information </param>
        public void Handle(Exception ex)
        {
            //Store the last logged exception details
            _Exception = ex;

            //Generate a new logger instance
            Logger logger = LogManager.GetCurrentClassLogger();

            //Log the error
            logger.Error(ex, ex.Message);
        }

        #endregion Public Methods
    }
}
