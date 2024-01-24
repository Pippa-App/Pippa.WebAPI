using Pippa.DataAccess.Models;

namespace Pippa.DataAccess.Data
{
    public interface IMstPRJPippaActivityData
    {
        Task<IEnumerable<MstPRJPippaActivity>> GetData();
    }
}