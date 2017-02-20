using prac9task1MVC1.Entities;

namespace prac9task1MVC1.Contracts.Presenters
{
    public interface IEstablishmentEditPresenter
    {
        void Present(Establishment establishment);
        void SaveEstablishment();
        void CancelEditing();
    }
}
