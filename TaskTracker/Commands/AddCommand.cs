using TaskTracker.Services;

namespace TaskTracker.Commands
{
    public class AddCommand
    {
        private readonly TaskService _taskService;

        public AddCommand(TaskService taskService)
        {
            _taskService = taskService;
        }

        public void Execute(string description)
        {
            _taskService.AddTask(description);
        }
    }
}
