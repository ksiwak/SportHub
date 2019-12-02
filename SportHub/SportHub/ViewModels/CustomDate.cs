using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;
using Microsoft.Owin.Security.Provider;

namespace SportHub.ViewModels
{
    public class CustomDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var isValid = DateTime.TryParseExact(Convert.ToString(value),
                "d MMM yyyy",
                CultureInfo.CurrentCulture,
                DateTimeStyles.None,
                out var dateTime);
            return (isValid && dateTime > DateTime.Now);

        }
     }
}