CREATE PROCEDURE [dbo].[spMstPRJPippaActivity_Delete]
	@PippaActivitID int
AS
begin
	delete
	from dbo.[MstPRJPippaActivity]
	where PippaActivitID = @PippaActivitID
end

