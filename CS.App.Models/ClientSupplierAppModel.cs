using System;
using System.Collections.Generic;

namespace CS.App.Models
{
    public class ClientSupplierAppModel
    {
        public ClientSupplierAppModel()
        {
            //this.ClientSupplier1 = new HashSet<ClientSupplierAppModel>();
        }

        public int ClientID { get; set; }
        public int ContactID { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int? ParentClientID { get; set; }
        public double DefaultRecoveryRate { get; set; }
        public string Notes { get; set; }
        public int OfficeID { get; set; }
        public int DepartmentID { get; set; }
        public string ClientCode { get; set; }
        public DateTime? PeriodEndDate { get; set; }
        public bool Vattable { get; set; }
        public int CliFileID { get; set; }
        public bool Internal { get; set; }
        public byte ClientVATTypeID { get; set; }
        public int? ZID { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public int? DefaultCurrency { get; set; }
        public byte ClientSupplierType { get; set; }
        public byte? TermsTypeID { get; set; }
        public short? TermsDay { get; set; }
        public short? PaymentTypeID { get; set; }
        public decimal? CreditLimit { get; set; }
        public short? DefaultNominalID { get; set; }
        public short? AccountStatusID { get; set; }
        public string BankAccountName { get; set; }
        public string BankAccountNum { get; set; }
        public string BankSortCode { get; set; }
        public string BACSRef { get; set; }
        public int? ApprovalEmpID { get; set; }
        public int? DefaultContactAssoc { get; set; }
        public DateTime? Closed { get; set; }
        public string CompanyRegistrationNo { get; set; }
        public string CompanyTaxReference { get; set; }
        public System.Guid RowGuid { get; set; }
        public int? ClientClosedReasonId { get; set; }
        public bool Draft { get; set; }
        public int? ApprovedBy { get; set; }
        public int? ReasonWonId { get; set; }
        //public  ClientVATType ClientVATType { get; set; }
        //public  ClientSupplierType ClientSupplierType1 { get; set; }
        //public  ICollection<ClientSupplierAppModel> ClientSupplier1 { get; set; }
        //public  ClientSupplierAppModel ClientSupplier2 { get; set; }
    }
}