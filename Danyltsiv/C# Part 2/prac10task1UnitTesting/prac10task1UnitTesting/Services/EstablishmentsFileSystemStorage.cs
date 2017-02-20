using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using prac9task1MVC1.Entities;
using prac9task1MVC1.Contracts.Services;
using prac9task1MVC1.Services;

namespace prac9task1MVC1.Services
{
    public class EstablishmentsFileSystemStorage : IEstablishmentStorage
    {
        private ISerializer _serializer;
        private readonly string _filePath; 

        public EstablishmentsFileSystemStorage(ISerializer serializer)
        {
            _filePath = AppSettings.Instance.EstablishmentFilePath;
            _serializer = serializer;
            Initialize();
        }

        public void RecalculateRating()
        {
            Random rnd = new Random();
            var establishments = GetAll().ToList();
            foreach (var est in establishments)
                est.Rating = rnd.Next(1, 4);
            SaveChanges(establishments);
        }

        public void Add5Random()
        {
            Random rnd = new Random();
            for(int i = 0; i < 5; i++)
            {
                Add(new Establishment {
                    Name = "Restaurant",
                    Address = "Address",
                    Rating = rnd.Next(1,4),
                    Opened = Convert.ToBoolean(rnd.Next(0,2))
                });
            }
        }

        public void Add(Establishment establishment)
        {
            var establishments = GetAll().ToList();
            establishment.establishmentId = establishments.Select(p => p.establishmentId).Max() + 1;
            establishments.Add(establishment);
            SaveChanges(establishments); 
        }
        
        public void Toggle(List<Establishment> establishments)
        {   foreach(var est in establishments)
            est.Toggle();
            SaveChanges(establishments);
        }

        public void Edit(Establishment establishment)
        {
            var establishments = GetAll().ToList();

            if (establishment.Address == "" || establishment.Address == "" ||
                establishment.Name == "" || establishment.Rating.ToString() == "")
            {
                throw new Exception("Fill in all fields!");
            }
            //else if (establishments.Any(t => t.Name == establishment.Name))
            //{
            //    throw new Exception("That establishment is already exists");
            //}

            var editTarget = establishments.FirstOrDefault(t => t.establishmentId == establishment.establishmentId);
            if (editTarget == null)
            {
                return;
            }
            establishments.Remove(editTarget);
            establishments.Add(establishment);
            SaveChanges(establishments);
        }

        public void DeleteById(int id)
        {
            var establishments = GetAll().ToList();
            var removeTarget = establishments.FirstOrDefault(t => t.establishmentId == id);
            if (removeTarget == null)
            {
                return;
            }
            establishments.Remove(removeTarget);
            SaveChanges(establishments);
        }

        public Establishment Get(int id)
        {
            var establishments = GetAll().ToList();
            var Target = establishments.FirstOrDefault(t => t.establishmentId == id);
            return Target;
        }
        public void Refresh()
        {
            var establishments = GetAll().ToList();
            SaveChanges(establishments);
        }

        public IEnumerable<Establishment> GetAll()
        {
            var establishments = _serializer.Deserialize<List<Establishment>>(_filePath);
            return establishments;
        }

        private void Initialize()
        {
            if (File.Exists(_filePath))
            {
                return;
            }
            var establishments = new List<Establishment>
            {
                new Establishment("Restaurant")
                {
                    Address ="Address",
                    Opened = false,
                    Rating = 1
                }
            };
            SaveChanges(establishments);
        }

        private void SaveChanges(IEnumerable<Establishment> establishments)
        {
            var serialized = _serializer.Serialize(establishments.ToList());
            File.WriteAllText(_filePath, serialized);
        }
    } 
}
