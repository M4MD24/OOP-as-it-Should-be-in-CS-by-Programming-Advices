using System;

namespace OOP_as_it_should_be_in_CS_by_Programming_Advices._1_concepts._1_6_properties._1_6_1_set_and_get;

internal class SetAndGet {
    private class ClassExample {
        public int number {
            set;
            get;
        }
    }

    public static void main(
        string[] args
    ) {
        ClassExample classExample = new();
        classExample.number = 10;
        Console.Write(
            classExample.number
        );
    }
}