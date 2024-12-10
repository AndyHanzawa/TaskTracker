using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using TaskTracker.Models;
using TaskTracker.Models.Enums;

namespace TaskTracker.Services
{
    public class TaskService
    {
        private readonly string _filePath = "tasks.json";
        private List<AppTask> _tasks;

        public TaskService()
        {
            _tasks = LoadTasks();
        }

        private List<AppTask>? LoadTasks()
        {
            if (!File.Exists(_filePath))
            {
                File.WriteAllText(_filePath, "");
            };

            var json = File.ReadAllText(_filePath);
            return JsonConvert.DeserializeObject<List<AppTask>>(json) ?? new List<AppTask>();
        }

        private void SaveTasks()
        {
            var json = JsonConvert.SerializeObject(_tasks);
            File.WriteAllText(_filePath, json);
        }

        public void AddTask(string description)
        {
            var newTask = new AppTask
            {
                Id = _tasks.Count > 0 ? _tasks.Max(t => t.Id) + 1 : 1,
                Description = description,
                Status = StatusTask.ToDo,
                CreateAt = DateTime.Now,
                UpdateAt = DateTime.Now,
            };
            _tasks.Add(newTask);
            SaveTasks(); 
            Console.WriteLine($"Task added successfully (ID: {newTask.Id})");
        }

        public void DeleteTask(int taskId)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == taskId);
            if (task == null)
            {
                Console.WriteLine($"Task with ID {taskId} not found.");
                return;
            }
            _tasks.Remove(task);
            SaveTasks();
            Console.WriteLine($"Task with ID {taskId} deleted successfully.");
        }

        public void UpdateTask(int taskId, string description)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == taskId);
            if (task == null)
            {
                Console.WriteLine($"Task with ID {taskId} not found.");
                return;
            }
            task.Description = description;
            task.UpdateAt = DateTime.Now;
            SaveTasks();
            Console.WriteLine($"Task with ID {taskId} updated successfully.");
        }

        public void MarkInProgressTask(int taskId)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == taskId);
            if (task == null)
            {
                Console.WriteLine($"Task with ID {taskId} not found.");
                return;
            }
            task.Status = StatusTask.InProg;
            SaveTasks();
            Console.WriteLine($"Task status with ID {taskId} updated successfully.");
        }
        public void MarkDoneTask(int taskId)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == taskId);
            if (task == null)
            {
                Console.WriteLine($"Task with ID {taskId} not found.");
                return;
            }
            task.Status = StatusTask.Done;
            SaveTasks();
            Console.WriteLine($"Task status with ID {taskId} updated successfully.");
        }

        public void UnmarTask(int taskId)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == taskId);
            if (task == null)
            {
                Console.WriteLine($"Task with ID {taskId} not found.");
                return;
            }
            task.Status = StatusTask.ToDo;
            SaveTasks();
            Console.WriteLine($"Task status with ID {taskId} updated successfully.");
        }

        public void ListAllTasks()
        {
            Console.WriteLine("All Tasks");
            Console.WriteLine($"Id\tStatus\tCreated\tUpdated\tDescription");
            foreach (var task in _tasks)
            {
                Console.WriteLine($"{task.Id}\t{task.Status.ToString()}\t{task.CreateAt.ToShortTimeString()}\t{task.UpdateAt.ToShortTimeString()}\t{task.Description}");
            }
            Console.WriteLine();
        }

        public void ListToDoTasks()
        {
            Console.WriteLine("All tasks:");
            Console.WriteLine($"Id\tStatus\tCreated\tUpdated\tDescription");
            foreach (var task in _tasks)
            {
                if (task.Status == StatusTask.ToDo)
                {
                    Console.WriteLine($"{task.Id}\t{task.Status.ToString()}\t{task.CreateAt.ToShortTimeString()}\t{task.UpdateAt.ToShortTimeString()}\t{task.Description}");
                }
            }
            Console.WriteLine();
        }

        public void ListInProgressTasks()
        {
            Console.WriteLine("In progress tasks:");
            Console.WriteLine($"Id\tStatus\tCreated\tUpdated\tDescription");
            foreach (var task in _tasks)
            {
                if (task.Status == StatusTask.InProg)
                {
                    Console.WriteLine($"{task.Id}\t{task.Status.ToString()}\t{task.CreateAt.ToShortTimeString()}\t{task.UpdateAt.ToShortTimeString()}\t{task.Description}");
                }
            }
            Console.WriteLine();
        }

        public void ListDoneTasks()
        {
            Console.WriteLine("Done tasks:");
            Console.WriteLine($"Id\tStatus\tCreated\tUpdated\tDescription");
            foreach (var task in _tasks)
            {
                if (task.Status == StatusTask.Done)
                {
                    Console.WriteLine($"{task.Id}\t{task.Status.ToString()}\t{task.CreateAt.ToShortTimeString()}\t{task.UpdateAt.ToShortTimeString()}\t{task.Description}");
                }
            }
            Console.WriteLine();
        }
    }
}
