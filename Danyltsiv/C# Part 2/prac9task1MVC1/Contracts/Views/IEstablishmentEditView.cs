using prac9task1MVC1.Entities;
using prac9task1MVC1.Infrastructure;
using prac9task1MVC1.Contracts.Presenters;

namespace prac9task1MVC1.Contracts.Views
{
    public interface IEstablishmentEditView : IView<IEstablishmentEditPresenter>
    {
        void SetEditedEstablishment(Establishment establishment);
        Establishment GetEstablishment();

    }
}
