using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac6task1
{
    static class EstablishmentsData
    {
        static public List<IPublicEstablishment> Establisments = new List<IPublicEstablishment>
        {
            new Restaurant("Rutka","Vovchynetska street",false,1),
            new Restaurant("Bogatir","Banderi street",true,3),
            new Restaurant("Vasyl","Ivasyuka street",true,2),
            new Restaurant("Timkiv","Shevchenka street",false,2),
            new Restaurant("Manufactura","Konovalcia street",true,1),
            new Restaurant("Fabrica","Petlyuri street",false,3),
            new Restaurant("Trembita","Chornovola street",true,2),
            new Restaurant("Visag","Belvederska street",false,1),
            new Restaurant("Marmeladka","Franka street",false,3),
            new Restaurant("Baraban","Sosyuri street",true,3),
            new Bar("Koroleva","Vovchynetska street",false,2),
            new Bar("Epicenter","Banderi street",true,1),
            new Bar("U Olgi","Ivasyuka street",true,2),
            new Bar("Varenik","Shevchenka street",false,5),
            new Bar("Kafe","Konovalcia street",true,3),
            new Bar("Sil","Petlyuri street",false,5),
            new Bar("Konik","Chornovola street",true,2),
            new Bar("Mirage","Belvederska street",false,4),
            new Bar("Chubaka","Franka street",false,4),
            new Bar("Han Solo","Sosyuri street",true,2)
        };


        static public List<IPublicEstablishment> getEstablishments()
        {          
            return Establisments;
        }

        static public List<Restaurant> getRestaurants()
        {
            List<Restaurant> temp = new List<Restaurant>();
            foreach (var est in Establisments)
                if (est.GetType() == typeof(Restaurant))
                    temp.Add(est as Restaurant);
            return temp;
        }

        static public List<Bar> getBars()
        {
            List<Bar> temp = new List<Bar>();
            foreach (var est in Establisments)
                if (est.GetType() == typeof(Bar))
                    temp.Add(est as Bar);
            return temp;
        }
    }
}
