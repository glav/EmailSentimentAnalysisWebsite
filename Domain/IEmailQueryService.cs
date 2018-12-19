using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmailSentimentAnalysisWebsite.Domain
{
    public interface IEmailQueryService
    {
        Task<IEnumerable<Models.EmailSentimentModel>> GetLatestEmailSentimentAsync();
        Task<string> GetCurrentprocessingStatus();
    }
}