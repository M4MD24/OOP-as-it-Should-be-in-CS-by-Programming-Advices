using System;

namespace OOP_as_it_should_be_in_CS_by_Programming_Advices._1_concepts._1_10_interface._1_10_2_implementing_multiple_interfaces;

public interface Named {
    string firstName  { set; get; }
    string secondName { set; get; }

    void introduce();
}

public interface Communicate {
    void callPhone();

    void sendEmail(
        string title,
        string body
    );

    void sendSMS(
        string title,
        string body
    );

    void sendFax(
        string title,
        string body
    );
}

// You cannot create an object of an abstract class, you can only inherit it.
public abstract class Person : Named,
                               Communicate {
    public string firstName  { get; set; } = "";
    public string secondName { get; set; } = "";

    public abstract void introduce();

    public void saySalam() {
        Console.WriteLine(
            "Salam!"
        );
    }

    public void callPhone() {
        Console.WriteLine(
            "Calling Phone"
        );
    }

    public void sendEmail(
        string title,
        string body
    ) {
        Console.WriteLine(
            "Email Sent"
        );
    }

    public void sendSMS(
        string title,
        string body
    ) {
        Console.WriteLine(
            "SMS Sent"
        );
    }

    public void sendFax(
        string title,
        string body
    ) {
        Console.WriteLine(
            "Fax Sent"
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

public class ImplementingMultipleInterfaces {
    public static void Main() {
        Employee employee = new Employee {
            firstName  = "Mohamed",
            secondName = "Sadawy",
            employeeId = 123
        };
        employee.introduce();
        employee.saySalam();
        employee.callPhone();
        employee.sendEmail(
            "Title",
            "Body"
        );
        employee.sendSMS(
            "Title",
            "Body"
        );
        employee.sendFax(
            "Title",
            "Body"
        );
    }
}