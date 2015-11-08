using CS.DomainModel.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS.DomainModel.Models.Tasks;
using MYOB.CSSTaskManagement;
using MYOB.DAL;

namespace CS.TaskRepository
{
    public class CentralTaskRepository : ITaskRepository
    {
        private DAL _centralDAL;
        private int _contactID;
        private int _employeeID;

        private const int TASK_ACTION_CREATED = 1;

        public CentralTaskRepository(DAL centralDAL, int employeeID, int contactID)
        {
            _centralDAL = centralDAL;
            _employeeID = employeeID;
            _contactID = contactID;
        }

        public CentralTask CreateTask(string description, DateTime dueDate, int employeeID)
        {
            var t = new CSSTask();
            t.Description = description;
            t.DueEnd = dueDate;
            t.SetCodeAsSystemCRMCode();
            t.Save();
            t.AssignToContactAssignment(CSSTask.CSSAssignToType.Contact, _contactID);
            t.AssignTo(_employeeID, _employeeID, DateTime.Now, string.Empty, TASK_ACTION_CREATED);

            return new CentralTask() {
                TaskID = t.TaskId,
                Description = t.Description
            };

        }

    }

}
