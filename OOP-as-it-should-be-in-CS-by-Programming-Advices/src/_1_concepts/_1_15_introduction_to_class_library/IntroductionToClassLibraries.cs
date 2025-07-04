using System;
using Math = ClassLibraryExample.Math;

namespace OOP_as_it_should_be_in_CS_by_Programming_Advices._1_concepts._1_15_introduction_to_class_library;

public class IntroductionToClassLibrary {
    public static void Main(
        string[] args
    ) {
        Math math = new Math();
        const double FIRST_NUMBER  = 5,
                     SECOND_NUMBER = 2;

        Console.Write(
            FIRST_NUMBER + " + " + SECOND_NUMBER + " = {0}" + Environment.NewLine +
            FIRST_NUMBER + " - " + SECOND_NUMBER + " = {1}" + Environment.NewLine +
            FIRST_NUMBER + " * " + SECOND_NUMBER + " = {2}" + Environment.NewLine +
            FIRST_NUMBER + " / " + SECOND_NUMBER + " = {3}",
            math.sum(
                FIRST_NUMBER,
                SECOND_NUMBER
            ),
            math.subtract(
                FIRST_NUMBER,
                SECOND_NUMBER
            ),
            math.multiply(
                FIRST_NUMBER,
                SECOND_NUMBER
            ),
            math.divide(
                FIRST_NUMBER,
                SECOND_NUMBER
            )
        );
    }
}