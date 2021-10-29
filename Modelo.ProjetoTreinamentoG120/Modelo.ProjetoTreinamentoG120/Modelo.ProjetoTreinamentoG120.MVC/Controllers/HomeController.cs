using Modelo.ProjetoTreinamentoG120.MVC.Architecture;
using Modelo.ProjetoTreinamentoG120.MVC.Architecture.Enuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Modelo.ProjetoTreinamentoG120.MVC.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            this.EmitirMensagem("Teste de Mensagem", ETipoMensagem.Sucesso);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}