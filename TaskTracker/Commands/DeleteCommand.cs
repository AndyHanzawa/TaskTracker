using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskTracker.Services;

namespace TaskTracker.Commands
{
    public class DeleteCommand
    {
        private readonly TaskService _taskService;

        public DeleteCommand(TaskService taskService)
        {
            _taskService = taskService;
        }

        public void Execute(int taskId)
        {
            _taskService.DeleteTask(taskId);
        }
    }
}
