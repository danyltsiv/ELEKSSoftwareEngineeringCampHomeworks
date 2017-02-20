using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace prac7task1
{
    static class RefreshEstablishmentsData
    {
        static public Timer Timer = new Timer(10000);

        static public void Show(List<IPublicEstablishment> list)
        {
            foreach (var rest in list)
                Console.WriteLine(rest);
        }

        static public void Refresh(List<IPublicEstablishment> list)
        {
            Show(list);
            Calculator.showTopRestaurants();
            Calculator.showTopBars();
            Timer.Elapsed += (sender, args) =>
            {
                Console.Clear();
                Show(list);
                Calculator.showTopRestaurants();
                Calculator.showTopBars();                              
            };
            Timer.Start();
            Timer.AutoReset = true;
        } 
    }
}
