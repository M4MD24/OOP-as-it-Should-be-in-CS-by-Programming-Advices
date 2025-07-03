using System;

namespace OOP_as_it_should_be_in_CS_by_Programming_Advices._1_concepts._1_10_interface._1_10_1_what_is_interface_and_why;

public interface Named {
    public string firstName  { set; get; }
    public string secondName { set; get; }

    public void introduce();
}

// You cannot create an object of an abstract class, you can only inherit it.
public abstract class Person : Named {
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

public class WhatIsInterfaceAndWhy {
    public static void Main() {
        Employee employee = new Employee {
            firstName  = "Mohamed",
            secondName = "Sadawy",
            employeeId = 123
        };
        employee.introduce();
        employee.saySalam();
    }
}