using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDo.Application.Interfaces;
using ToDo.Domain.Models;

namespace ToDo.Controllers
{
	[Route("api/account")]
	public class AccountController : ControllerBase
	{
		private readonly IAccountService _accountService;
		public AccountController(IAccountService accountService)
		{
			_accountService = accountService;
		}
		[HttpPost("create")]
		public async Task<IActionResult> CreateAccount(AccountEntity account)
		{
			await _accountService.Create(account);
			return Ok("Success");
		}
	}
}
