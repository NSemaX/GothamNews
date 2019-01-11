using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GothamNews.Contracts
{
    public interface INewsRepository
    {
       List<NewsItem> GetAllNews();
    }
}
