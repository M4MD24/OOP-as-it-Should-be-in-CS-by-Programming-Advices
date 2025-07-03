using System;

namespace OOP_as_it_should_be_in_CS_by_Programming_Advices._1_concepts._1_14_partial._1_14_1_partial_class;

// Can't inherit from a sealed class
// First part of the class
public partial class Person {
    public string firstName  { set; get; } = "";
    public string secondName { set; get; } = "";

    public void printFullName() {
        Console.WriteLine(
            $"{firstName} {secondName}"
        );
    }
}

// Second part of the class
public partial class Person {
    public int age { set; get; }

    public void printAge() {
        Console.WriteLine(
            $"Age: {age}"
        );
    }
}

class PartialClass {
    static void main() {
        Person person = new Person();
        person.firstName  = "Mohamed";
        person.secondName = "Sadawy";
        person.age        = 22;

        person.printFullName();
        person.printAge();
    }
}