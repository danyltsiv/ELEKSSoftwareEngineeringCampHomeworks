using System;
using System.Collections.Generic;
using prac9task1MVC1.Entities;

namespace prac9task1MVC1.Contracts.Services
{
    public interface IEstablishmentStorage
    {
        IEnumerable<Establishment> GetAll();
        Establishment Get(int id);
        void Add(Establishment establishment);
        void Edit(Establishment establishment);
        void DeleteById(int id);
        void Toggle(List<Establishment> establishments);
        void Refresh();
        void Add5Random();
        void RecalculateRating();
    }
}
