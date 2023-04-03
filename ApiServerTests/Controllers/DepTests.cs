using Shared.Model;

namespace ApiServerTests.Controllers
{
    public class DepTests : Template<DepartmentModel>

    {
        public DepTests()
        : base("api/department"
                  ,  new DepartmentModel()
                  {
                      Description = "",
                      DefaultInventory = "سردخانه اصلی"
            ,
                      Active = true,
                      Title = "test2"
                  }
                  , new DepartmentModel()
                  {
                      Id=7,
                      Description = "",
                      DefaultInventory = "سردخانه اصلی"
            ,
                      Active = true,
                      Title = "test2"
                  }
                  , "ویترین"
              , "ویترین"
              , 7)
        {
            
        }
    }
}
