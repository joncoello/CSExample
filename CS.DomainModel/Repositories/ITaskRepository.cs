using CS.DomainModel.Models.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.DomainModel.Repositories
{
    public interface ITaskRepository
    {
        CentralTask CreateTask(string description, DateTime dueDate, int employeeID);
    }
}
