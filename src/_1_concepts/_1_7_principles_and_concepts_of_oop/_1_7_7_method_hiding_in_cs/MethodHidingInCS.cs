using System;

namespace OOP_as_it_should_be_in_CS_by_Programming_Advices._1_concepts._1_7_principles_and_concepts_of_oop._1_7_7_method_hiding_in_cs;

public static class MethodHidingInCS {
    public class FirstClass {
        public virtual void firstFunction() {
            Console.WriteLine(
                "First Function of First Class"
            );
        }

        public virtual void secondFunction() {
            Console.WriteLine(
                "Second Function of First Class"
            );
        }
    }

    public class SecondClass : FirstClass {
        public override void firstFunction() {
            Console.WriteLine(
                "First Function of Second Class"
            );
        }

        public override void secondFunction() {
            Console.WriteLine(
                "Second Function of Second Class"
            );
        }
    }

    public static void Main(
        string[] args
    ) {
        new FirstClass().firstFunction();
        new FirstClass().secondFunction();

        new SecondClass().firstFunction();
        new SecondClass().secondFunction();
    }
}