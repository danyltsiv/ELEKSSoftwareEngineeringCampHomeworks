using prac9task1MVC1.Infrastructure;
using prac9task1MVC1.Entities;
using prac9task1MVC1.Contracts.Presenters;
using prac9task1MVC1.Contracts.Views;
using prac9task1MVC1.Contracts.Services;

namespace prac9task1MVC1.Presenters
{
    public class EstablishmentEditPresenter: PresenterBase<IEstablishmentEditView, IEstablishmentEditPresenter>,
         IEstablishmentEditPresenter
    {
        private IEstablishmentStorage _storage;
        private Establishment editedEstablishment;

        public EstablishmentEditPresenter(IEstablishmentEditView view, IEstablishmentStorage storage) : base(view)
        {
            _storage = storage; 
        }

        public void CancelEditing()
        {
            View.CloseView();
        }

        public void Present(Establishment establishment)
        {
            editedEstablishment = establishment;
            View.SetEditedEstablishment(establishment);
            View.ShowView();
        }

        public void SaveEstablishment()
        {
            var establishment = View.GetEstablishment();
            establishment.establishmentId = editedEstablishment.establishmentId;
            _storage.Edit(establishment);
            View.CloseView();
        }
    }
}
