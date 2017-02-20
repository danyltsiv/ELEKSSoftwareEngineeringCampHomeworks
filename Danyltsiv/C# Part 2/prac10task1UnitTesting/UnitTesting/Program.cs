using prac9task1MVC1.Contracts.Presenters;
using prac9task1MVC1.Contracts.Views;
using prac9task1MVC1.Infrastructure;
using prac9task1MVC1.Presenters;
using System.Linq;
using prac9task1MVC1.Entities;
using prac9task1MVC1;
using prac9task1MVC1.Services;
using NUnit.Framework;
using prac9task1MVC1.Contracts.Services;

namespace UnitTesting
{
    [TestFixture]
    class Program
    {
        [Test]
        public static void IsAddWorks()
        {
            var presenter = ServiceLocator.Instance.Resolve<EstablishmentPresenter>();
            var establishments = presenter._provider.GetAll();
            var countBefore = establishments.Count();
            presenter._provider.Add(new Establishment
            {
                Name = "TestAdd",
                Address = "adr",
                Opened = true,
                Rating = 3
            });
            var countAfter = presenter._provider.GetAll().Count();
            Assert.That(countAfter == (countBefore + 1));            
        }

        [Test]
        public static void IsEditWorks()
        {
            var presenter = ServiceLocator.Instance.Resolve<EstablishmentPresenter>();
            var establishments = presenter._provider.GetAll();
            var id = establishments.Select(g => g.establishmentId).Max();
            var OpenedBefore = !establishments.FirstOrDefault(g => g.establishmentId == id).Opened;
            presenter._provider.Edit(new Establishment
            {
                establishmentId = id,
                Name = "editing1",
                Rating = 3,
                Address = "editingAddr",
                Opened = OpenedBefore
            });
            var OpenedAfter = establishments.FirstOrDefault(g => g.establishmentId == id).Opened;
            Assert.That(OpenedBefore == !OpenedAfter);
        }

        [Test]
        public static void IsDeleteByIdWorks()
        {
            var presenter = ServiceLocator.Instance.Resolve<EstablishmentPresenter>();
            var establishments = presenter._provider.GetAll();
            var countBefore = establishments.Count();
            var id = establishments.Select(g => g.establishmentId).Max();
            presenter._provider.DeleteById(id);
            var countAfter = presenter._provider.GetAll().Count();
            Assert.That(countAfter == (countBefore - 1));
        }

        [Test]
        public void IsOpenWorks()
        {
            var est = new Establishment("est", "adr", false, 3);
            est.Open();
            Assert.That(est.Opened == true);    
        }
        
        [Test]
        public void IsCloseWorks()
        {
            var est = new Establishment("est", "adr", true, 3);
            est.Close();
            Assert.That(est.Opened == false);
        }

        static void Main(string[] args)
        {
            IsEditWorks();
        }
    }
}
