//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Modelo.ProjetoTreinamentoG120.ModelData.Logic.Northwind.MetaData
{
    
    using System; 
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    
    /// <summary>
    /// Orders class MetaData
    /// </summary>
    public partial class OrdersMetaData
    {
        [DisplayName("Order ID")]
        [Required(ErrorMessage = "Order ID is required")]
        public int OrderID { get; set; }
       
        [DisplayName("Customer ID")]
        [MaxLength(5, ErrorMessage = "Customer ID cannot be longer than 5 characters")]
        public string CustomerID { get; set; }
       
        [DisplayName("Employee ID")]
        public Nullable<int> EmployeeID { get; set; }
       
        [DisplayName("Order Date")]
        public Nullable<System.DateTime> OrderDate { get; set; }
       
        [DisplayName("Required Date")]
        public Nullable<System.DateTime> RequiredDate { get; set; }
       
        [DisplayName("Shipped Date")]
        public Nullable<System.DateTime> ShippedDate { get; set; }
       
        [DisplayName("Ship Via")]
        public Nullable<int> ShipVia { get; set; }
       
        [DisplayName("Freight")]
        public Nullable<decimal> Freight { get; set; }
       
        [DisplayName("Ship Name")]
        [MaxLength(40, ErrorMessage = "Ship Name cannot be longer than 40 characters")]
        public string ShipName { get; set; }
       
        [DisplayName("Ship Address")]
        [MaxLength(60, ErrorMessage = "Ship Address cannot be longer than 60 characters")]
        public string ShipAddress { get; set; }
       
        [DisplayName("Ship City")]
        [MaxLength(15, ErrorMessage = "Ship City cannot be longer than 15 characters")]
        public string ShipCity { get; set; }
       
        [DisplayName("Ship Region")]
        [MaxLength(15, ErrorMessage = "Ship Region cannot be longer than 15 characters")]
        public string ShipRegion { get; set; }
       
        [DisplayName("Ship Postal Code")]
        [MaxLength(10, ErrorMessage = "Ship Postal Code cannot be longer than 10 characters")]
        public string ShipPostalCode { get; set; }
       
        [DisplayName("Ship Country")]
        [MaxLength(15, ErrorMessage = "Ship Country cannot be longer than 15 characters")]
        public string ShipCountry { get; set; }
       
    }
}
