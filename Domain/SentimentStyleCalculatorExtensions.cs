using EmailSentimentAnalysisWebsite.Domain.Models;
using Glav.CognitiveServices.FluentApi.Core.ScoreEvaluation;
using System.Collections.Generic;

namespace EmailSentimentAnalysisWebsite.Domain
{
    public static class SentimentStyleCalculatorExtensions
    {
        private static Dictionary<string, string> _styleMapping = new Dictionary<string, string>();

        const string styleAwesome = "sentiment-awesome";
        const string styleGreat = "sentiment-great";
        const string styleOk = "sentiment-ok";
        const string styleNeutral = "sentiment-neutral";
        const string styleGlum = "sentiment-glum";
        const string styleNotOk = "sentiment-not-ok";
        const string styleBad = "sentiment-bad";

        public const string descAwesome = "Awesome";
        public const string descGreat = "Feeling good";
        public const string descOk = "Feeling ok";
        public const string descNeutral = "Neutral";
        public const string descSlightDown = "Meh";
        public const string descNotOk = "Feeling down";
        public const string descBad = "Bad";

        static SentimentStyleCalculatorExtensions()
        {
            _styleMapping.Add(descBad, styleBad);
            _styleMapping.Add(descNotOk, styleNotOk);
            _styleMapping.Add(descSlightDown, styleGlum);
            _styleMapping.Add(descNeutral, styleNeutral);
            _styleMapping.Add(descOk, styleOk);
            _styleMapping.Add(descGreat, styleGreat);
            _styleMapping.Add(descAwesome, styleAwesome);
        }

        public static void ToDescriptiveSentiment(this EmailSentimentModel model)
        {
            var scoreEngine = new DefaultScoreEvaluationEngine(new CustomScoreLevels());
            model.SentimentDescription = scoreEngine.EvaluateScore(model.SentimentClassification).Name;
            model.SentimentCssClass = _styleMapping[model.SentimentDescription];
        }

    }

    public class CustomScoreLevels : BaseScoreLevelsCollection
    {
        public CustomScoreLevels()
        {
            AddStartingScoreLevel(0.25, SentimentStyleCalculatorExtensions.descBad);
            AddNextScoreLevelDefinitionInList(0.45, SentimentStyleCalculatorExtensions.descNotOk);
            AddNextScoreLevelDefinitionInList(0.49, SentimentStyleCalculatorExtensions.descSlightDown);
            AddNextScoreLevelDefinitionInList(0.51, SentimentStyleCalculatorExtensions.descNeutral);
            AddNextScoreLevelDefinitionInList(0.75, SentimentStyleCalculatorExtensions.descOk);
            AddNextScoreLevelDefinitionInList(0.90, SentimentStyleCalculatorExtensions.descGreat);
            AddFinalScoreLevel(SentimentStyleCalculatorExtensions.descAwesome);
        }
    }
}