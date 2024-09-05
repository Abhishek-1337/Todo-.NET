using ToDo.Models;

namespace ToDo
{
    public class TodoDataStore
    {
        public List<TodoDto> Todos { get; set; }
        public static TodoDataStore Current { get; } = new TodoDataStore();
        private TodoDataStore()
        {
            Todos = new List<TodoDto>() {
                new TodoDto(){
                    Id = 1,
                    Title = "Improve work ethic",
                    Date = DateTime.Now,
                    Tags = new List<TodoTagDto>(){
                        new TodoTagDto() {
                            Id = 1,
                            TagName = "Discipiline personality"
                        },
                        new TodoTagDto() {
                            Id = 2,
                            TagName = "That life"
                        }
                    }
                },
                new TodoDto (){
                    Id = 2,
                    Title = "Study more, be discipiline",
                    Date = DateTime.Now
                }
            };
        }

    }
}