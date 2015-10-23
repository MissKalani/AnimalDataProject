using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using AnimalDataEntitities;

namespace WCFPeopleServiceApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PeopleService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PeopleService.svc or PeopleService.svc.cs at the Solution Explorer and start debugging.
    public class PeopleService : IPeopleService
    {
        public void AddAnimal(Animal animal)
        {
            throw new NotImplementedException();
        }

        public Task AddAnimalAsync(Animal animal)
        {
            throw new NotImplementedException();
        }

        public string GetAnimal(string animal)
        {
            Animal foundAnimal = new Animal();
            foundAnimal.Name = animal;
            return foundAnimal.Name;

        }

        public Task<string> GetAnimalAsync(string animal)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Animal> GetAnimals()
        {
            throw new NotImplementedException();
        }

        public Task<ObservableCollection<Animal>> GetAnimalsAsync()
        {
            throw new NotImplementedException();
        }
    }
}