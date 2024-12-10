# TaskTracker

Project Task URL : https://roadmap.sh/projects/task-tracker

.NET 8 Console app solution for the task-tracker [challenge](https://roadmap.sh/projects/task-tracker) from [roadmap.sh](https://roadmap.sh/).

TaskTracker is a simple and efficient command-line interface (CLI) application to help you track and manage your tasks. It supports adding, updating, deleting tasks, and managing task statuses.

## Features

- **Add, Update, and Delete tasks**: Easily manage your tasks using simple commands.
- **Mark a task as in progress or done**: Keep track of your task status.
- **List tasks**: View all tasks or filter by status.

## Getting Started

### Prerequisites

- [.NET Core SDK](https://dotnet.microsoft.com/download) (version 8.0 or later)

### Installation

1. **Clone the Repository**:
   	```sh
    git clone https://github.com/AndyHanzawa/TaskTracker.git
    ```
    ```sh
    cd TaskTracker\TaskTracker
   	```

2. **Build the Project**:
   	```sh
    dotnet build
   	```

### Usage

Run the application from the command line:

#### Adding a Task
	dotnet run -- add "Buy groceries"
Output: `Task added successfully (ID: 1)`

#### Updating a Task
    dotnet run -- update 1 "Buy groceries and cook dinner"
Output: `Task with ID 1 updated successfully.`

#### Deleting a Task
    dotnet run -- delete 1
Output: `Task with ID 1 deleted successfully.`

#### Marking a Task as In Progress
    dotnet run -- mark-in-progress 1
Output: `Task status with ID 1 updated successfully.`

#### Marking a Task as Done
    dotnet run -- mark-done 1
Output: `Task status with ID 1 updated successfully.`

#### Unmarking a Task
    dotnet run -- unmark 1
Output: `Task status with ID 1 updated successfully.`

#### Listing All Tasks
    dotnet run -- list
Output:

    Id      Status  Created Updated Description
	1       InProg  16:11   16:11   buy cola
	4       ToDo    19:51   19:51   Buy groceries
	5       Done    11:23   11:23   go gym

#### Listing Tasks by Status
    dotnet run -- list todo
    dotnet run -- list in-progress
	dotnet run -- list done
Output: `List of tasks filtered by status`

## Contact

If you have any questions or suggestions, feel free to open an issue or reach out directly.

---

Happy coding! 😊
