using Modelo.ProjetoTreinamentoG120.DataApplicator.Logic.Northwind;
using Modelo.ProjetoTreinamentoG120.ModelData.Logic.Northwind.Model;
using SGI.Windows.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Modelo.ProjetoTreinamentoG120.WebService.Logic.Model
{
    public class EmployeesController : ControllerDataApplicator<EmployeesDataApplicator, NorthwindEntities>
    {
        public EmployeesController(NorthwindEntities contexto)
            : base(contexto)
        { }

        public Employees Obter(int id)
        {
            return this.DataApplicator.ConsultarTodos().Where(x => x.EmployeeID == id).FirstOrDefault();
        }
    }
}