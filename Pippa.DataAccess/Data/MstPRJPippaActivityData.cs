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

    public Task Delete(int id) =>
        db.SaveData("dbo.spMstPRJPippaActivity_Delete", new { PippaActivityID = id });

    public Task Update(int id, string name) =>
        db.SaveData("dbo.spMstPRJPippaActivity_Update", new { PippaActivityID = id, PippaActivityName = name });

}
