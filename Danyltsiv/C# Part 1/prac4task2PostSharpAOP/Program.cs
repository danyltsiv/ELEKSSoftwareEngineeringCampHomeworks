using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using PostSharp.Aspects;

namespace prac4task2
{

    [Serializable]
    class LoggingAttribute : OnMethodBoundaryAspect
    {
        public override void OnEntry(MethodExecutionArgs args)
        {
            Console.WriteLine("Pochatok roboti metodu: {0}.", args.Method.Name);
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            Console.WriteLine("Method vikonaniy: {0}.", args.Method.Name);
        }

        public override void OnException(MethodExecutionArgs args)
        {
            Console.WriteLine("Pomilka methody: {0} , {1}: {2}", args.Method.Name,
              args.Exception.GetType().Name, args.Exception.Message);
        }
    }

    class Book
    {
        public string Nazva;
        public List<Client> Pozichalniki = new List<Client>();

        public Book(string title)
        {
            this.Nazva = title;
        }

        [Logging]
        public void DodatiPozichalnika(Client poz)
        {
            this.Pozichalniki.Add(poz);   
        }

        public void PokazatiPozichalnikiv()
        {
            if (this.Pozichalniki.Count != 0)
                foreach (Client cl in this.Pozichalniki)
                    Console.WriteLine(cl.Surname);
        }
    }

    class Client
    {
        public string Surname;
        public Client(string surn)
        {
            this.Surname = surn;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book kniga1 = new Book("11/22/63");
            Client client1 = new Client("Vasia");
            Client client2 = new Client("Ivan");
            Client client3 = new Client("Mykola");
            try
            {
                kniga1.DodatiPozichalnika(client1);
                kniga1.DodatiPozichalnika(client2);
                kniga1.DodatiPozichalnika(client3);
            }
            catch { }
           
            kniga1.PokazatiPozichalnikiv();
            Console.Read();
        }
    }
}
