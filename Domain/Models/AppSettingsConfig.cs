using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmailSentimentAnalysisWebsite.Domain.Models
{
    public class AppSettingsConfig
    {
        public string ApiEndpoint { get; set; }
        public string ApiStatusEndpoint { get; set; }
        public bool UseDummyData { get; set; }
    }
}
