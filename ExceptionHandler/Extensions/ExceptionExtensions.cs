using ExceptionHandler.Interfaces;
using System;

namespace ExceptionHandler.Extensions
{
    /// <summary>
    /// Contain all extension methods for the System.Exception class
    /// </summary>
    public static class ExceptionExtensions
    {
        #region Public Methods

        /// <summary>
        /// Handle one exception in one or more ways
        /// </summary>
        /// <param name="exception">     The client defined exception information </param>
        /// <param name="handleMethods">
        /// An array of methods that will be used to handle the exception
        /// </param>
        public static void Handle(this Exception exception, params IExceptionHandler[] handleMethods)
        {
            foreach (IExceptionHandler handleMethod in handleMethods)
            {
                handleMethod.Handle(exception);
            }
        }

        #endregion
    }
}
