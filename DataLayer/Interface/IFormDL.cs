using AbhaApi.Model;

namespace AbhaApi.DataLayer.Interface
{
    public interface IFormDL
    {
        Task<IEnumerable<FormResponse>> GetForm(QueryFilter<FormResponse> filter);
    }
}