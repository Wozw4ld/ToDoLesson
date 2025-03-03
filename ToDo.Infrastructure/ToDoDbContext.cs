using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Domain.Configurations;
using ToDo.Domain.Models;

namespace ToDo.Infrastructure
{
	public class ToDoDbContext(DbContextOptions<ToDoDbContext> options) : DbContext(options)
	{
		public DbSet<AccountEntity> Accounts { get; set; }
		public DbSet<TaskEntity>  Tasks { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new AccountConfiguration());
			modelBuilder.ApplyConfiguration(new TaskConfiguration());
			base.OnModelCreating(modelBuilder);
		}

	}
}
