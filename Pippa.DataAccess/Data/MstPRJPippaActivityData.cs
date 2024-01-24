using Pippa.DataAccess.DbAccess;
using Pippa.DataAccess.Models;

namespace Pippa.DataAccess.Data;

public class MstPRJPippaActivityData : IMstPRJPippaActivityData
{
    private readonly ISqlDataAccess db;

    public MstPRJPippaActivityData(ISqlDataAccess db)
    {
        this.db = db;
    }

    public Task<IEnumerable<MstPRJPippaActivity>> GetData() =>
        db.LoadData<MstPRJPippaActivity, dynamic>("dbo.spMstPRJPippaActivity_GetAll", new { });


}
