using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Domain.Models;

namespace ToDo.Infrastructure.Repositories.Interfaces
{
	public interface IAccountRepository : IRepository<AccountEntity>
	{
		Task<AccountEntity> GetByUserName(string userName);
		Task<IQueryable<AccountEntity>> GetAll();
	}
}
