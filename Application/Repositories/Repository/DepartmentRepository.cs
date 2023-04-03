using Domain.Interfaces;
using Shared.Model;

namespace Application.Repositories.Repository
{
    internal class DepartmentRepository : MainRepository<DepartmentModel>, IDepartment
    {
        public DepartmentRepository(IDepartment repository) : base(repository)
        {

        }
    }
}
