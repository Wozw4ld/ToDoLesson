using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Domain.Models
{
	public class AccountEntity
	{
		public Guid Id { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }	
		public List<TaskEntity> Tasks { get; set; }
	}
}
