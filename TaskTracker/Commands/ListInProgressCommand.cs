using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskTracker.Services;

namespace TaskTracker.Commands
{
    public class ListInProgressCommand
    {
        private readonly TaskService _taskService;

        public ListInProgressCommand(TaskService taskService)
        {
            _taskService = taskService;
        }

        public void Execute()
        {
            _taskService.ListInProgressTasks();
        }
    }
}
