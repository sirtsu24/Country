using System;
using System.Collections.Generic;
using System.Text;

namespace RestcountriesAPI
{
    class GetData
    {

        public string Name { get; set; }
        public List<string> TopLevelDomain { get; set; }
        public string Capital { get; set; }
        public string Region { get; set; }
        public int Population { get; set; }
        public List<Language> Languages { get; set; }
        public string Cioc { get; set; }



        public class Language
        {
            public string NativeName { get; set; }
        }


    }

    

}
