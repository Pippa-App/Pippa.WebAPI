CREATE PROCEDURE [dbo].[spMstPRJPippaActivity_Insert]
	@PippaActivityName varchar(50)
AS
begin
	insert into MstPRJPippaActivity(PippaActivityName, CreatedBy, CreatedDate)
	values (@PippaActivityName, 'david', getdate())
end
