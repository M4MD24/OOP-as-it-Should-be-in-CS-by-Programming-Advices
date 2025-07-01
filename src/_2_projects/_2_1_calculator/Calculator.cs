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
}