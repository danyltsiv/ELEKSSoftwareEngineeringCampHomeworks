using System;
using System.Windows.Forms;
using prac9task1MVC1.Contracts.Presenters;
using prac9task1MVC1.Contracts.Views;
using prac9task1MVC1.Infrastructure;



namespace prac9task1MVC1
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var presenter = ServiceLocator.Instance.Resolve<IEstablishmentPresenter>();
            var establishmentsPresenter = presenter as PresenterBase<IEstablishmentView, IEstablishmentPresenter>;
            var view = establishmentsPresenter.View as Form;
            
            Application.Run(view);
        }
    }
}
