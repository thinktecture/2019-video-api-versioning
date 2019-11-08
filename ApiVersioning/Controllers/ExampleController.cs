using Microsoft.AspNetCore.Mvc;

namespace ApiVersioning
{
	[ApiVersion("1.0")]
	[ApiVersion("2.0")]
	[ApiController]
	[Route("[controller]")]
	public class ExampleController : ControllerBase
	{
		[MapToApiVersion("1.0")]
		[HttpGet("Version")]
		public ActionResult<string> Version()
		{
			return Ok("1");
		}

		[MapToApiVersion("2.0")]
		[HttpGet("Version")]
		public ActionResult<string> Version2()
		{
			return Ok("2");
		}

		[MapToApiVersion("1.0")]
		[MapToApiVersion("2.0")]
		[HttpGet("Test")]
		public ActionResult<string> Test(ApiVersion version)
		{
			return Ok(version.ToString());
		}
	}
}
