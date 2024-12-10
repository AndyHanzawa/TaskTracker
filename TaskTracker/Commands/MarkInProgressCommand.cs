using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskTracker.Services;

namespace TaskTracker.Commands
{
    public class MarkInProgressCommand
    {
        private readonly TaskService _taskService;

        public MarkInProgressCommand(TaskService taskService)
        {
            _taskService = taskService;
        }

        public void Execute(int taskId)
        {
            _taskService.MarkInProgressTask(taskId);
        }
    }
}
