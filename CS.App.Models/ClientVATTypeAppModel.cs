using System.Collections.Generic;

namespace CS.App.Models
{
    public  class ClientVATTypeAppModel
    {
        public ClientVATTypeAppModel()
        {
            this.ClientSuppliers = new HashSet<ClientSupplierAppModel>();
        }

        public byte ClientVATTypeID { get; set; }
        public string ShortName { get; set; }
        public string LongName { get; set; }
        public int? VatRateId { get; set; }
        public decimal DiscountMultiplier { get; set; }
        public byte ClientSupplierType { get; set; }
        public virtual ICollection<ClientSupplierAppModel> ClientSuppliers { get; set; }
        public virtual ClientSupplierTypeAppModel ClientSupplierType1 { get; set; }
    }
}