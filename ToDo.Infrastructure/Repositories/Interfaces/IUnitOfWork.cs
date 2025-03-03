using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Infrastructure.Repositories.Interfaces
{
	public interface IUnitOfWork : IDisposable
	{
		ITaskRepository TaskRepository { get; }
		IAccountRepository AccountRepository { get; }
		Task<int> SaveChangeAsync();
	}
}
