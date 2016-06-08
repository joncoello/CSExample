using CS.FakesForTesting;
using NUnit.Framework;

namespace CS.Data.Base.Test
{
    [TestFixture]
    public class UnitOfWorkFixture
    {
        
        [Test]
        public void DefaultConstructorInstantiatesIContext()
        {
            var uow = new UnitOfWork<FakeClientContext>();

            Assert.IsInstanceOf<IContext<FakeClientContext>>(uow.Context);
        }

        [Test]
        public void InstantiatesTestContext()
        {
            var uow = new UnitOfWork<FakeClientContext>(new FakeClientContext());

            Assert.IsInstanceOf<FakeClientContext>(uow.Context);
        }
    }
}
