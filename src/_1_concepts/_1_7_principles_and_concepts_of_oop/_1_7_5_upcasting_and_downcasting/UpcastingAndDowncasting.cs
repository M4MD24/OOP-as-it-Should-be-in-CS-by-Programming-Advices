using System;

namespace OOP_as_it_should_be_in_CS_by_Programming_Advices._1_concepts._1_7_principles_and_concepts_of_oop._1_7_5_upcasting_and_downcasting;

public class UpcastingAndDowncasting {
    public static void Main(
        string[] args
    ) {
        Employee employee1 = new Employee(
            1,
            "Mohamed",
            "Sadawy",
            76000,
            "Android Development"
        );
        Person person1 = employee1; // Upcasting
        person1.great();

        Person person2 = new Employee(
            2,
            "Ahmed",
            "Mahmoud",
            54000,
            "Android Development"
        );
        Employee employee2 = (Employee) person2; // Downcasting
        employee2.work();

        Person person3 = new Person(
            3,
            "Abu-Bakr",
            "Al-Siddiq"
        );
        Employee employee3 = (Employee) person3; // Another Upcasting with error
        employee3.work();
    }
}