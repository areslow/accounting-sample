using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Utilities
{
    public class RatingRangeAttribute : ValidationAttribute
    {
        private readonly double[] _validValues;
        public RatingRangeAttribute()
        {
            _validValues = new double[] { 0, 0.5, 1,
                                          1.5, 2, 2.5,
                                          3, 3.5, 4,
                                           4.5, 5 };
        }
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if(value == null) { return new ValidationResult("Value can not be null"); }
            if(value is double doubleValue)
            {
                if (Array.Exists(_validValues, v => v == doubleValue)) return ValidationResult.Success;
                else return new ValidationResult($"the value must be one of the following : {string.Join(",", _validValues)} .");
            }
            return new ValidationResult("Invalid data type!");
        }
    }
}
