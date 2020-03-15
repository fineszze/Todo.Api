namespace Todo.Api.Models
{
    public class TodoItem
    {
        public int Id { get;set; }
        public string Action { get; set; }
        public bool IsDone { get; set; }
    }
}