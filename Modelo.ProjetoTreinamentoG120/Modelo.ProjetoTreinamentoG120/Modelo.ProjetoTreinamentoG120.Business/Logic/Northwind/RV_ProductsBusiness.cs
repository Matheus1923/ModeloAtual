//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Modelo.ProjetoTreinamentoG120.Business.Logic.Northwind
{
    
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.ComponentModel;
    using SGI.Common.BusinessContractor.Rules;
    using SGI.Common.BusinessContractor.Base;
    using Modelo.ProjetoTreinamentoG120.ModelData.Logic.Northwind.Model;
    
    /// <summary>
    /// RV_ProductsBusiness class Business
    /// </summary>
    [RegraAtiva(true)]
    public class RV_ProductsBusiness : GenericRuleEF<NorthwindEntities , Products>
    {
    
    	public RV_ProductsBusiness(NorthwindEntities contexto, Products instancia)
            : base(contexto, instancia)
       	    {
            }
    
            /// <summary>
            /// Executa a validação da regra
            /// </summary>
            public override bool Consistir()
            {
                try
                {
                    // Todo Regra
    
                    //if (instancia??)
                    //{
                    //    Mensagens.Add(new RulesMessage(000, "RV_Modelo_01Business", "VALOR INVALIDO!"));
                    //    return false;
                   //}
    
                    return true;
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
    
    }
}
