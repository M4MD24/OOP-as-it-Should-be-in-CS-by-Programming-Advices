namespace OOP_as_it_should_be_in_CS_by_Programming_Advices._1_concepts._1_7_principles_and_concepts_of_oop._1_7_4_inheritance_constructor;

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
}