using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
namespace prac6task1
{
    class Program
    {
        static void Main(string[] args)
        {
            RefreshEstablishmentsData.Refresh(EstablishmentsData.getEstablishments());

            Timer timer = new Timer(1000);
            timer.Elapsed += (sender, argums) =>
              {
                  foreach (var rest in EstablishmentsData.getEstablishments())
                      rest.Toggle();
              };
            timer.Start();
            timer.AutoReset = true;

            Console.ReadKey();
        }
    }
}
