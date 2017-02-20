using System;
using prac1ASPNetBasics.Entities;
using prac1ASPNetBasics.Data;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfWorkerService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public List<Worker> GetAllWorkers()
        {
            return CompanyWorkers.Workers;
        }
        
        public Worker GetWorkerById(int id)
        {
            Worker worker = CompanyWorkers.Workers.FirstOrDefault(p => p.WorkerId == id);
            return worker;
        }
        
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
