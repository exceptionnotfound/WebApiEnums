using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiEnums.HelperClasses
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Language
    {
        English,
        French,
        Spanish,
        Russian,
        German,
        Mandarin,
        Cantonese,
        Farsi,
        Zulu
    }
}