using TaskTracker.Services;

namespace TaskTracker.Commands
{
    public class MarkDoneCommand
    {
        private readonly TaskService _taskService;

        public MarkDoneCommand(TaskService taskService)
        {
            _taskService = taskService;
        }

        public void Execute(int taskId)
        {
            _taskService.MarkDoneTask(taskId);
        }
    }
}
