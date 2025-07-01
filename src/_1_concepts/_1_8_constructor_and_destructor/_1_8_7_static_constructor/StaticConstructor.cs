using System;

namespace OOP_as_it_should_be_in_CS_by_Programming_Advices._1_concepts._1_8_constructor_and_destructor._1_8_7_static_constructor;

public class StaticConstructor {
    class Person {
        public static int id {
            set;
            get;
        }

        public static string name {
            set;
            get;
        }

        public static byte age {
            set;
            get;
        }

        // Static Constructor will be called once during the program, and must be parameterless
        static Person() {
            id   = -1;
            name = "";
            age  = 0;
        }
    }

    public static void Main(
        string[] args
    ) {
        Console.Write(
            "Person Information:\nID: {0}\nName: {1}\nAge: {2}",
            Person.id,
            Person.name,
            Person.age
        );
    }
}