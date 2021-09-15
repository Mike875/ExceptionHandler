using AtExtensions.Core.ExceptionExtensions;
using System;
using System.IO;

namespace ExceptionHandler.Services
{
    /// <summary>
    /// A class used to generate Html templates
    /// </summary>
    internal class HtmlGenerationService
    {
        #region Private Fields

        /// <summary>
        /// The file location of the Html template
        /// </summary>
        private readonly string _HtmlTemplateFileLocation = "C:/Templates/HtmlTemplate.html";

        #endregion Private Fields

        //#TODO Create a dynamic file location/template reference

        #region Public Methods

        /// <summary>
        /// Return the HTML template for exception information
        /// </summary>
        /// <param name="ex"> The exception information to use in the template </param>
        /// <returns> A populated html template generated with the provided exception information </returns>
        public string GetHtml(Exception ex)
        {
            //Open a file and return the entire content with the updated placeholder information
            return File.ReadAllText(_HtmlTemplateFileLocation).Replace(
                "$HELP_LINK$", ex.HelpLink).Replace(
                "$MESSAGE$", ex.Message).Replace(
                "$SOURCE$", ex.GetFullSource()).Replace(
                "$STACK_TRACE$", ex.StackTrace);
        }

        #endregion Public Methods
    }
}
