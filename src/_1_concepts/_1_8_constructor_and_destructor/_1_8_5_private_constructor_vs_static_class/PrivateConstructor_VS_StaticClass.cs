using System;

namespace OOP_as_it_should_be_in_CS_by_Programming_Advices._1_concepts._1_8_constructor_and_destructor._1_8_5_private_constructor_vs_static_class;

public class PrivateConstructorVsStaticClass {
    private class FirstClass {
        public static int dayNumberOfMonth => DateTime.Today.Day;

        public static string dayOfWeekName => DateTime.Today.DayOfWeek.ToString();

        // this is a private constructor to prevent creating object from this class
        private FirstClass() {}
    }

    static class SecondClass {
        public static int dayNumberOfMonth => DateTime.Today.Day;

        public static string dayOfWeekName => DateTime.Today.DayOfWeek.ToString();
    }

    public static void Main(
        string[] args
    ) {
        Console.Write(
            "Day Number of Month: {0}\nDay of Week Name: {1}",
            FirstClass.dayNumberOfMonth,
            SecondClass.dayOfWeekName
        );
    }
}