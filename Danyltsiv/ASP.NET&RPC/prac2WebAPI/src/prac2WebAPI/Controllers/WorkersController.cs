using System;
using System.Collections.Generic;
using System.Linq;
using prac2WebAPI.Models;
using prac2WebAPI.Storage;
using Microsoft.AspNet.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace prac2WebAPI.Controllers
{
    [Route("[controller]")]
    public class WorkersController : Controller
    {
        [HttpGet]
        public IEnumerable<Worker> GetAllWorkers()
        {
            return CompanyWorkers.Workers;
        }
        
        [HttpGet("{id}")]
        public Worker GetWorkerById(int id)
        {
            var worker = CompanyWorkers.Workers.FirstOrDefault(g => g.WorkerId == id);
            return worker;
        }
        
        [HttpPost]
        public void EditWorkerById(int workerId, string surname, string name, int addressId, string phoneNumber,
            string position, int unitId, string head)
        {
            Worker newWorker = new Worker(workerId, surname, name, addressId, phoneNumber, position, unitId, head);
            Worker oldWorker = CompanyWorkers.Workers.FirstOrDefault(p => p.WorkerId == workerId);
            CompanyWorkers.Workers.Remove(oldWorker);
            CompanyWorkers.Workers.Add(newWorker);            
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
