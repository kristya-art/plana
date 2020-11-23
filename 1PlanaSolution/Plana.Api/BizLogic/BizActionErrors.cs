using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Plana.Api.BizLogic
{
    public abstract class BizActionErrors
    {
        private readonly List<ValidationResult> _errors
            = new List<ValidationResult>();

        /// <summary>
        /// provides a public, immutable list of errors
        /// </summary>
        public IImmutableList<ValidationResult> Errors
            => _errors.ToImmutableList();

        /// <summary>
        /// creates a bool HasErrors to make checking for errors easier
        /// </summary>
        public bool HasErrors => _errors.Any();
        /// <summary>
        /// allows a simple error message, or an error message with properties
        /// linked to it, to be added to the errors list.
        /// </summary>
        /// <param name="errorMessage"></param>
        /// <param name="propertyNames"></param>
        protected void AddError(string errorMessage, params string[] propertyNames)
        {
            _errors.Add(new ValidationResult
                (errorMessage, propertyNames));
        }
        
    }
}
