using System;

namespace OOP_as_it_should_be_in_CS_by_Programming_Advices._1_concepts._1_8_constructor_and_destructor._1_8_6_multiple_constructors_using_overlaoding;

public class MultipleConstructorsUsingOverloading {
    class Person {
        public int id {
            set;
            get;
        }

        public string name {
            set;
            get;
        }

        public byte age {
            set;
            get;
        }

        public Person() {
            id   = -1;
            name = "";
            age  = 0;
        }

        public Person(
            int    id,
            string name,
            byte   age
        ) {
            this.id   = id;
            this.name = name;
            this.age  = age;
        }
    }

    public static void Main(
        string[] args
    ) {
        Person person = new Person();

        Console.WriteLine(
            "Person Information:\nID: {0}\nName: {1}\nAge: {2}\n",
            person.id,
            person.name,
            person.age
        );

        person = new Person(
            1,
            "Mohamed Sadawy",
            22
        );

        Console.Write(
            "Person Information:\nID: {0}\nName: {1}\nAge: {2}",
            person.id,
            person.name,
            person.age
        );
    }
}