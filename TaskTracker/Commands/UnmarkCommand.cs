using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskTracker.Services;

namespace TaskTracker.Commands
{
    public class UnmarkCommand
    {
        private readonly TaskService _taskService;

        public UnmarkCommand(TaskService taskService)
        {
            _taskService = taskService;
        }

        public void Execute(int taskId)
        {
            _taskService.UnmarTask(taskId);
        }
    }
}
