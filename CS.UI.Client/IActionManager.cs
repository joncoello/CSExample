using System.ServiceModel;

namespace CS.UI.Client
{
    [ServiceContract]
    internal interface IActionManager
    {
        [OperationContract]
        void SendMessage(string message);
    }
}