using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Domain.Models;
using ToDo.Infrastructure.Repositories.Interfaces;

namespace ToDo.Infrastructure.Repositories.Implementations
{
	public class TaskRepository : ITaskRepository
	{
		private ToDoDbContext dbContext;

		public TaskRepository(ToDoDbContext dbContext)
		{
			this.dbContext = dbContext;
		}

		public Task AddAsync(TaskEntity entity)
		{
			throw new NotImplementedException();
		}

		public Task<bool> CheckTaskWithUser(Guid id, Guid userId)
		{
			throw new NotImplementedException();
		}

		public Task EndTask(Guid taskId)
		{
			throw new NotImplementedException();
		}

		public Task RemoveAsync(Guid id)
		{
			throw new NotImplementedException();
		}

		public Task StartTask(Guid taskId)
		{
			throw new NotImplementedException();
		}

		public Task UpdateAsync(TaskEntity entity)
		{
			throw new NotImplementedException();
		}
	}
}
