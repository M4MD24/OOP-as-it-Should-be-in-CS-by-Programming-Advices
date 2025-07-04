using System;

namespace OOP_as_it_should_be_in_CS_by_Programming_Advices._1_concepts._1_7_principles_and_concepts_of_oop._1_7_5_upcasting_and_downcasting;

public class Person {
    public int id {
        set;
        get;
    }

    public string firstName {
        set;
        get;
    }

    public string secondName {
        set;
        get;
    }

    public string fullName => firstName + ' ' + secondName;

    public Person(
        int    id,
        string firstName,
        string secondName
    ) {
        this.id         = id;
        this.firstName  = firstName;
        this.secondName = secondName;
    }

    public void great() {
        Console.WriteLine(
            "Alsalam alaykum wa rahmat allah wa barakatuh, My name is {0} and my id is {1}",
            fullName,
            id
        );
    }
}