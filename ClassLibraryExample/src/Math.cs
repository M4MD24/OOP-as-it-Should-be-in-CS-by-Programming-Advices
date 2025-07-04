namespace ClassLibraryExample;

interface Operations {
    double sum(
        double firstNumber,
        double secondNumber
    );

    double subtract(
        double firstNumber,
        double secondNumber
    );

    double multiply(
        double firstNumber,
        double secondNumber
    );

    double divide(
        double firstNumber,
        double secondNumber
    );
}

public class Math : Operations {
    public double sum(
        double firstNumber,
        double secondNumber
    ) {
        return firstNumber + secondNumber;
    }

    public double subtract(
        double firstNumber,
        double secondNumber
    ) {
        return firstNumber - secondNumber;
    }

    public double multiply(
        double firstNumber,
        double secondNumber
    ) {
        return firstNumber * secondNumber;
    }

    public double divide(
        double firstNumber,
        double secondNumber
    ) {
        return firstNumber / secondNumber;
    }
}