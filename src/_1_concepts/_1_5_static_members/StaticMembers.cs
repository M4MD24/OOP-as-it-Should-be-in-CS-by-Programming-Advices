namespace OOP_as_it_should_be_in_CS_by_Programming_Advices._1_concepts._1_5_static_members;

internal class StaticMembers {
    private class ClassExample {
        public        int firstField;
        public static int secondField;

        public int firstFunction() {
            return firstField + secondField;
        }

        public static int secondFunction() {
            return secondField;
        }
    }

    public static void Main(
        string[] args
    ) {
        ClassExample firstClass  = new(),
                     secondClass = new();

        firstClass.firstField  = 10;
        secondClass.firstField = 20;

        ClassExample.secondField = 30;

        Console.WriteLine(
            "First Class:\nFirst Function = {0}\nSecond Function = {1}",
            firstClass.firstFunction(),
            ClassExample.secondFunction()
        );

        ClassExample.secondField = 40;

        Console.Write(
            "\nSecond Class:\nFirst Function = {0}\nSecond Function = {1}",
            secondClass.firstFunction(),
            ClassExample.secondFunction()
        );
    }
}