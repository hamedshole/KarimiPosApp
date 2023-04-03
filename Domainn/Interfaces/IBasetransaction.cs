namespace Domain.Interfaces
{
    public interface IBaseTransaction<TModel>
    {
        List<TModel> Search(TModel model);
        string Insert(TModel model);
        string Delete(TModel model);
    }
}
