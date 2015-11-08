using CS.DomainModel.Services;
using CS.TaskRepository;
using MYOB.CSS;
using MYOB.CSSInterface;
using MYOB.CSSTaskManagement;
using MYOB.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.UI.Common
{
    public class Homepagesidebar : CSSTabSideBarItems
    {
        public override AvailableArea Area
        {
            get
            {
                return AvailableArea.HomePage;
            }
        }

        public override SideBarGroup[] AddItems()
        {
            var sbgs = new SideBarGroup[1];

            sbgs[0] = new SideBarGroup();
            sbgs[0].Name = "Tasks Example";
            sbgs[0].Add("Create task", 0, CreateTask);

            return sbgs;
        }

        private void CreateTask(object Sender, SideBarEventArgs e)
        {
            var selectedContacts = CssContext.Instance.Host.RetrieveEntityId(CSSFormEventHandler.CSSEventArea.Contact);
            if (selectedContacts.Length > 0) {

                int contactID = selectedContacts[0];
                var centralDAL = CssContext.Instance.GetDAL(string.Empty) as DAL;
                var taskRepository = new CentralTaskRepository(centralDAL, CssContext.Instance.Host.EmployeeId, contactID);
                var taskService = new TaskService(taskRepository);
                taskService.CreateTask("My new task", DateTime.Now, CssContext.Instance.Host.EmployeeId);

                System.Windows.Forms.MessageBox.Show("Done");

            }

        }
    }

}
