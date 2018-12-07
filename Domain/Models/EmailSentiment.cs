using System;

namespace EmailSentimentAnalysisWebsite.Domain.Models
{
    public class EmailSentimentModel
    {
        public string FromAddresses {get;set;}
        public string ToAddresses {get;set;}
        public string Subject {get;set;}
        public string OrignalBody {get;set;}
        public string SanitisedBody {get;set;}
        public double SentimentClassification {get;set;}
        public string SentimentKeyPhrases {get;set;}
        public DateTime AnalysedTimestampUtc {get;set;}
        public string SentimentCssClass {get ;set;}

    }
}