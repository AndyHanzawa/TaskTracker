using TaskTracker.Models.Enums;

namespace TaskTracker.Models
{
    public class AppTask
    {
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public StatusTask Status { get; set; } = StatusTask.ToDo;
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}
