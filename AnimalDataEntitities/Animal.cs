using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace AnimalDataEntitities
{
    [DataContract]
    public class Animal
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public String Name { get; set; }

        [DataMember]
        public AnimalGroup AnimalGroup { get; set; }

        //[DataMember]
        //public String Group { get; set; }

    }
}
