using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalDataEntitities;
using AnimalData;
using System.ServiceModel;

namespace AnimalDataService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class AnimalDataService : IAnimalDataService, IDisposable
    {
        readonly AnimalDataDbContext _Context = new AnimalDataDbContext(); //maintains the connection

        public string GetAnimal(String animal)
        {

            var foundAnimal = _Context.Animals.Where(a => a.Name == animal).FirstOrDefault();

            return foundAnimal.Name + " from Group: " + foundAnimal.AnimalGroup;
        }

        public List<Animal> GetAnimals()
        {
            return _Context.Animals.ToList();
        }

        [OperationBehavior(TransactionScopeRequired = true)]
        public void AddAnimal(Animal animal)
        {
            _Context.Animals.Add(animal);
            _Context.SaveChanges();
        }
        public void Dispose()
        {
            _Context.Dispose();
        }

    }
}
