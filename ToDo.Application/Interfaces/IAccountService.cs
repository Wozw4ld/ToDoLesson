using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Domain.Models;

namespace ToDo.Application.Interfaces
{
	public interface IAccountService
	{

		public Task Create(AccountEntity account);
	}
}
