using ExceptionHandler.Interfaces;
using System;

namespace ExceptionHandler.Services
{
    /// <summary>
    /// Send the exception information as an email implementing the ICommunicationMethod interface
    /// </summary>
    public class EmailExceptionService : IExceptionHandler
    {
        #region Private Fields

        /// <summary>
        /// A string representation of the default email recipient
        /// </summary>
        private readonly string _DefaultRecipient = "";

        /// <summary>
        /// A string representation of the default email subject
        /// </summary>
        private readonly string _DefaultSubject = "An Exception Occured at Run-time";

        /// <summary>
        /// The exception information
        /// </summary>
        private Exception _Exception;

        #endregion Private Fields

        #region Public Properties

        /// <summary>
        /// Expose a read only property representing the class' client defined exception information
        /// </summary>
        public Exception Exception => _Exception;

        #endregion Public Properties

        //Implements IHandleExceptions.Exception

        #region Public Methods

        /// <summary>
        /// Send the exception information with all of the default parameters
        /// </summary>
        public void Handle(Exception ex) //Implements IHandleExceptions.Handle
        {
            //Send the email (redacted)
        }

        #endregion Public Methods
    }
}
