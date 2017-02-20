namespace prac9task1MVC1.Infrastructure
{
    public abstract class PresenterBase<TView, TPresenter>
        where TView : IView<TPresenter>
        where TPresenter : class
    {
        public TView View { get; set; }

        protected PresenterBase(TView view)
        {
            View = view;
            View.Presenter = this as TPresenter;
        }
    }
}
