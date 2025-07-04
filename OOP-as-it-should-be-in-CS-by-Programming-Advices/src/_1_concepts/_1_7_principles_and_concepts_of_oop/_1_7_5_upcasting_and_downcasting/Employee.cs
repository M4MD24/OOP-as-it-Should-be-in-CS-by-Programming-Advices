using System;

namespace OOP_as_it_should_be_in_CS_by_Programming_Advices._1_concepts._1_7_principles_and_concepts_of_oop._1_7_5_upcasting_and_downcasting;

public class Employee : Person {
    public float salary {
        set;
        get;
    }

    public string departmentName {
        set;
        get;
    } = "";

    public Employee(
        int    id,
        string firstName,
        string secondName,
        float  salary,
        string departmentName
    ) : base(
        id,
        firstName,
        secondName
    ) {
        this.salary         = salary;
        this.departmentName = departmentName;
    }

    public void work() {
        Console.WriteLine(
            "My department is in {0}, and earn {1}",
            departmentName,
            salary
        );
    }
}