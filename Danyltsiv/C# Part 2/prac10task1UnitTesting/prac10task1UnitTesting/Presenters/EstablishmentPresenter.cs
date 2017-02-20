using System.Linq;
using prac9task1MVC1.Infrastructure;
using prac9task1MVC1.Entities;
using prac9task1MVC1.Contracts.Presenters;
using prac9task1MVC1.Contracts.Views;
using prac9task1MVC1.Contracts.Services;

namespace prac9task1MVC1.Presenters
{
    public class EstablishmentPresenter : PresenterBase<IEstablishmentView, IEstablishmentPresenter>, IEstablishmentPresenter    
    {
        public IEstablishmentStorage _provider { get;  }
        private IEstablishmentEditPresenter _editPresenter;

        public EstablishmentPresenter(IEstablishmentView view, IEstablishmentStorage provider, IEstablishmentEditPresenter 
            editPresenter) : base(view)
        {
            _provider = provider;
            _editPresenter = editPresenter;
            ReInitialize();
        }

        public void EstablishmentsRecalculateRating()
        {
            _provider.RecalculateRating();
            ReInitialize();
        }

        public void AddEstablishment()
        {
            var establishments = _provider.GetAll();
            _provider.Add(new Establishment("Restaurant")
            {
                Address = "Address",
                Opened = false,
                Rating = 1
            });

            ReInitialize();
        }

        public void EditEstablishment()
        {
            var establishment = View.GetSelectedEstablishment();
            if (establishment == null) return;
             
            _editPresenter.Present(establishment);
            ReInitialize();
        }

        public void RemoveEstablishment()
        {
            var removeTarged = View.GetSelectedEstablishment();
            if (removeTarged == null) return;

            _provider.DeleteById(removeTarged.establishmentId);
            ReInitialize();
        }

        public void ToggleEstablishments()
        {
            var establishments = _provider.GetAll();
            _provider.Toggle(establishments.ToList());
            ReInitialize();
        }

        public void RefreshData()
        {
            _provider.Refresh();
            ReInitialize();
        }

        public void Add5RandomEstablishments()
        {
            _provider.Add5Random();
            ReInitialize();
        }

        public void ReInitialize()
        {
            var establishments = _provider.GetAll();
            View.RefreshEstablishments(establishments);
        }
    }
}
