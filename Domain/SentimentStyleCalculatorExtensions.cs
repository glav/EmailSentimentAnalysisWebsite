using EmailSentimentAnalysisWebsite.Domain.Models;

namespace EmailSentimentAnalysisWebsite.Domain
{
    public static class SentimentStyleCalculatorExtensions
    {
        const string styleGreat = "sentiment-great";
        const string styleOk = "sentiment-ok";
        const string styleNeutral = "sentiment-neutral";
        const string styleNotOk = "sentiment-not-ok";
        const string styleBad = "sentiment-bad";

        public static void ToDescriptiveSentiment(this EmailSentimentModel model)
        {
            if (model.SentimentClassification > 0.85)
            {
                model.SentimentCssClass = styleGreat;
            }
            if (model.SentimentClassification > 0.55)
            {
                model.SentimentCssClass = styleOk;
            }
            if (model.SentimentClassification >= 0.45)
            {
                model.SentimentCssClass = styleNeutral;
            }
            if (model.SentimentClassification > 0.25)
            {
                model.SentimentCssClass = styleNotOk;
            }
            model.SentimentCssClass = styleBad;

            var scoreEngine = new Glav.CognitiveServices.FluentApi.Core.ScoreEvaluation.DefaultScoreEvaluationEngine(new Glav.CognitiveServices.FluentApi.Core.ScoreEvaluation.DefaultScoreLevels());
            model.SentimentDescription = scoreEngine.EvaluateScore(model.SentimentClassification).Name;
        }

    }
}