using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiEnums.HelperClasses;

namespace WebApiEnums.Controllers
{
    [RoutePrefix("Values")]
    public class ValuesController : ApiController
    {
        [Route("Person")]
        [HttpGet]
        public Person Get()
        {
            var person = new Person()
            {
                FirstName = "John",
                LastName = "Smith",
                PrimaryLanguage = Language.English
            };
            return person;
        }

        [Route("Languages")]
        [HttpGet]
        public List<Language> GetLanguages()
        {
            List<Language> languages = new List<Language>();
            foreach (Language language in Enum.GetValues(typeof(Language)))
            {
                languages.Add(language);
            }
            return languages;
        }

        [Route("SendLanguage/{language}")]
        [HttpPost]
        public Language? SendLanguage(string language)
        {
            Language parsedLanguage;
            if(Enum.TryParse<Language>(language, true /* ignore case */, out parsedLanguage))
            {
                return parsedLanguage;
            }
            return null;
        }
    }
}
