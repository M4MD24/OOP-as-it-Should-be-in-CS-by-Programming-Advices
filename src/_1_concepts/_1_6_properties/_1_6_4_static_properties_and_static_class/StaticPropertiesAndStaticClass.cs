using System;

namespace OOP_as_it_should_be_in_CS_by_Programming_Advices._1_concepts._1_6_properties._1_6_4_static_properties_and_static_class;

internal class StaticPropertiesAndStaticClass {
    private class ClassExample {
        public static int dayNumberOfMonth {
            get {
                return DateTime.Today.Day;
            }
        }
    }

    public static void main(
        string[] args
    ) {
        Console.Write(
            "Day Number = {0}",
            ClassExample.dayNumberOfMonth
        );
    }
}