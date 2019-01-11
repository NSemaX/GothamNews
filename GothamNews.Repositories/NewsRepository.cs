using GothamNews.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GothamNews.Repositories
{
    public class NewsRepository : INewsRepository
    {
        public List<NewsItem> GetAllNews()
        {
            List<NewsItem> response = new List<NewsItem>();

            response.Add(new NewsItem { Id=1, Title="News 1", Content="News 1 Content ", Thumbnail="www.something.com/1_5674.png",CreatedDate=DateTime.Now });
            response.Add(new NewsItem { Id = 2, Title = "News 2", Content = "News 2 Content ", Thumbnail = "www.something.com/2_5478.png", CreatedDate = DateTime.Now });

            return response;

        }
    }
}
