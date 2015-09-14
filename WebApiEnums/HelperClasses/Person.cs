using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
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

        //Uncomment this line to have this property serialized to its name.
        //[JsonConverter(typeof(StringEnumConverter))]
        public Language PrimaryLanguage { get; set; }
    }
}