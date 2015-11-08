using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS.DomainModel.Models.Tasks;
using CS.DomainModel.Repositories;

namespace CS.DomainModel.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;

        public TaskService(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }
        public CentralTask CreateTask(string description, DateTime dueDate, int employeeID)
        {
            return _taskRepository.CreateTask(description, dueDate, employeeID);
        }
    }
}
