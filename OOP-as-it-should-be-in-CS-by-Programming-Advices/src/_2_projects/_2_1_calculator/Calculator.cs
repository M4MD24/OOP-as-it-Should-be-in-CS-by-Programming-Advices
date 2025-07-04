using System;

namespace OOP_as_it_should_be_in_CS_by_Programming_Advices._2_projects._2_1_calculator;

public class Calculator {
    private enum Operator {
        Add      = '+',
        Subtract = '-',
        Multiply = '*',
        Divide   = '/',
        Clear    = ' '
    };

    private double lastValue {
        set;
        get;
    }

    private Operator lastOperator {
        get;
        set;
    } = Operator.Clear;

    private double lastResult {
        set;
        get;
    }

    private double currentResult {
        set;
        get;
    }

    private static string checkOperator(
        Operator currentOperator
    ) {
        switch (currentOperator) {
            case Operator.Add:
                return "adding";
            case Operator.Subtract:
                return "subtracting";
            case Operator.Multiply:
                return "multiplying";
            case Operator.Divide:
                return "dividing";
            case Operator.Clear:
                return "clearing";
            default:
                return "";
        }
    }

    public void add(
        double value
    ) {
        lastOperator  =  Operator.Add;
        lastValue     =  value;
        lastResult    =  currentResult;
        currentResult += value;
    }

    public void subtract(
        double value
    ) {
        lastOperator  =  Operator.Subtract;
        lastValue     =  value;
        lastResult    =  currentResult;
        currentResult -= value;
    }

    public void multiply(
        double value
    ) {
        lastOperator  =  Operator.Multiply;
        lastValue     =  value;
        lastResult    =  currentResult;
        currentResult *= value;
    }

    public void divide(
        double value
    ) {
        lastOperator = Operator.Divide;
        lastValue    = value;
        lastResult   = currentResult;
        if (value != 0)
            currentResult /= value;
    }

    public void clear() {
        lastOperator  = Operator.Clear;
        lastValue     = 0;
        currentResult = 0;
    }

    public void printResult() {
        Console.Write(
            "{0} after {1}",
            lastResult,
            checkOperator(
                lastOperator
            )
        );

        if (lastOperator != Operator.Clear)
            Console.Write(
                $" {lastValue}"
            );

        Console.Write(
            $" = {currentResult}"
        );

        if (
            lastOperator == Operator.Divide &&
            lastValue    == 0
        )
            Console.Write(
                ", Can't be divided by zero"
            );

        Console.WriteLine();
    }
}