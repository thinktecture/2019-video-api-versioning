using Microsoft.AspNetCore.Mvc;

namespace ApiVersioning
{
	[ApiVersion("1.0")]
	[ApiController]
	[Route("api/v{version:apiVersion}/[controller]")]
	public class SampleController : ControllerBase
	{
		[HttpGet]
		public ActionResult<string> Version()
		{
			return Ok("1");
		}
	}

	[ApiVersion("2.0")]
	[ApiController]
	[Route("api/v{version:apiVersion}/Sample")]
	public class Sample2Controller : ControllerBase
	{
		[HttpGet]
		public ActionResult<string> Version()
		{
			return Ok("2");
		}
	}
}
