namespace ToDo.Models
{
    public class TodoDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public ICollection<TodoTagDto> Tags { get; set; } = new List<TodoTagDto>();
    }
}