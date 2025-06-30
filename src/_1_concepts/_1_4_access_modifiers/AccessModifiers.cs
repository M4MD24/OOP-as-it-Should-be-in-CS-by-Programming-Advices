namespace OOP_as_it_should_be_in_CS_by_Programming_Advices._1_concepts._1_4_access_modifiers;

internal class AccessModifiers {
    private class FirstClass {
        public    int firstField  = 10;
        private   int secondField = 20;
        protected int thirdField  = 30;

        public int firstFunction() {
            return 100;
        }

        private int secondFunction() {
            return 200;
        }

        protected int thirdFunction() {
            return 300;
        }
    }

    private class SecondClass : FirstClass {
        public int fourthFunction() {
            return firstField + thirdField + thirdFunction();
        }
    }

    public static void Main(
        string[] args
    ) {
        FirstClass firstClass = new FirstClass();
        Console.WriteLine(
            firstClass.firstFunction()
        );
        Console.WriteLine(
            // You Can't
            // firstClass.secondFucntion()
        );

        Console.WriteLine(
            // You Can't
            // firstClass.thirdFucntion()
        );

        SecondClass secondClass = new SecondClass();
        Console.Write(
            secondClass.fourthFunction()
        );
    }
}