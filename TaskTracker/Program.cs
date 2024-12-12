using System;
using System.Linq;
using TaskTracker.Commands;
using TaskTracker.Services;

namespace TaskTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please provide a command.");
                return;
            }

            var _taskService = new TaskService();

            var taskId = 0;

            switch (args[0].ToLower())
            {
                case "add":
                    if (args.Length < 2)
                    {
                        Console.WriteLine("Please provide a task description.");
                        return;
                    }
                    var addCommand = new AddCommand(_taskService);
                    addCommand.Execute(string.Join(" ", args.Skip(1)));
                    break;
                case "update":
                    if (args.Length < 3 || !int.TryParse(args[1], out taskId))
                    {
                        Console.WriteLine("Please provide a valid task ID.");
                        return;
                    }
                    var updateCommand = new UpdateCommand(_taskService);
                    updateCommand.Execute(taskId, string.Join(" ", args.Skip(2)));
                    break;
                case "delete":
                    if (args.Length < 2 || !int.TryParse(args[1], out taskId))
                    {
                        Console.WriteLine("Please provide a valid task ID.");
                        return;
                    }
                    var deleteCommand = new DeleteCommand(_taskService);
                    deleteCommand.Execute(taskId);
                    break;
                case "mark-in-progress":
                    if (args.Length < 2 || !int.TryParse(args[1], out taskId))
                    {
                        Console.WriteLine("Please provide a valid task ID.");
                        return;
                    }
                    var markInProgressCommand = new MarkInProgressCommand(_taskService);
                    markInProgressCommand.Execute(taskId);
                    break;
                case "mark-done":
                    if (args.Length < 2 || !int.TryParse(args[1], out taskId))
                    {
                        Console.WriteLine("Please provide a valid task ID.");
                        return;
                    }
                    var markDoneCommand = new MarkDoneCommand(_taskService);
                    markDoneCommand.Execute(taskId);
                    break;
                case "unmark":
                    if (args.Length < 2 || !int.TryParse(args[1], out taskId))
                    {
                        Console.WriteLine("Please provide a valid task ID.");
                        return;
                    }
                    var unmarkCommand = new UnmarkCommand(_taskService);
                    unmarkCommand.Execute(taskId);
                    break;
                case "list":
                    if (args.Length == 1)
                    {
                        var listAllCommand = new ListAllCommand(_taskService);
                        listAllCommand.Execute();
                    }
                    else
                    {
                        switch (args[1].ToLower())
                        {
                            case "done":
                                var listDoneCommand = new ListDoneCommand(_taskService);
                                listDoneCommand.Execute(); break;
                            case "todo":
                                var listToDoCommand = new ListToDoCommand(_taskService);
                                listToDoCommand.Execute();
                                break;
                            case "in-progress":
                                var listInProgressCommand = new ListInProgressCommand(_taskService);
                                listInProgressCommand.Execute(); break;
                            default:
                                Console.WriteLine("Unknown list option.");
                                break;
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Unknown command.");
                    break;
            }
        }
    }
}
