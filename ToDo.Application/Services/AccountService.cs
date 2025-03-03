using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Application.Interfaces;
using ToDo.Domain.Models;
using ToDo.Infrastructure.Repositories.Interfaces;

namespace ToDo.Application.Services
{
	public class AccountService : IAccountService
	{
		private readonly IUnitOfWork _unitOfWork;
		public AccountService(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}
		public async Task Create(AccountEntity account)
		{
			await _unitOfWork.AccountRepository.AddAsync(account);
			await _unitOfWork.SaveChangeAsync();
		}
	}
}
