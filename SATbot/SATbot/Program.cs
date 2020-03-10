using System;

namespace SATbot
{
    class Program
    {
        static void Main(string[] args)
        {
            // Change your api key
            var news_api_key = "";
            var articleResponse = Methods.RetrieveNewsAsync(news_api_key);

            try
            {
                var articles = articleResponse.Result.Articles;

                foreach (var article in articles)
                {
                    Console.WriteLine($"Title: {article.Title}\nDescription: {article.Description}");
                }
            }
            catch
            {
                Console.WriteLine("There is no top headlines");
            }
        }
    }
}
