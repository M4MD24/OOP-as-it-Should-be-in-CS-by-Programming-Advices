namespace OOP_as_it_should_be_in_CS_by_Programming_Advices._2_projects._2_1_calculator;

public class App {
    public static void Main(
        string[] args
    ) {
        Calculator calculator = new Calculator();

        calculator.add(
            10
        );
        calculator.printResult();

        calculator.add(
            100
        );
        calculator.printResult();

        calculator.subtract(
            20
        );
        calculator.printResult();

        calculator.divide(
            0
        );
        calculator.printResult();

        calculator.divide(
            2
        );
        calculator.printResult();

        calculator.multiply(
            3
        );
        calculator.printResult();

        calculator.clear();
        calculator.printResult();
    }
}