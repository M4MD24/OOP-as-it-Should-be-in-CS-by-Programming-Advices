using System;

namespace OOP_as_it_should_be_in_CS_by_Programming_Advices._1_concepts._1_14_partial._1_14_2_partial_method;

public partial class ClassExample {
    partial void OnProcessStarted();

    public void startProcess() {
        Console.WriteLine(
            "Starting process..."
        );
        OnProcessStarted(); // This will be removed by compiler if not implemented
    }
}

public partial class ClassExample {
    // Optional implementation of the partial method
    partial void OnProcessStarted() {
        Console.WriteLine(
            "Process started."
        );
    }
}

public class PartialMethod {
    static void Main() {
        ClassExample classExample = new ClassExample();
        classExample.startProcess();
    }
}