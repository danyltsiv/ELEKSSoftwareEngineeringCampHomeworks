using prac9task1MVC1.Contracts.Services;
using prac9task1MVC1.Contracts.Presenters;
using prac9task1MVC1.Contracts.Views;
using prac9task1MVC1.Services;
using prac9task1MVC1.Presenters;
using Microsoft.Practices.Unity;

namespace prac9task1MVC1
{
    public class ServiceLocator
    {
        private IUnityContainer _container;

        private static ServiceLocator _instance;

        public static ServiceLocator Instance
        {
            get
            {
                return _instance ?? (_instance = new ServiceLocator());
            }
        }

        private ServiceLocator()
        {
            _container = new UnityContainer();
            InitializeServices(_container);
            InitializeViews(_container);
        }

        public T Resolve<T>()
        {
            return _container.Resolve<T>();
        }

        private void InitializeServices(IUnityContainer container)
        {
            container.RegisterType<ISerializer, Serializer>(new ContainerControlledLifetimeManager());
            container.RegisterType<IEstablishmentStorage, EstablishmentsFileSystemStorage>();
        }

        private void InitializeViews(IUnityContainer container)
        {
            container.RegisterType<IEstablishmentPresenter, EstablishmentPresenter>();
            container.RegisterType<IEstablishmentEditPresenter, EstablishmentEditPresenter>();

            container.RegisterType<IEstablishmentView, EstablishmentsView>();
            container.RegisterType<IEstablishmentEditView, EstablishmentEditView>();
        }
    }
}
