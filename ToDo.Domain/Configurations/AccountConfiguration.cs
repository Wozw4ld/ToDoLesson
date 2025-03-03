using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToDo.Domain.Models;

namespace ToDo.Domain.Configurations
{
	public class AccountConfiguration : IEntityTypeConfiguration<AccountEntity>
	{
		public void Configure(EntityTypeBuilder<AccountEntity> builder)
		{
			builder.HasKey(x => x.Id);
			builder.HasMany(t => t.Tasks)
				.WithOne(t => t.Account);
		}
		
	}
}
