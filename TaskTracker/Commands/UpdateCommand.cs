using TaskTracker.Services;

namespace TaskTracker.Commands
{
    public class UpdateCommand
    {
        private readonly TaskService _taskService;

        public UpdateCommand(TaskService taskService)
        {
            _taskService = taskService;
        }

        public void Execute(int taskId, string description)
        {
            _taskService.UpdateTask(taskId, description);
        }
    }
}
