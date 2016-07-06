using System.Collections.Generic;

namespace CS.App.Models
{
    public  class ClientSupplierTypeAppModel
    {
        public ClientSupplierTypeAppModel()
        {
            this.ClientSuppliers = new HashSet<ClientSupplierAppModel>();
            this.ClientVATTypes = new HashSet<ClientVATTypeAppModel>();
        }

        public byte ClientSupplierTypeID { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ClientSupplierAppModel> ClientSuppliers { get; set; }
        public virtual ICollection<ClientVATTypeAppModel> ClientVATTypes { get; set; }
    }
}