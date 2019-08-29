using System.Web.Mvc;
using Sitecore.Mvc.Controllers;

namespace <%= solutionName + '.Feature.' + featureTitle %>.Controllers
{
    public class DemoController : SitecoreController
    {
        public ActionResult ReturnEmptyResult()
        {
            return new EmptyResult();
        }
    }
}