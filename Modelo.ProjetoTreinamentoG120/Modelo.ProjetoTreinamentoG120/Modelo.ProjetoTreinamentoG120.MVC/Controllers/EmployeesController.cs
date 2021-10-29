using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Modelo.ProjetoTreinamentoG120.Business.Logic.Northwind;
using Modelo.ProjetoTreinamentoG120.ModelData.Logic.Northwind.Model;
using Modelo.ProjetoTreinamentoG120.MVC.Architecture;
using Modelo.ProjetoTreinamentoG120.MVC.Architecture.Enuns;

namespace Modelo.ProjetoTreinamentoG120.MVC.Controllers
{
    public class EmployeesController : BaseController
    {
        private NorthwindEntities db = new NorthwindEntities();

        // GET: Employees
        public ActionResult Index()
        {
            this.EmitirMensagem("Teste de Mensagem", ETipoMensagem.Sucesso);
            var employees = db.Employees.Include(e => e.Employees2);
            return View(employees.ToList());
        }

        // GET: Employees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employees employees = db.Employees.Find(id);
            if (employees == null)
            {
                return HttpNotFound();
            }
            return View(employees);
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            ViewBag.ReportsTo = new SelectList(db.Employees, "EmployeeID", "LastName");
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EmployeeID,LastName,FirstName,Title,TitleOfCourtesy,BirthDate,HireDate,Address,City,Region,PostalCode,Country,HomePhone,Extension,Photo,Notes,ReportsTo,PhotoPath")] Employees employees)
        {
            if (ModelState.IsValid)
            {
                var validarRegra = new RV_EmployeesBusiness(db, employees);
                if (!validarRegra.Consistir())
                {

                    foreach (var item in validarRegra.Mensagens)
                    {
                        mensagens.Add(item.Message);
                    }

                    this.EmitirMensagem(mensagens, ETipoMensagem.Erro);
                }
                else
                {
                    db.Entry(employees).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    this.EmitirMensagem("Alteração realizada com sucesso.", ETipoMensagem.Sucesso);
                    return RedirectToAction("Index");
                }
            }

            ViewBag.ReportsTo = new SelectList(db.Employees, "EmployeeID", "LastName", employees.ReportsTo);
            return View(employees);
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employees employees = db.Employees.Find(id);
            if (employees == null)
            {
                return HttpNotFound();
            }
            ViewBag.ReportsTo = new SelectList(db.Employees, "EmployeeID", "LastName", employees.ReportsTo);
            return View(employees);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EmployeeID,LastName,FirstName,Title,TitleOfCourtesy,BirthDate,HireDate,Address,City,Region,PostalCode,Country,HomePhone,Extension,Photo,Notes,ReportsTo,PhotoPath")] Employees employees)
        {
            if (ModelState.IsValid)
            {
                var validarRegra = new RV_EmployeesBusiness(db, employees);
                if (!validarRegra.Consistir())
                {

                    foreach (var item in validarRegra.Mensagens)
                    {
                        mensagens.Add(item.Message);
                    }

                    this.EmitirMensagem(mensagens, ETipoMensagem.Erro);
                }
                else
                {
                    db.Entry(employees).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    this.EmitirMensagem("Alteração realizada com sucesso.", ETipoMensagem.Sucesso);
                    return RedirectToAction("Index");
                }
            }
            ViewBag.ReportsTo = new SelectList(db.Employees, "EmployeeID", "LastName", employees.ReportsTo);
            return View(employees);
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employees employees = db.Employees.Find(id);
            if (employees == null)
            {
                return HttpNotFound();
            }
            return View(employees);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employees employees = db.Employees.Find(id);
            db.Employees.Remove(employees);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
