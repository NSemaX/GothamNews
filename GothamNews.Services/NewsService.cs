using GothamNews.Contracts;
using GothamNews.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GothamNews.Services
{
    public class NewsService :INewsService
    {
        private readonly INewsRepository newsRepository;

        public NewsService()
        {
            this.newsRepository = new NewsRepository();
        }

        public List<NewsItem> GetNews()
        {
            return newsRepository.GetAllNews();
        }
    }
}
