using System;

namespace OOP_as_it_should_be_in_CS_by_Programming_Advices._1_concepts._1_9_abstract_class_and_methods;

// You cannot create an object of an abstract class, you can only inherit it.
public abstract class Person {
    public string firstName  { get; set; } = "";
    public string secondName { get; set; } = "";

    public abstract void introduce();

    public void saySalam() {
        Console.WriteLine(
            "Salam!"
        );
    }
}

public class Employee : Person {
    public int employeeId { get; set; }

    public override void introduce() {
        Console.WriteLine(
            $"Alsalam alaykum wa rahmat allah wa barakatuh, my name is {firstName} {secondName}, and my employee ID is {employeeId}."
        );
    }
}

public class AbstractClassAndMethods {
    public static void main() {
        Employee employee = new Employee();
        employee.firstName  = "Mohamed";
        employee.secondName = "Sadawy";
        employee.employeeId = 123;
        employee.introduce();
        employee.saySalam();
    }
}