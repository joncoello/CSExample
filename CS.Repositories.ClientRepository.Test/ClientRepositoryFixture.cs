using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using CS.Data.Base;
using CS.Data.Context;
using CS.Data.Model;
using CS.FakesForTesting;
using Moq;
using NUnit.Framework;

namespace CS.Repositories.ClientRepository.Test
{
    [TestFixture]
    public class ClientRepositoryFixture
    {
        //private ClientRepository _repository;

        //[SetUp]
        //public void Init()
        //{
        //    //_repository = new ClientRepository(new UnitOfWork<FakeClientContext>());
        //}

        //[Test]
        //public void AllAsyncShouldReturnAllClients()
        //{
        //    #region comment
        //    //var data = new List<ClientSupplier>
        //    // {
        //    //     new ClientSupplier { ClientID = 1,},
        //    //     new ClientSupplier { ClientID = 2 },
        //    //     new ClientSupplier { ClientID = 3 }
        //    // }.AsQueryable();

        //    //Mock<IDbSet<ClientSupplier>> dbset = new Mock<IDbSet<ClientSupplier>>();

        //    //dbset.Setup(m => m.Provider).Returns(data.Provider);
        //    //dbset.Setup(m => m.Expression).Returns(data.Expression);
        //    //dbset.Setup(m => m.ElementType).Returns(data.ElementType);
        //    //dbset.Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());


        //    //Mock<IClientContext<ClientContext>> context = new Mock<IClientContext<ClientContext>>();
        //    //context.Setup(x => x.ClientSuppliers).Returns(dbset.Object);
        //    #endregion


        //    var fake = new FakeClientContext();
        //    //fake.ClientSuppliers = dbset.Object;
        //    fake.ClientSuppliers.Add(new ClientSupplier { ClientID = 1212 });

        //    Mock<IUnitOfWork<ClientContext>> uow = new Mock<IUnitOfWork<ClientContext>>();
        //    uow.Setup(x => x.Context).Returns(fake);

        //    //_repository = new ClientRepository(new UnitOfWork<ClientContext>(context.Object));
        //    _repository = new ClientRepository(uow.Object);

        //    var result = _repository.AllAsync().Result.ToList();

        //    //Mock<IClientContext<>> fakedbMock = new Mock<IClientContext>();
        //    //fakedbMock.Setup(x => x.ClientSuppliers).Returns(() => new FakeDbset())
            
        //    Assert.IsNotNull(result);
        //    Assert.AreEqual(1, result.Count);
        //}
    }

    //class FakeDbset : IDbSet<ClientSupplier>
    //{
    //    public IEnumerator<ClientSupplier> GetEnumerator()
    //    {
    //        throw new System.NotImplementedException();
    //    }

    //    IEnumerator IEnumerable.GetEnumerator()
    //    {
    //        throw new System.NotImplementedException();
    //    }

    //    public Expression Expression { get; }
    //    public Type ElementType { get; }
    //    public IQueryProvider Provider { get; }
    //    public ClientSupplier Find(params object[] keyValues)
    //    {
    //        throw new System.NotImplementedException();
    //    }

    //    public ClientSupplier Add(ClientSupplier entity)
    //    {
    //        throw new System.NotImplementedException();
    //    }

    //    public ClientSupplier Remove(ClientSupplier entity)
    //    {
    //        throw new System.NotImplementedException();
    //    }

    //    public ClientSupplier Attach(ClientSupplier entity)
    //    {
    //        throw new System.NotImplementedException();
    //    }

    //    public ClientSupplier Create()
    //    {
    //        throw new System.NotImplementedException();
    //    }

    //    public TDerivedEntity Create<TDerivedEntity>() where TDerivedEntity : class, ClientSupplier
    //    {
    //        throw new System.NotImplementedException();
    //    }

    //    public ObservableCollection<> Local { get; }

    //    ObservableCollection<ClientSupplier> IDbSet<ClientSupplier>.Local
    //    {
    //        get
    //        {
    //            throw new NotImplementedException();
    //        }
    //    }
    //}
}
