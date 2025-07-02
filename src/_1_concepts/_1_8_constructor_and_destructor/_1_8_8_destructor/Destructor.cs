using System;

namespace OOP_as_it_should_be_in_CS_by_Programming_Advices._1_concepts._1_8_constructor_and_destructor._1_8_8_destructor;

public class Destructor {
    class ClassExample {
        public ClassExample() {
            Console.WriteLine(
                "This is Constructor!"
            );
        }

        ~ClassExample() {
            Console.WriteLine(
                "This is Destructor!"
            );
        }
    }

    public static void Main(
        string[] args
    ) {
        new ClassExample();
    }
}