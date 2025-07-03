using System;

namespace OOP_as_it_should_be_in_CS_by_Programming_Advices._1_concepts._1_7_principles_and_concepts_of_oop._1_7_7_method_hiding_in_cs;

public static class MethodHidingInCS {
    public class FirstClass {
        public virtual void firstFunction() {
            Console.WriteLine(
                "First Function of First Class"
            );
        }

        public void secondFunction() {
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

        public new void secondFunction() {
            Console.WriteLine(
                "Second Function of Second Class"
            );
        }
    }

    public static void main(
        string[] args
    ) {
        FirstClass firstClass1 = new FirstClass();
        firstClass1.firstFunction();
        firstClass1.secondFunction();

        Console.WriteLine();

        SecondClass secondClass1 = new SecondClass();
        secondClass1.firstFunction();
        secondClass1.secondFunction();

        Console.WriteLine();

        // When upcasting
        FirstClass firstClass2 = new SecondClass();
        firstClass2.firstFunction();
        firstClass2.secondFunction();
    }
}