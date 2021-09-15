using System;

namespace ExceptionHandler.Interfaces
{
    /// <summary>
    /// An interface used to send exception information
    /// </summary>
    public interface IExceptionHandler
    {
        #region Public Properties

        /// <summary>
        /// A read only exposed property representing the Exception definition
        /// </summary>
        public Exception Exception { get; }

        #endregion Public Properties

        #region Public Methods

        /// <summary>
        /// A method used to send the information
        /// </summary>
        public void Handle(Exception ex);

        #endregion Public Methods
    }
}
