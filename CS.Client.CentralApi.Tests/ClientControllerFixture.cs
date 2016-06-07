using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Results;
using AutoMapper;
using CS.Accessors.ClientAccessor;
using CS.App.Models;
using CS.Client.CentralApi.Controllers;
using CS.FakesForTesting;
using Moq;
using NUnit.Framework;

namespace CS.Client.CentralApi.Tests
{
    [TestFixture]
    public class ClientControllerFixture
    {
        private ClientController _clientController;
        private Mock<IMapper> _mapper;
        private IClientAccessor _accessor;

        [SetUp]
        public void Init()
        {
            _mapper = new Mock<IMapper>();
            _accessor = new FakeClientAccessor();// new Mock<IClientAccessor>();
            _clientController = new ClientController(_accessor, _mapper.Object);

        }

        [Test]
        public void GetClients_ShouldReturnAllClients()
        {
            //arrange
            //var expectedResult = new []
            //{
            //    new ClientSupplierAppModel { ClientID = 1212} 
            //};
            //_accessor.Setup(x => x.GetAllClientsAsync()).Returns(() =>new Task<IEnumerable<ClientSupplierAppModel>>(() => expectedResult));

            //act
            var actualResult = _clientController.GetClientsAsync().Result;

            //assert
            Assert.IsNotNull(actualResult);
            Assert.IsInstanceOf<IEnumerable<ClientSupplierAppModel>>(actualResult);
            Assert.AreEqual(2, actualResult.Count());
        }

        [Test]
        public async Task GetClientReturnsNotfound()
        {
            //arrange
            //_accessor.Setup(x => x.GetClientById(It.IsAny<int>())).Returns(() => null);

            //act
            var actualResult = await _clientController.GetClientAsync(2222);

            //assert
            //Assert.IsNotNull(actualResult);
            Assert.IsInstanceOf<NotFoundResult>(actualResult);
        }

        [Test]
        public void GetClientReturnsClientObject()
        {
            //arrange
            //var expectedResult = new ClientSupplierAppModel { ClientID = 1212};
            //_accessor.Setup(x => x.GetAllClientsAsync()).Returns(
            //    () => new Task<ClientSupplierAppModel>(() => expectedResult));

            ////act
            //var actualResult = _clientController.GetClientAsync(1212).Result as OkNegotiatedContentResult<ClientSupplierAppModel>;

            ////assert
            //Assert.IsNotNull(actualResult);
            //Assert.AreEqual(expectedResult.ClientID, actualResult.Content.ClientID);
        }

    }

    
}
