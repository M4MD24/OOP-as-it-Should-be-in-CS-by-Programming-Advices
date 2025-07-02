namespace OOP_as_it_should_be_in_CS_by_Programming_Advices._1_concepts._1_7_principles_and_concepts_of_oop._1_7_3_inheritance;

public class Employee : Person {
    public float salary {
        set;
        get;
    }

    public string departmentName {
        set;
        get;
    } = "";

    public void increaseSalaryBy(
        float amount
    ) {
        salary += amount;
    }
}