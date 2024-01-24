if not exists(select 1 from dbo.[MstPRJPippaActivity])
begin
	insert into dbo.[MstPRJPippaActivity](PippaActivityName, CreatedDate, CreatedBy)
	values ('Activity 1', getdate(), 'david')
end