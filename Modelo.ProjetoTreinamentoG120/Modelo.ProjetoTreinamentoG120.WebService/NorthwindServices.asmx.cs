using Modelo.ProjetoTreinamentoG120.ModelData.Logic.Northwind.Model;
using Modelo.ProjetoTreinamentoG120.WebService.Logic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Modelo.ProjetoTreinamentoG120.WebService
{
    /// <summary>
    /// Summary description for NorthwindServices
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class NorthwindServices : System.Web.Services.WebService
    {

        private readonly NorthwindEntities contexto;
        private readonly EmployeesController employeesController;
        public NorthwindServices()
        {
            contexto = new NorthwindEntities();
            employeesController = new EmployeesController(contexto);

        }
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }


        [WebMethod]
        public EmployeesDTO ObterEmployeesPorId(int id)
        {
            var Employees = employeesController.Obter(id);
            EmployeesDTO employeesDTO = new EmployeesDTO()
            {
                EmployeeID = Employees.EmployeeID,
                FirstName = Employees.FirstName,
                LastName = Employees.LastName,
                Address = Employees.Address,
                BirthDate = Employees.BirthDate,
                Title = Employees.Title,
                TitleOfCourtesy = Employees.TitleOfCourtesy,
                City = Employees.City,
                Region = Employees.Region,
                PostalCode = Employees.PostalCode,
                Country = Employees.Country,
                HomePhone = Employees.HomePhone,
            };
            return employeesDTO;
        }

    }
}