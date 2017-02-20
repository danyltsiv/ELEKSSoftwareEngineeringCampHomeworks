namespace prac9task1MVC1.Infrastructure
{
    public interface IView<TPresenter>
    {
        TPresenter Presenter { get; set; }

        void ShowView();
        void CloseView();
    }
}
