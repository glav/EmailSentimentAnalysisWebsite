namespace EmailSentimentAnalysisWebsite.Domain
{
    public static class SentimentStyleCalculatorExtensions
    {
        const string styleGreat = "sentiment-great";
        const string styleOk = "sentiment-ok";
        const string styleNeutral = "sentiment-neutral";
        const string styleNotOk = "sentiment-not-ok";
        const string styleBad = "sentiment-bad";

        public static string ToSentimentStyle(this double sentimentValue)
        {
            if (sentimentValue > 0.85)
            {
                return styleGreat;
            }
            if (sentimentValue > 0.55)
            {
                return styleOk;
            }
            if (sentimentValue >= 0.45)
            {
                return styleNeutral;
            }
            if (sentimentValue > 0.25)
            {
                return styleNotOk;
            }
            return styleBad;
        }

    }
}