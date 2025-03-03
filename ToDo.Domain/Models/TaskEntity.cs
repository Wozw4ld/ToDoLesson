namespace ToDo.Domain.Models
{
	public class TaskEntity
	{
		public Guid Id { get; set; }
		public string Title { get; set; }
		public string Text { get; set; }	
		public int TaskStatus {  get; set; }
		public Guid AccountId { get; set; }
		public AccountEntity Account { get; set; }
	}
}
