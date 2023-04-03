using ApiServerTests;
using Shared.Model;

namespace ApiServerTests.Controllers
{
    public class DiscountControllerTests : Template<DiscountModel>
    {
        public DiscountControllerTests() : base("api/discount", new DiscountModel { Percent = 10, Title = "test" }, new DiscountModel { Id = 2, Title = "سایت", Percent = 7 }, "پرسنل", "سایت", 1)
        {

        }
    }
}