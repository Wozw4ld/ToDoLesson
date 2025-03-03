using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Domain.Models;
using ToDo.Infrastructure.Repositories.Interfaces;

namespace ToDo.Infrastructure.Repositories.Implementations
{
	public class AccountRepository : IAccountRepository
	{
		private readonly ToDoDbContext _dbContext;
		public AccountRepository(ToDoDbContext dbContext)
		{
			_dbContext = dbContext;
		}
		public async Task AddAsync(AccountEntity entity)
		{
			await _dbContext.Accounts.AddAsync(entity);
		}

		public Task<IQueryable<AccountEntity>> GetAll()
		{
			return (Task<IQueryable<AccountEntity>>)_dbContext.Accounts.AsQueryable();
		}

		public Task<AccountEntity> GetByUserName(string userName)
		{
			return _dbContext.Accounts.FirstOrDefaultAsync(x => x.UserName == userName);
		}

		public async Task RemoveAsync(Guid id)
		{
			var user = await _dbContext.Accounts.FirstOrDefaultAsync(x => x.Id == id);
			if (user != null)
			{
				_dbContext.Accounts.Remove(user);
			}
		}

		public async Task UpdateAsync(AccountEntity entity)
		{
			if(entity == null)
			{
		
				throw new ArgumentNullException(nameof(entity));
			}
		 _dbContext.Accounts.Update(entity);
		}
	}
}
