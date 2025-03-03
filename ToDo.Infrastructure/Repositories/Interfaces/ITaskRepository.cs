using ToDo.Domain.Models;

namespace ToDo.Infrastructure.Repositories.Interfaces
{
	public interface ITaskRepository : IRepository<TaskEntity>
	{
		public Task<bool> CheckTaskWithUser(Guid id, Guid userId);
		public Task StartTask(Guid taskId);
		public Task EndTask(Guid taskId);
	}
}
