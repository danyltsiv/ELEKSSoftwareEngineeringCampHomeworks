using System.Collections.Generic;
using prac9task1MVC1.Entities;
using prac9task1MVC1.Infrastructure;
using prac9task1MVC1.Contracts.Presenters;
namespace prac9task1MVC1.Contracts.Views
{
    public interface IEstablishmentView : IView<IEstablishmentPresenter>
    {
        void RefreshEstablishments(IEnumerable<Establishment> establishments);
        Establishment GetSelectedEstablishment();
    }
}
