using System;

namespace OOP_as_it_should_be_in_CS_by_Programming_Advices._1_concepts._1_8_constructor_and_destructor._1_8_2_parameterless_constructor;

public class ParameterlessConstructor {
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
    }

    public static void main(
        string[] args
    ) {
        Person person = new Person();
        Console.Write(
            "Person Information:\nID: {0}\nName: {1}\nAge: {2}",
            person.id,
            person.name,
            person.age
        );
    }
}