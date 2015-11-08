using CS.TaskRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MYOB.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.TaskRepositoryTests
{
    [TestClass]
    [DeploymentItem("lookup.xml")]
    public class CentralTaskRepositoryTests
    {

        [TestMethod]
        public void CentralTaskRepository_Create()
        {
            var centralDAL = new DAL("0");
            int employeeID = 7;
            var contactID = 1323;
            var sut = new CentralTaskRepository(centralDAL, employeeID, contactID);
        }

        [TestMethod]
        public void CentralTaskRepository_CreateTask()
        {
            var centralDAL = new DAL("0");
            int employeeID = 7;
            var contactID = 1323;
            var sut = new CentralTaskRepository(centralDAL, employeeID, contactID);
            var task = sut.CreateTask("Test task", DateTime.Now, employeeID);

            Assert.AreNotEqual(0, task.TaskID);

        }

    }
}
