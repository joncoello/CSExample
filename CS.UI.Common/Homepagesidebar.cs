using Central.CSSContactAPI;
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
            sbgs[0].Add("Create client with extra fields", 0, CreateClientWithExtraFields);

            return sbgs;
        }

        private void CreateClientWithExtraFields(object Sender, SideBarEventArgs e)
        {

            var centralDAL = CssContext.Instance.GetDAL(string.Empty) as DAL;
            var centralGateway = new CentralGateway(centralDAL);

            var contact = new Organisation() {
                Name = "Extra Field Test"
            };
            centralGateway.Save(contact);
            centralGateway.ConvertContactToClient(contact, "EF001", CssContext.Instance.Host.EmployeeId);
            
            contact = (Organisation)centralGateway.FindContact(contact.ContactId, CssContext.Instance.Host.EmployeeId);

            CssContext.Instance.Host.OpenClient(contact.Client.ClientId);

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
