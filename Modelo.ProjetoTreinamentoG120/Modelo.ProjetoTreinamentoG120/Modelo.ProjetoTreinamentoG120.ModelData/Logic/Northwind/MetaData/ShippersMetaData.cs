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
    /// Shippers class MetaData
    /// </summary>
    public partial class ShippersMetaData
    {
        [DisplayName("Shipper ID")]
        [Required(ErrorMessage = "Shipper ID is required")]
        public int ShipperID { get; set; }
       
        [DisplayName("Company Name")]
        [Required(ErrorMessage = "Company Name is required")]
        [MaxLength(40, ErrorMessage = "Company Name cannot be longer than 40 characters")]
        public string CompanyName { get; set; }
       
        [DisplayName("Phone")]
        [MaxLength(24, ErrorMessage = "Phone cannot be longer than 24 characters")]
        public string Phone { get; set; }
       
    }
}
