using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Domain.Models;

namespace ToDo.Domain.Configurations
{
	public class TaskConfiguration : IEntityTypeConfiguration<TaskEntity>
	{
		public void Configure(EntityTypeBuilder<TaskEntity> builder)
		{
			builder.HasKey(x => x.Id);
			builder.HasOne(t => t.Account)
				.WithMany(t => t.Tasks);
		}
		
	}
}
