using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmailSentimentAnalysisWebsite.Domain;
using EmailSentimentAnalysisWebsite.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmailSentimentAnalysisWebsite.Controllers
{
    
    [Route("api/[controller]")]
    public class EmailSentimentController : Controller
    {
        private readonly IEmailQueryService _emailQueryService;

        public EmailSentimentController()
        {
            //TODO: Replace one DI in place
            _emailQueryService = new EmailQueryService();
        }
    
        [HttpGet("[action]")]
        public async Task<IEnumerable<EmailSentimentModel>> LatestEmailSentimentAsync()
        {
            return await _emailQueryService.GetLatestEmailSentimentAsync();
        }

    }
}
