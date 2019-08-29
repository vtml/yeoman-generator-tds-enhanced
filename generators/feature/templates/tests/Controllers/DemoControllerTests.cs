using System.Web;
using System.Web.Mvc;
using <%= solutionName + '.Feature.' + featureTitle %>.Controllers;
using FluentAssertions;
using Ploeh.AutoFixture.Xunit2;
using Sitecore.Data;
using Sitecore.FakeDb;
using Sitecore.FakeDb.AutoFixture;
using Sitecore.Foundation.Testing;
using Sitecore.Foundation.Testing.Attributes;
using Sitecore.Mvc.Presentation;
using Xunit;

namespace <%= solutionName + '.Feature.' + featureTitle %>.Tests.Controllers
{
    public class DemoControllerTests
    {
        public DemoControllerTests()
        {
            HttpContext.Current = HttpContextMockFactory.Create();
        }

        [Theory]
        [AutoDbData]
        public void DemoContent_ReturnEmptyResult_ShouldReturnEmptyResult(Db db,
            [Greedy] DemoController demoController, [Content] ID itemId)
        {
            using (RenderingContext.EnterContext(new Rendering(), db.GetItem(itemId)))
            {
                demoController.ReturnEmptyResult().As<ActionResult>().Should().BeOfType<EmptyResult>();
            }
        }
    }
}