using System;

namespace OOP_as_it_should_be_in_CS_by_Programming_Advices._1_concepts._1_7_principles_and_concepts_of_oop._1_7_3_inheritance;

public class InheritanceExample {
    public static void main(
        string[] args
    ) {
        Employee employee = new Employee();
        employee.id             = 1;
        employee.firstName      = "Mohamed";
        employee.secondName     = "Sadawy";
        employee.salary         = 76000;
        employee.departmentName = "Android Development";
        employee.increaseSalaryBy(
            23000
        );

        printInformation(
            employee
        );
    }

    private static void printInformation(
        Employee employee
    ) {
        Console.Write(
            "(Employee Information)\n" +
            "ID: {0}\n"                +
            "Full Name: {1}\n"         +
            "Salary: {2}\n"            +
            "Department Name: {3}",
            employee.id,
            employee.fullName,
            employee.salary,
            employee.departmentName
        );
    }
}