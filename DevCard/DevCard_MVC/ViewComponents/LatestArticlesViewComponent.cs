using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DevCard_MVC.ViewComponents
{
    public class LatestArticlesViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var Articles = new List<Article>
            {
                new Article(1,"شبکه","آموزش شبکه","blog-post-thumb-card-1.jpg"),
                new Article(2,"شبکه","آموزش شبکه","blog-post-thumb-card-2.jpg"),
                new Article(3,"شبکه","آموزش شبکه","blog-post-thumb-card-3.jpg"),
                new Article(4,"شبکه","آموزش شبکه","blog-post-thumb-card-4.jpg"),
            };
            return View("_LatestArticles", Articles);
        }
    }
}
