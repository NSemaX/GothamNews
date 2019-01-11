using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GothamNews.Contracts
{
    public interface INewsService
    {
        List<NewsItem> GetNews();
    }
}
