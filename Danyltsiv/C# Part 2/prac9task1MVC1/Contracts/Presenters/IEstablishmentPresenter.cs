namespace prac9task1MVC1.Contracts.Presenters
{
    public interface IEstablishmentPresenter
    {
        void AddEstablishment();
        void EditEstablishment();
        void RemoveEstablishment();
        void ToggleEstablishments();
        void RefreshData();
        void Add5RandomEstablishments();
        void EstablishmentsRecalculateRating();
    }
}
