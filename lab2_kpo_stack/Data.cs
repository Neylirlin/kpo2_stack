using System;
using System.IO;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;


namespace lab2_kpo_stack
{
    public class Data
    {
        public void Serialization(NodeStack<Person> persons)
        {
            int countCheck = 0;
            Person[] people = new Person[persons.Count];
            foreach (Person item in persons)
            {
                people[countCheck] = item;
                countCheck++;
            }

            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Person[]));
            using (FileStream fs = new FileStream("people.json", FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fs, people);
            }
        }
        public void Deserialization(string jsonstr)
        {
            using (FileStream fs = new FileStream(jsonstr, FileMode.OpenOrCreate))
            {
                DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Person[]));
                Person[] newpeople = (Person[])jsonFormatter.ReadObject(fs);
            }
            Console.ReadLine();
        }
    }

    [DataContract]
    public class Person
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
