using GothamNews.Contracts;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace GothamNews.Controllers
{
    public class NewsController : ApiController
    {
        private readonly INewsService newsService;

        public NewsController(INewsService _newsService)
        {
            newsService = _newsService;
        }

        // GET: News
        [HttpGet]
        public List<NewsItem> Get()
        {
            return newsService.GetNews();
        }


    }
}