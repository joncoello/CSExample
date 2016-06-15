using System.Linq;
using CS.Data.Model;

namespace CS.FakesForTesting
{
    public class FakeClientDbSet : FakeDbSet<ClientSupplier>
    {
        public override ClientSupplier Find(params object[] keyValues)
        {
            var keyValue = keyValues.FirstOrDefault() ?? 0;
            return this.FirstOrDefault(x => x.ClientID == (int)keyValue);
        }
    }
}