using System;

namespace OOP_as_it_should_be_in_CS_by_Programming_Advices._1_concepts._1_6_properties._1_6_2_readonly;

internal class ReadOnlyExample {
    private class ClassExample {
        public readonly int firstNumber = 10;

        public int secondNumber {
            get;
        } = 20;
    }

    public static void main(
        string[] args
    ) {
        ClassExample classExample = new();

        Console.Write(
            "First Number = {0}\nSecond Number = {1}",
            classExample.firstNumber,
            classExample.secondNumber
        );
    }
}