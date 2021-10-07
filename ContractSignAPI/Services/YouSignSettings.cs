using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContractSignAPI.Services
{
    public class YouSignSettings
    {
        public string UrlApi { get; set; }
        public string UrlApp { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string ApiKey { get; set; }
        public string Certificat { get; set; }
    }
}
