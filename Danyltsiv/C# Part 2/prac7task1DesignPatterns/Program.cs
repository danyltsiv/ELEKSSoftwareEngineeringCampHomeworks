using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
namespace prac7task1
{
    class Program
    {
    static void Main(string[] args)
        {
            EstablishmentsData.AddRestaurant(new Restaurant("Noviy", "Nova street", true, 3));
            EstablishmentsData.AddRestaurant(new Restaurant("Noviy2", "Nova street2", false, 2));
            EstablishmentsData.AddRestaurant(new Restaurant("Noviy3", "Nova street3", true, 1));
            EstablishmentsData.AddRestaurant(new Restaurant("Noviy4", "Nova street4", true, 3));
            EstablishmentsData.AddRestaurant(new Restaurant("Noviy5", "Nova street5", false, 2));
            EstablishmentsData.AddRestaurant(new Restaurant("Noviy6", "Nova street6", true, 3));
            EstablishmentsData.AddRestaurant(new Restaurant("Noviy7", "Nova street7", true, 1));
            EstablishmentsData.AddRestaurant(new Restaurant("Noviy8", "Nova street8", false, 1));
            EstablishmentsData.AddRestaurant(new Restaurant("Noviy9", "Nova street9", true, 2));
            EstablishmentsData.AddRestaurant(new Restaurant("Noviy10", "Nova street10", true, 2));
            RefreshEstablishmentsData.Refresh(EstablishmentsData.getEstablishments());
            Calculator.UpdateRating();

            Timer timer = new Timer(1000);
            timer.Elapsed += (sender, argums) =>
              {
                  foreach (var rest in EstablishmentsData.getEstablishments())
                      rest.Toggle();
              };
            timer.Start();
            timer.AutoReset = true;

            var myClone = Calculator.RandRestClone(EstablishmentsData.getRestaurants());
            Console.WriteLine("\n"+myClone);
            Console.ReadKey();
        }
    }
}
