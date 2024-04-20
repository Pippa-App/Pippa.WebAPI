CREATE PROCEDURE [dbo].[spMstPRJPippaActivity_Insert]
	@PippaActivitID int,
	@PippaActivityName varchar(50)
AS
begin
	update MstPRJPippaActivity
	SET PippaActivityName = @PippaActivityName
	where PippaActivitID = @PippaActivitID
end

