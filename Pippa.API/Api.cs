using Pippa.DataAccess.Data;

namespace Pippa.WebAPI;

//using Microsoft.AspNetCore.Cors;

public static class Api
{
    //[EnableCors(origins: "https://microservicemandiri.azurewebsites.net", headers: "*", methods: "*")]
    public static void ConfigureApi(this WebApplication app)
    {
        // dta: All of my API endpoint mapping
        app.MapGet("/Mst/PippaActivity", GetMstPRJPippaActivity);
        //app.MapGet("/Categories/{categoryID}", GetCategory);
        //app.MapPost("/Categories", InsertCategory);
        //app.MapPut("/Categories", UpdateCategory);
        //app.MapDelete("/Categories", DeleteCategory);
    }

    #region Master

    private static async Task<IResult> GetMstPRJPippaActivity(IMstPRJPippaActivityData data)
    {
        try
        {
            return Results.Ok(await data.GetData());
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    //private static async Task<IResult> GetItem(int itemID, IItemData data)
    //{
    //    try
    //    {
    //        var results = await data.GetItem(itemID);
    //        if (results == null) return Results.NotFound();
    //        return Results.Ok(results);
    //    }
    //    catch (Exception ex)
    //    {
    //        return Results.Problem(ex.Message);
    //    }
    //}

    //private static async Task<IResult> InsertItem(ItemModel item, IItemData data)
    //{
    //    try
    //    {
    //        await data.InsertItem(item);
    //        return Results.Ok();
    //    }
    //    catch (Exception ex)
    //    {
    //        return Results.Problem(ex.Message);
    //    }
    //}

    //private static async Task<IResult> UpdateItem(ItemModel item, IItemData data)
    //{
    //    try
    //    {
    //        await data.UpdateItem(item);
    //        return Results.Ok();
    //    }
    //    catch (Exception ex)
    //    {
    //        return Results.Problem(ex.Message);
    //    }
    //}

    //private static async Task<IResult> DeleteItem(int itemID, IItemData data)
    //{
    //    try
    //    {
    //        await data.DeleteItem(itemID);
    //        return Results.Ok();
    //    }
    //    catch (Exception ex)
    //    {
    //        return Results.Problem(ex.Message);
    //    }
    //}

    #endregion



}
