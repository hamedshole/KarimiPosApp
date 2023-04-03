using KarimiApp.Client.Repository.Util;
using KarimiApp.Interface.Client;
using Shared.Model;

namespace KarimiApp.Client.Repository.Repository
{
    internal class DepartmentRepository : MainRepository<DepartmentModel>, IDepartment
    {
        public DepartmentRepository(HttpClientAccess httpClient) : base("department", httpClient)
        {

        }



    }
}
