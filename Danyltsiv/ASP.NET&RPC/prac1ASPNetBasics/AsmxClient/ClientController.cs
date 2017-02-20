using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AsmxClient.AsmxWorkerService;

namespace AsmxClient
{
    class ClientController
    {
        AsmxWorkerServiceSoapClient client = new AsmxWorkerServiceSoapClient();

        public List<Worker> GetAllWorkers()
        {
            return client.GetAllWorkers().ToList();
        }

        public Worker GetWorkerById(int id)
        {
            return client.GetWorkerById(id);
        }

        public void EditWorkerById(int id, string surname, string name, Address address, string phone,
            string position, int unitId, string head)
        {
            client.EditWorkerById(id,surname,name,address,phone,position,unitId,head);
        }
    }
}
