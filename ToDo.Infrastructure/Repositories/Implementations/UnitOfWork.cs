using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Infrastructure.Repositories.Interfaces;

namespace ToDo.Infrastructure.Repositories.Implementations
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly ToDoDbContext _dbContext;
		public IAccountRepository AccountRepository { get; }
		public ITaskRepository TaskRepository { get; }


		public UnitOfWork(ToDoDbContext dbContext) {
			_dbContext = dbContext;
			TaskRepository = new TaskRepository(dbContext);
			AccountRepository = new AccountRepository(dbContext);
		}

		public void Dispose()
		{
			_dbContext.Dispose();
		}

		public async Task<int> SaveChangeAsync()
		{
			return await _dbContext.SaveChangesAsync();
		}
	}
}
