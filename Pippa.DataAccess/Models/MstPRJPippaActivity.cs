using System;

namespace Pippa.DataAccess.Models;

public class MstPRJPippaActivity
{
    
    public int PippaActivityID { get; set; }
    public required string PippaActivityName { get; set; }
    public DateTime CreatedDate { get; set; }
	public required string CreatedBy { get; set; }
    public DateTime UpdatedDate { get; set; }
    public required string UpdatedBy { get; set; }
}
