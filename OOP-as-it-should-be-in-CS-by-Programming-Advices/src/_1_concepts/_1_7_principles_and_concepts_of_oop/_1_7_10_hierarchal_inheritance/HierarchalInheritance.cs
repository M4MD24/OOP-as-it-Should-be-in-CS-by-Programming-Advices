using System;

namespace OOP_as_it_should_be_in_CS_by_Programming_Advices._1_concepts._1_7_principles_and_concepts_of_oop._1_7_10_hierarchal_inheritance;

public class Person {
    public string name { get; set; } = "";
    public int    age  { get; set; }

    public void introduce() {
        Console.WriteLine(
            $"Alsalam alaykum wa rahmat allah wa barakatuh, I'm {name}, {age} years old."
        );
    }
}

public class Employee : Person {
    public int     employeeId { get; set; }
    public decimal salary     { get; set; }

    public void work() {
        Console.WriteLine(
            $"Employee with ID {employeeId} and salary {salary:N} is working."
        );
    }
}

public class User : Person {
    public string username { get; set; } = "";
    public string password { get; set; } = "";

    public void information() {
        Console.WriteLine(
            $"Username ({username}) and Password ({password})."
        );
    }
}

class HierarchalInheritance {
    static void main(
        string[] args
    ) {
        // إنشاء كائن من نوع Employee
        Employee employee = new Employee {
            name       = "Mohamed Sadawy",
            age        = 22,
            employeeId = 1001,
            salary     = 5000.75m
        };
        employee.introduce();
        employee.work();

        Console.WriteLine();

        User user = new User {
            name     = "Ahmed Mahmoud",
            age      = 25,
            username = "Ahmed210",
            password = "@hmed_210"
        };
        user.introduce();
        user.information();
    }
}