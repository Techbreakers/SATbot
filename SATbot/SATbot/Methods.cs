using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NewsAPI;
using NewsAPI.Constants;
using NewsAPI.Models;

namespace SATbot
{
    public static class Methods
    {
        public static async Task<ArticlesResult> RetrieveNewsAsync(String api_key)
        {
            var newsApiClient = new NewsApiClient(api_key);

            var articlesResponse = await newsApiClient.GetTopHeadlinesAsync(new TopHeadlinesRequest()
            {
                Language = Languages.EN,
                PageSize = 20
            });

            if (articlesResponse.Status == Statuses.Ok)
            {
                return articlesResponse;
            }
            else
            {
                throw new Exception(articlesResponse.Error.Message);
            }
        }
    }
}
