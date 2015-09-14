using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiEnums.HelperClasses
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Language PrimaryLanguage { get; set; }
    }
}