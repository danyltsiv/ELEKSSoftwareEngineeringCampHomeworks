using prac1ASPNetBasics.Data;
using prac1ASPNetBasics.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace prac1ASPNetBasics
{
    /// <summary>
    /// Summary description for WorkerService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class    AsmxWorkerService : System.Web.Services.WebService
    {
        [WebMethod]
        public List<Worker> GetAllWorkers()
        {
            return CompanyWorkers.Workers;
        }

        [WebMethod]
        public Worker GetWorkerById(int id)
        {
            Worker worker = CompanyWorkers.Workers.FirstOrDefault(p => p.WorkerId == id);
            return worker;
        }

        [WebMethod]
        public void EditWorkerById(int id, string surname, string name, int addressId, string phone,
            string position, int unitId, string head)
        {
            Worker newWorker = new Worker(id, surname, name, addressId, phone, position, unitId, head);
            Worker oldWorker = CompanyWorkers.Workers.FirstOrDefault(p => p.WorkerId == id);
            CompanyWorkers.Workers.Remove(oldWorker);
            CompanyWorkers.Workers.Add(newWorker);
        }
    }
}
