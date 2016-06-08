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
            //act
            var actualResult = _clientController.GetClientsAsync().Result.ToList();

            //assert
            Assert.IsNotNull(actualResult);
            Assert.IsInstanceOf<IEnumerable<ClientSupplierAppModel>>(actualResult);
            Assert.AreEqual(2, actualResult.Count());
            Assert.AreEqual(1,actualResult[0].ClientID );
            Assert.AreEqual(2,actualResult[1].ClientID );
            
        }

        [Test]
        public void GetClient_ShouldReturn404Notfound()
        {
            //arrange
            var expectedResult = new ClientSupplierAppModel { ClientID = 1 };

            Mock<IClientAccessor> ac = new Mock<IClientAccessor>();
            ac.Setup(x => x.GetClientById(It.IsAny<int>())).ReturnsAsync(expectedResult);
            //act
            var actualResult = _clientController.GetClientAsync(2222).Result;

            //assert
            Assert.IsNotNull(actualResult);
            Assert.IsInstanceOf<NotFoundResult>(actualResult);
        }

        [Test]
        public async Task GetClient_ShouldReturnClientObject()
        {
            //act
            var actualResult = await _clientController.GetClientAsync(1) 
                as OkNegotiatedContentResult<ClientSupplierAppModel>;

            //assert
            Assert.IsNotNull(actualResult);
            Assert.AreEqual(1, actualResult.Content.ClientID);
        }

    }

    
}
