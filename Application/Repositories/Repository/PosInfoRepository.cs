using Domain.Interfaces;
using Shared.Model;

namespace Application.Repositories.Repository
{
    internal class PosInfoRepository : MainRepository<PosInfoModel>, IPosInfo
    {
        public PosInfoRepository(IPosInfo repository) : base(repository)
        {
        }
    }
}
