using AnimalDataEntitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace AnimalDataService
{
    [ServiceContract]
    public interface IAnimalDataService
    {
        [OperationContract]
        String GetAnimal(String animal);
        [OperationContract]
        List<Animal> GetAnimals();
        [OperationContract]
        void AddAnimal(Animal animal);
    }
}
