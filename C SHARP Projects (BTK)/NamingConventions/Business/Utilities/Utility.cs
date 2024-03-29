﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Utilities
{
    public static class Utility
    {
        /// <summary>
        /// Validating object
        /// </summary>
        /// <param name="validator">IValidator implementation</param>
        /// <param name="entity">Validating Entity</param>
        public static void Validate(IValidator validator, object entity)
        {
            var result = validator.Validate(entity);
            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
