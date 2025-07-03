using System;

namespace OOP_as_it_should_be_in_CS_by_Programming_Advices._1_concepts._1_7_principles_and_concepts_of_oop._1_7_9_multiple_level_inheritance;

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

public class Developer : Employee {
    public string specialty { get; set; } = "";

    public void develop() {
        Console.WriteLine(
            $"Developer {name} with ID {employeeId}, salary {salary:N}, and specialty {specialty} is develops projects."
        );
    }
}

class MultipleLevelInheritance {
    static void Main(
        string[] args
    ) {
        Developer developer = new Developer();
        developer.name       = "Mohamed Sadway";
        developer.age        = 35;
        developer.employeeId = 123;
        developer.salary     = 100000.00M;
        developer.specialty  = "Android Application Development";
        developer.introduce();
        developer.work();
        developer.develop();
    }
}