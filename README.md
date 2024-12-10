# TaskTrackerCLI

TaskTrackerCLI is a simple and efficient command-line interface (CLI) application to help you track and manage your tasks. It supports adding, updating, deleting tasks, and managing task statuses.

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
    cd TaskTracker
   ```

2. **Build the Project**:
   ```sh
    dotnet build
   ```

### Usage

Run the application from the command line:

#### Adding a Task
   ```sh
	dotnet run -- add "Buy groceries"
   ```
    Output: `Task added successfully (ID: 1)`

#### Updating a Task
   ```sh
    dotnet run -- update 1 "Buy groceries and cook dinner"
   ```
    Output: `Task updated successfully (ID: 1)`

#### Deleting a Task
   ```sh
    dotnet run -- delete 1
   ```
    Output: `Task deleted successfully (ID: 1)`

#### Marking a Task as In Progress
   ```sh
    dotnet run -- mark-in-progress 1
   ```
    Output: `Task marked as in progress (ID: 1)`

#### Marking a Task as Done
   ```sh
    dotnet run -- mark-done 1
   ```
    Output: `Task marked as done (ID: 1)`

#### Listing All Tasks
   ```sh
    dotnet run -- list
   ```
    Output: List of all tasks

#### Listing Tasks by Status
   ```sh
    dotnet run -- list done
    dotnet run -- list todo
    dotnet run -- list in-progress
   ```
    Output: List of tasks filtered by status

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Contact

If you have any questions or suggestions, feel free to open an issue or reach out directly.

---

Happy coding! 😊
