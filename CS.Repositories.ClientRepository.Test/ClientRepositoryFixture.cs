using System.Linq;
using CS.Data.Base;
using CS.Data.Context;
using CS.Data.Model;
using CS.FakesForTesting;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Threading.Tasks;

namespace CS.Repositories.ClientRepository.Test
{
    [TestFixture]
    public class ClientRepositoryFixture
    {
        private ClientRepository _repository;

        [SetUp]
        public void Init()
        {
            //_repository = new ClientRepository(new UnitOfWork<FakeClientContext>());
        }

        [Test]
        public async Task AllAsync_ShouldReturnAllClients_UsingFakes()
        {
            var context = new FakeClientContext();

            context.ClientSuppliers.Add(new ClientSupplier { ClientID = 1 });
            context.ClientSuppliers.Add(new ClientSupplier { ClientID = 2 });
            context.ClientSuppliers.Add(new ClientSupplier { ClientID = 3 });

            var uow =
                new Mock<IUnitOfWork<ClientContext>>();
            uow.Setup(x => x.Context).Returns(context);

            _repository = new ClientRepository(uow.Object);

            var result = await _repository.AllAsync();

            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count);
            Assert.AreEqual(1, result[0].ClientID);
            Assert.AreEqual(2, result[1].ClientID);
            Assert.AreEqual(3, result[2].ClientID);
        }

        [Test]
        public async Task AllAsync_ShouldReturnAllClients_UsingMoq()
        {

            var data = new List<ClientSupplier>
            {
                new ClientSupplier { ClientID = 1 },
                new ClientSupplier { ClientID = 2 },
                new ClientSupplier { ClientID = 3 }
            }.AsQueryable();

            var mockSet = new Mock<DbSet<ClientSupplier>>();
            mockSet.As<IDbAsyncEnumerable<ClientSupplier>>()
                .Setup(m => m.GetAsyncEnumerator())
                .Returns(new FakeDbAsyncEnumerator<ClientSupplier>(data.GetEnumerator()));

            mockSet.As<IQueryable<ClientSupplier>>()
                .Setup(m => m.Provider)
                .Returns(new FakeDbAsyncQueryProvider<ClientSupplier>(data.Provider));

            mockSet.As<IQueryable<ClientSupplier>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<ClientSupplier>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<ClientSupplier>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<IClientContext<ClientContext>>();
            mockContext.Setup(c => c.ClientSuppliers).Returns(mockSet.Object);

            var uow =
               new Mock<IUnitOfWork<ClientContext>>();
            uow.Setup(x => x.Context).Returns(mockContext.Object);

            _repository = new ClientRepository(uow.Object);

            var result = await _repository.AllAsync();

            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count);
            Assert.AreEqual(1, result[0].ClientID);
            Assert.AreEqual(2, result[1].ClientID);
            Assert.AreEqual(3, result[2].ClientID);
        }
    }

   
}
