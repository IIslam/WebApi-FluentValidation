﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Dependencies;
using FluentValidation;

namespace RichardLawley.WebApi.FluentValidation
{
    /// <summary>
    /// Provides FluentValidation validators for a type
    /// </summary>
    public interface IFluentValidatorProvider
    {
        /// <summary>
        /// Provides any FluentValidation Validators appropriate for validating the specified type.  These will have
        /// been created within the specified Dependency Scope
        /// </summary>
        /// <param name="type">Model type to find validators for</param>
        /// <param name="scope">Scope to create validators from</param>
        /// <returns></returns>
        IEnumerable<IValidator> GetValidators(Type type, IDependencyScope scope);
    }
}
